namespace RoboFeudal.Simulation.Models.Rules
{
    public class UnitType
    {
        internal UnitType(string name, UnitGrade grade, AttackType attack, LevyType levy, int combatValue, int unitsPerCoin)
        {
            Name = name;
            Grade = grade;
            Attack = attack;
            LevyType = levy;
            CombatValue = combatValue;
            UnitsPerCoin = unitsPerCoin;
        }

        public string Name { get; internal set; }

        public int UnitsPerCoin { get; internal set; }

        public int CombatValue { get; internal set; }

        public AttackType Attack { get; internal set; }

        public UnitGrade Grade { get; internal set; }

        public LevyType LevyType { get; internal set; }
    }
}