using System.Collections.Generic;
using RoboFeudal.Simulation.Models.Forces;

namespace RoboFeudal.Simulation.Models.Map
{
    public class Province
    {
        private GameState GameState { get; set; }

        public string Name { get; private set; }

        public Player Occupant { get; private set; }

        public bool IsOccupied
        {
            get { return Occupant != null; }
        }

        public IEnumerable<Adjacency> AdjacentProvinces { get; internal set; }

        public ProvincialForce ProvincialForce { get; internal set; }

        public bool HasProvincialForce
        {
            get { return ProvincialForce != null; }
        }

        public Army ResidingArmy { get; internal set; }

        public bool HasResidingArmy
        {
            get { return ResidingArmy != null; }
        }

        public Fortification Fortification { get; internal set; }

        public bool HasFortification
        {
            get { return Fortification != null; }
        }

        internal void DoPreBattleSetup()
        {
            
        }

        internal void DoPostBattleCleanup()
        {
            if (ProvincialForce != null && ProvincialForce.IsDefeated) {
                ProvincialForce = null;
            }

            if (ResidingArmy != null && ResidingArmy.IsDefeated) {
                ResidingArmy = null;
            }

            if (Fortification != null) {
                Fortification.ClearUnits();
            }

            if (ProvincialForce == null && ResidingArmy == null) {
                Occupant = null;
            }
        }
    }
}