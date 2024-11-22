using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ClanSettingResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Setting; }
        }

        public ClanDB ClanDB { get; set; }

        public ClanSettingResponse() { }
    }
}
