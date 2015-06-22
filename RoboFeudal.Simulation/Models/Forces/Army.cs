namespace RoboFeudal.Simulation.Models.Forces
{
    public class Army : Force
    {
        public int DaimyoLevel { get; internal set; }
        public bool IsDaimyoAssasinated { get; internal set; }
        public int MovesMade { get; internal set; }
    }
}