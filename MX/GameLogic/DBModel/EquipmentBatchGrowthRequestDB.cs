using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class EquipmentBatchGrowthRequestDB
    {
        public long TargetServerId { get; set; }

        public List<ConsumeRequestDB> ConsumeRequestDBs { get; set; }

        public long AfterTier { get; set; }

        public long AfterLevel { get; set; }

        public long AfterExp { get; set; }

        public List<SelectTicketReplaceInfo> ReplaceInfos { get; set; }

        public EquipmentBatchGrowthRequestDB() { }
    }
}
