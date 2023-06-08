using System;
using System.Collections.Generic;
using System.Text;
using ScriptsOfTribute;
using ScriptsOfTribute.AI;
using ScriptsOfTribute.Board;
using ScriptsOfTribute.Serializers;

namespace Bots
{
    internal class MyFirstBot2 : AI
    {
        public override void GameEnd(EndGameState state, FullGameState? finalBoardState)
        {
            Console.WriteLine("Game is over at MyFirstBot2");
        }

        public override Move Play(GameState gameState, List<Move> possibleMoves)
        {
            /* SeededRandom rnd = new SeededRandom();
             int n = rnd.Next();*/
             return possibleMoves.ElementAt(0);
         }

         public override PatronId SelectPatron(List<PatronId> availablePatrons, int round)
         {
            int version = 4;
             Console.WriteLine("Version 1.0");
            /*SeededRandom rnd = new SeededRandom();
            int n = rnd.Next();
            Log("Action idx " + n);*/
            return availablePatrons.ElementAt(0);
        }
    }
}
