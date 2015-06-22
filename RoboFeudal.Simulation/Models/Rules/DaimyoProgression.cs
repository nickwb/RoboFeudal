using System.Collections.Generic;
using System.Linq;

namespace RoboFeudal.Simulation.Models.Rules
{
    public class DaimyoProgression
    {
        internal DaimyoProgression(int level, int moves)
        {
            Level = level;
            Moves = moves;
        }

        public int Level { get; internal set; }
        public int Moves { get; internal set; }

        public static IEnumerable<DaimyoProgression> DefineSequence(params int[] moves)
        {
            return moves.Select((move, idx) => new DaimyoProgression(idx + 1, move)).ToArray();
        }
    }
}