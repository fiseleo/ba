using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ClanPermitResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Permit; }
        }

        public ClanDB ClanDB { get; set; }

        public ClanMemberDB ClanMemberDB { get; set; }

        public ClanPermitResponse() { }
    }
}
