using FlatData;

namespace MX.NetworkProtocol
{
    public class ClanSearchRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Search; }
        }

        public string SearchString { get; set; }

        public ClanJoinOption ClanJoinOption { get; set; }

        public string ClanUniqueCode { get; set; }

        public ClanSearchRequest() { }
    }
}
