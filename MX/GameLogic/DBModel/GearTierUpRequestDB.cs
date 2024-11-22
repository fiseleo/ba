using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class GearTierUpRequestDB
    {
        public long TargetServerId { get; set; }

        public long AfterTier { get; set; }

        public List<SelectTicketReplaceInfo> ReplaceInfos { get; set; }

        public GearTierUpRequestDB() { }
    }
}
