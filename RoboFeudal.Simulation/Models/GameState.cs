using System.Collections.Generic;
using RoboFeudal.Simulation.Models.Map;
using RoboFeudal.Simulation.Models.Rules;

namespace RoboFeudal.Simulation.Models
{
    public class GameState
    {
        public IEnumerable<Player> Players { get; internal set; }

        public IEnumerable<Province> Provinces { get; internal set; }

        public GameRules Rules { get; internal set; }
    }
}
