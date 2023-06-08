using ScriptsOfTribute;
using ScriptsOfTribute.Board.CardAction;
using ScriptsOfTribute.Serializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bots
{
    class ElasticMCTSUtils
    {
        // Returns all possible moves with the exception of the END_TURN
        public static List<Move> NotEndTurnPossibleMoves(List<Move> possibleMoves)
        {
            return possibleMoves.Where(m => m.Command != CommandEnum.END_TURN).ToList();
        }

        // Retuns one of the possible moves from the list received as parameter at random. 
        // Prioritizes not END_TURN moves.
        public static Move DrawNextMove(List<Move> possibleMoves, SeededGameState gameState, SeededRandom rng)
        {
            Move nextMove;
            List<Move> notEndTurnPossibleMoves = ElasticMCTSUtils.NotEndTurnPossibleMoves(possibleMoves);
            if (notEndTurnPossibleMoves.Count > 0)
            {
                if ((gameState.BoardState == BoardState.NORMAL) && (Extensions.RandomK(0, 10000, rng) == 0))
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
            return nextMove;
        }


    }
}
