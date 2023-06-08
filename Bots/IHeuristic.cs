using ScriptsOfTribute.Serializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bots
{
    public interface IHeuristic
    {
        public double Value(SeededGameState gameState);

    }
}
