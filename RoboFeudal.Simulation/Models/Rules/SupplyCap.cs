namespace RoboFeudal.Simulation.Models.Rules
{
    public class SupplyCap
    {
        internal SupplyCap(UnitType type, int number, bool sharedCap = false)
        {
            Type = type;
            NumberOfUnits = number;
            IsSharedCap = sharedCap;
        }

        public UnitType Type { get; internal set; }
        public int NumberOfUnits { get; internal set; }
        public bool IsSharedCap { get; internal set; }
    }
}