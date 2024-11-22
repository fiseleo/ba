using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CharacterBatchSkillLevelUpdateRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_BatchSkillLevelUpdate; }
        }

        public long TargetCharacterDBId { get; set; }

        public List<SkillLevelBatchGrowthRequestDB> SkillLevelUpdateRequestDBs { get; set; }

        public CharacterBatchSkillLevelUpdateRequest() { }
    }
}
