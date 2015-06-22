using System.Collections.Generic;

namespace RoboFeudal.Simulation.Models
{
    public class RoundDetails
    {
        public int RoundNumber { get; private set; }

        public IEnumerable<Player> TurnOrder { get; private set; }

        public int CurrentTurn { get; set; }
    }
}