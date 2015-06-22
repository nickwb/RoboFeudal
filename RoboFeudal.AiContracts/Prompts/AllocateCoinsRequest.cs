using System.Reflection;

namespace RoboFeudal.AiContracts.Prompts
{
    public class AllocateCoinsRequest
    {
        public int CoinsAvailable { get; set; } 
    }

    public class AllocateCoinsResponse
    {
        public int LevyUnitsSpend { get; set; }

        public int BuildFortificationsSpend { get; set; }

        public int HireRoninSpend { get; set; }

        public int TurnOrderBidSpend { get; set; }

        public int NinjaBidSpend { get; set; }
    }
}