namespace RoboFeudal.Simulation.Models.Rules
{
    public class ArmyCap
    {
        internal ArmyCap(UnitGrade grade, int number)
        {
            Grade = grade;
            NumberOfUnits = number;
        }

        public UnitGrade Grade { get; internal set; }
        public int NumberOfUnits { get; internal set; }
    }
}