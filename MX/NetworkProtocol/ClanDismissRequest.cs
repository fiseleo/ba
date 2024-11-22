namespace MX.NetworkProtocol
{
    public class ClanDismissRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Dismiss; }
        }

        public ClanDismissRequest() { }
    }
}
