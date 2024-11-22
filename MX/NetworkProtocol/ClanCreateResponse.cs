using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ClanCreateResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Create; }
        }

        public ClanDB ClanDB { get; set; }

        public ClanMemberDB ClanMemberDB { get; set; }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public ClanCreateResponse() { }
    }
}
