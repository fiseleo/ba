using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CharacterPotentialGrowthRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_PotentialGrowth; }
        }

        public long TargetCharacterDBId { get; set; }

        public List<PotentialGrowthRequestDB> PotentialGrowthRequestDBs { get; set; }

        public List<SelectTicketReplaceInfo> ReplaceInfos { get; set; }

        public CharacterPotentialGrowthRequest() { }
    }
}
