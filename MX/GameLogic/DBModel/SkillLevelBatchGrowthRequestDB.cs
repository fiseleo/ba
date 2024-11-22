using System.Collections.Generic;
using MX.Logic.BattleEntities;

namespace MX.GameLogic.DBModel
{
    public class SkillLevelBatchGrowthRequestDB
    {
        public SkillSlot SkillSlot { get; set; }

        public int Level { get; set; }

        public List<SelectTicketReplaceInfo> ReplaceInfos { get; set; }

        public SkillLevelBatchGrowthRequestDB() { }
    }
}
