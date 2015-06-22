using RoboFeudal.Simulation.Models;
using RoboFeudal.Simulation.Models.Rules;

namespace RoboFeudal.Simulation.RuleSet
{
    public class ClassicRules
    {
        public GameState BuildInitialGameState()
        {
            var state = new GameState();

            state.Rules = new GameRules();

            state.Rules.UnitTypes = new[] {
                ClassicUnits.Daimyo,
                ClassicUnits.Bowman,
                ClassicUnits.Gunner,
                ClassicUnits.Swordsman,
                ClassicUnits.Spearmen,
                ClassicUnits.Ronin
            };

            state.Rules.FortificationTypes = new[] {
                ClassicUnits.Castle,
                ClassicUnits.Fortress
            };

            state.Rules.EnforceArmyCaps = true;

            state.Rules.ArmyCaps = new[] {
                new ArmyCap(UnitGrade.Daimyo, 1),
                new ArmyCap(UnitGrade.Samurai, 4),
                new ArmyCap(UnitGrade.Ashigaru, 10), 
            };

            state.Rules.EnforceSupplyCaps = true;

            state.Rules.SupplyCaps = new[] {
                new SupplyCap(ClassicUnits.Daimyo, 3),
                new SupplyCap(ClassicUnits.Bowman, 9), 
                new SupplyCap(ClassicUnits.Gunner, 9), 
                new SupplyCap(ClassicUnits.Swordsman, 9), 
                new SupplyCap(ClassicUnits.Spearmen, 36), 
                new SupplyCap(ClassicUnits.Ronin, 30, true),
            };

            state.Rules.DaimyoProgression = DaimyoProgression.DefineSequence(1, 1, 1, 2, 2, 3);

            state.Rules.MaxProvincialForces = 5;
            state.Rules.RestrictUnitsLeviedPerTurn = true;
            state.Rules.MaxUnitsLeviedPerProvincePerTurn = 1;
            state.Rules.EnforceRoninStackingRules = true;

            return state;
        }
    }
}