using RoboFeudal.Simulation.Models.Rules;

namespace RoboFeudal.Simulation.Models.Forces
{
    public class Fortification : Force
    {
        public FortificationType Type { get; internal set; }
    }
}