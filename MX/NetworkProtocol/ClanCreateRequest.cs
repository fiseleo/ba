using FlatData;

namespace MX.NetworkProtocol
{
    public class ClanCreateRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Create; }
        }

        public string ClanNickName { get; set; }

        public ClanJoinOption ClanJoinOption { get; set; }

        public ClanCreateRequest() { }
    }
}
