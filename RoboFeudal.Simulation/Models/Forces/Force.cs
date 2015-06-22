using System.Collections.Generic;
using System.Linq;
using RoboFeudal.Simulation.Models.Map;

namespace RoboFeudal.Simulation.Models.Forces
{
    public class Force
    {
        public Province Location { get; internal set; }

        public HashSet<UnitTypeAndCount> Units { get; internal set; }

        internal void ClearUnits()
        {
            Units.Clear();
        }

        internal bool IsDefeated
        {
            get { return !Units.Any(x => x.Count > 0); }
        }
    }
}