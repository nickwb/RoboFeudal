using RoboFeudal.Simulation.Models.Rules;

namespace RoboFeudal.Simulation.RuleSet
{
    public static class ClassicUnits
    {
        public static readonly UnitType Daimyo = new UnitType("Daimyo", UnitGrade.Daimyo, AttackType.Melee, LevyType.Diamyo, combatValue: 6, unitsPerCoin: 0);

        public static readonly UnitType Bowman = new UnitType("Bowman", UnitGrade.Samurai, AttackType.Ranged, LevyType.Normal, combatValue: 6, unitsPerCoin: 1);

        public static readonly UnitType Gunner = new UnitType("Gunner", UnitGrade.Ashigaru, AttackType.Ranged, LevyType.Normal, combatValue: 4, unitsPerCoin: 2);

        public static readonly UnitType Swordsman = new UnitType("Swordsman", UnitGrade.Samurai, AttackType.Melee, LevyType.Normal, combatValue: 5, unitsPerCoin: 2);

        public static readonly UnitType Spearmen = new UnitType("Spearmen", UnitGrade.Ashigaru, AttackType.Melee, LevyType.Normal, combatValue: 4, unitsPerCoin: 3);

        public static readonly UnitType Ronin = new UnitType("Ronin", UnitGrade.Ronin, AttackType.Melee, LevyType.Ronin, combatValue: 5, unitsPerCoin: 2);

        public static readonly FortificationType Castle = new FortificationType("Castle", 2, null, FortificationReward.Only(Spearmen, 4));

        public static readonly FortificationType Fortress = new FortificationType("Fortress", 2, Castle, FortificationReward.Only(Ronin, 5));
    }
}