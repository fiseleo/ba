using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.Logic.BattleEntities;

namespace MX.NetworkProtocol
{
    public class CharacterSkillLevelUpdateRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_UpdateSkillLevel; }
        }

        public long TargetCharacterDBId { get; set; }

        public SkillSlot SkillSlot { get; set; }

        public int Level { get; set; }

        public List<SelectTicketReplaceInfo> ReplaceInfos { get; set; }

        public CharacterSkillLevelUpdateRequest() { }
    }
}
