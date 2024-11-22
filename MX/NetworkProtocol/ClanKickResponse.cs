namespace MX.NetworkProtocol
{
    public class ClanKickResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Kick; }
        }

        public ClanKickResponse() { }
    }
}
