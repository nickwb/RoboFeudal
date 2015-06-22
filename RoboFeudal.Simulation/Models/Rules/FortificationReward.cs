using System.Collections.Generic;

namespace RoboFeudal.Simulation.Models.Rules
{
    public class FortificationReward
    {
        internal FortificationReward(UnitType unit, int count)
        {
            Count = count;
            Unit = unit;
        }

        public int Count { get; internal set; }
        public UnitType Unit { get; internal set; }

        public static IEnumerable<FortificationReward> Only(UnitType unit, int count)
        {
            return new[] { new FortificationReward(unit, count) };
        }
    }
}