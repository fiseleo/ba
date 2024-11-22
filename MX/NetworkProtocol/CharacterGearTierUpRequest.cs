using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CharacterGearTierUpRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.CharacterGear_TierUp; }
        }

        public long GearServerId { get; set; }

        public List<SelectTicketReplaceInfo> ReplaceInfos { get; set; }

        public CharacterGearTierUpRequest() { }
    }
}
