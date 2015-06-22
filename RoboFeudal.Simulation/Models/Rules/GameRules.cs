using System.Collections.Generic;

namespace RoboFeudal.Simulation.Models.Rules
{
    public class GameRules
    {
        public IEnumerable<UnitType> UnitTypes { get; internal set; }

        public IEnumerable<FortificationType> FortificationTypes { get; internal set; }

        public bool EnforceArmyCaps { get; internal set; }

        public IEnumerable<ArmyCap> ArmyCaps { get; internal set; }

        public bool EnforceSupplyCaps { get; internal set; }

        public IEnumerable<SupplyCap> SupplyCaps { get; internal set; }

        public IEnumerable<DaimyoProgression> DaimyoProgression { get; internal set; }

        public int MaxProvincialForces { get; internal set; }

        public bool RestrictUnitsLeviedPerTurn { get; internal set; }

        public int MaxUnitsLeviedPerProvincePerTurn { get; internal set; }

        public bool EnforceRoninStackingRules { get; internal set; }
    }
}