using System;
using ScriptsOfTribute;

using ScriptsOfTribute.AI;
using ScriptsOfTribute.Board;
using ScriptsOfTribute.Serializers;
using System.Diagnostics;
using ScriptsOfTribute.Board.CardAction;
using ScriptsOfTribute.Board.Cards;

/**
 * Agent initially based on MCTSBot distributed with the Scripts of Tribute Framework.
 * Then, adapted to conform to Elastic MCTS: https://ieeexplore.ieee.org/document/10143265
 */
namespace Bots
{

    public class ElasticTreeNode
    {
        static double c = Math.Sqrt(2);
        public List<ElasticTreeNode>? children;
        public ElasticTreeNode? parent;
        public SeededGameState nodeGameState;
        public Move? move;
        public List<Move> possibleMoves;
        public double wins;
        public ulong visits;
        public IHeuristic stateEvalHeuristic;

        public ElasticTreeNode(SeededGameState fatherGameState, IHeuristic heuristic, Move? nodeMove, ElasticTreeNode? fatherOrig, 
            List<Move> possibleMoves = null)
        {
            this.wins = 0;
            this.visits = 0;
            this.stateEvalHeuristic = heuristic;

            this.move = nodeMove;
            if (nodeMove is not null && nodeMove.Command != CommandEnum.END_TURN)
            {
                var (newGameState, newMoves) = fatherGameState.ApplyMove(nodeMove);
                this.nodeGameState = newGameState;
                this.possibleMoves = newMoves;
            }
            else
            {
                this.nodeGameState = fatherGameState;
                this.possibleMoves = possibleMoves;
            }

            this.parent = fatherOrig;

            this.children = new List<ElasticTreeNode>();
        }

        public void CreateChilds()
        {
            foreach (Move childMove in this.possibleMoves)
            {
                this.children.Add(new ElasticTreeNode(this.nodeGameState, stateEvalHeuristic, childMove, this));
            }
        }

        public double UCBscore()
        {
            if (this.visits < 1)
            {
                return int.MaxValue;
            }
            double tmpWins = this.wins;
            ulong tmpVisits = this.visits;

            if (this.parent is not null)
            {
                return tmpWins + c * Math.Sqrt((Math.Log(this.parent.visits)) / tmpVisits);
            }
            else
            {
                return tmpWins + c * Math.Sqrt((Math.Log(tmpVisits)) / tmpVisits);
            }
        }

        public ElasticTreeNode SelectBestChild()
        {
            ElasticTreeNode bestChild = this.children[0];

            double bestScore = 0;

            foreach (ElasticTreeNode child in this.children)
            {
                double tmpWins = child.wins;
                ulong tmpVisits = child.visits;
                double tmpScore = tmpVisits; //+ c*Math.Sqrt((Math.Log(this.visits))/tmpVisits);

                if (tmpScore >= bestScore)
                {
                    bestScore = tmpScore;
                    bestChild = child;
                }
            }
            return bestChild;
        }


        public double Simulate(SeededRandom rng)
        {

            if (this.move.Command == CommandEnum.END_TURN)
            {
                return stateEvalHeuristic.Value(this.nodeGameState);
            }

            List<Move> notEndTurnPossibleMoves = ElasticMCTSUtils.NotEndTurnPossibleMoves(this.possibleMoves);
            Move nextMove;
            if (notEndTurnPossibleMoves.Count > 0)
            {
                if ((this.nodeGameState.BoardState == BoardState.NORMAL) && (Extensions.RandomK(0, 100000, rng) == 0))
                {
                    nextMove = Move.EndTurn();
                }
                else
                {
                    nextMove = notEndTurnPossibleMoves.PickRandom(rng);
                }
            }
            else
            {
                nextMove = Move.EndTurn();
            }

            var gameState = this.nodeGameState;
            var (seedGameState, newMoves) = gameState.ApplyMove(nextMove);
            nextMove = ElasticMCTSUtils.DrawNextMove(newMoves, seedGameState, rng);

            while (nextMove.Command != CommandEnum.END_TURN)
            {

                var (newSeedGameState, newPossibleMoves) = seedGameState.ApplyMove(nextMove);
                nextMove = ElasticMCTSUtils.DrawNextMove(newPossibleMoves, newSeedGameState, rng);
                seedGameState = newSeedGameState;
            }

            return stateEvalHeuristic.Value(gameState);
        }



    }

    public class ElasticMCTSBot : AI
    {

        ElasticTreeNode? actRoot;
        ElasticTreeNode? actNode;
        bool startOfTurn;
        TimeSpan usedTimeInTurn = TimeSpan.FromSeconds(0);
        TimeSpan timeForMoveComputation = TimeSpan.FromSeconds(0.3);
        TimeSpan TurnTimeout = TimeSpan.FromSeconds(29.9);
        Move endTurnMove = Move.EndTurn();
        Move move;
        private const ulong botSeed = 42;
        private string patronLogPath = "patronsMCTSBot.txt";
        private PlayerEnum myID;
        private string patrons;
        private bool startOfGame = true;
        private readonly SeededRandom rng = new(botSeed);
        private IHeuristic stateEvaluationHeuristic = new ElasticMCTSDefaultHeuristic();

        public ElasticMCTSBot()
        {
            this.PrepareForGame();
        }

        private void PrepareForGame()
        {
            actRoot = null;
            actNode = null;
            startOfGame = true;
            startOfTurn = true;
        }

        private bool CheckIfPossibleMovesAreTheSame(List<Move> possibleMoves1, List<Move> possibleMoves2)
        {
            if (possibleMoves1.Count != possibleMoves2.Count)
            {
                return false;
            }
            foreach (Move move in possibleMoves1)
            {
                if (!possibleMoves2.Contains(move))
                {
                    return false;
                }
            }
            return true;
        }

        private ElasticTreeNode TreePolicy(ElasticTreeNode v, SeededRandom rng)
        {
            if (v.children.Count() > 0)
            {
                double maxValue = double.MinValue;
                int selectedChild = 0;
                int index = 0;
                foreach (ElasticTreeNode childNode in v.children)
                {
                    if (childNode.UCBscore() > maxValue)
                    {
                        maxValue = childNode.UCBscore();
                        selectedChild = index;
                    }
                    index++;
                }
                return TreePolicy(v.children[selectedChild], rng);
            }

            if (v.move.Command == CommandEnum.END_TURN)
            {
                return v;
            }
            v.CreateChilds();
            return v;
        }

        private void BackUp(ElasticTreeNode? v, double delta)
        {
            if (v is not null)
            {
                v.visits += 1;

                v.wins = Math.Max(delta, v.wins);//delta;//

                BackUp(v.parent, delta);
            }
        }

        public override PatronId SelectPatron(List<PatronId> availablePatrons, int round)
            => availablePatrons.PickRandom(rng);

        public override Move Play(GameState gameState, List<Move> possibleMoves)
        {
            if (startOfGame)
            {
                myID = gameState.CurrentPlayer.PlayerID;
                patrons = string.Join(",", gameState.Patrons.FindAll(x => x != PatronId.TREASURY).Select(n => n.ToString()).ToArray());
                startOfGame = false;
            }

            var sgs = gameState.ToSeededGameState(botSeed);
            if (startOfTurn)
            {
                actRoot = new ElasticTreeNode(sgs, stateEvaluationHeuristic, null, null, possibleMoves);
                actRoot.CreateChilds();
                startOfTurn = false;
                usedTimeInTurn = TimeSpan.FromSeconds(0);
            }
            else
            {
                if (!CheckIfPossibleMovesAreTheSame(actRoot.possibleMoves, possibleMoves))
                {
                    actRoot = new ElasticTreeNode(sgs, stateEvaluationHeuristic, null, null, possibleMoves);
                    actRoot.CreateChilds();
                }
            }

            if (possibleMoves.Count == 1 && possibleMoves[0].Command == CommandEnum.END_TURN)
            {
                startOfTurn = true;
                usedTimeInTurn = TimeSpan.FromSeconds(0);
                return endTurnMove;
            }

            if (usedTimeInTurn + timeForMoveComputation >= TurnTimeout)
            {
                move = possibleMoves.PickRandom(rng);
            }
            else
            {

                actRoot.parent = null;

                int actionCounter = 0;
                Stopwatch s = new Stopwatch();
                s.Start();
                while (s.Elapsed < timeForMoveComputation)
                {
                    actNode = TreePolicy(actRoot, rng);
                    double delta = actNode.Simulate(rng);
                    BackUp(actNode, delta);
                    actionCounter++;
                }
                usedTimeInTurn += timeForMoveComputation;

                actRoot = actRoot.SelectBestChild();
                move = actRoot.move;
            }

            if (move.Command == CommandEnum.END_TURN)
            {
                startOfTurn = true;
                usedTimeInTurn = TimeSpan.FromSeconds(0);
            }
            return move;
        }

        public override void GameEnd(EndGameState state, FullGameState? finalBoardState)
        {
            this.PrepareForGame();
            if (state.Winner == myID)
            {
                File.AppendAllText(patronLogPath, patrons + System.Environment.NewLine);
            }
        }
    }
}
