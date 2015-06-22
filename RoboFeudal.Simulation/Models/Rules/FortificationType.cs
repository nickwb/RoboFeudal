using System.Collections.Generic;

namespace RoboFeudal.Simulation.Models.Rules
{
    public class FortificationType
    {
        internal FortificationType(string name, int cost, FortificationType upgradeFrom, IEnumerable<FortificationReward> rewards)
        {
            Name = name;
            Cost = cost;
            UpgradedFrom = upgradeFrom;
            Rewards = rewards;
        }

        public string Name { get; internal set; }
        public int Cost { get; internal set; }
        public FortificationType UpgradedFrom { get; internal set; }
        public IEnumerable<FortificationReward> Rewards { get; internal set; }
    }
}