using FlatData;

namespace MX.NetworkProtocol
{
    public class ClanSettingRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Setting; }
        }

        public string ChangedClanName { get; set; }

        public string ChangedNotice { get; set; }

        public ClanJoinOption ClanJoinOption { get; set; }

        public ClanSettingRequest() { }
    }
}
