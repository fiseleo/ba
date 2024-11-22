namespace MX.NetworkProtocol
{
    public class ClanDismissResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Dismiss; }
        }

        public ClanDismissResponse() { }
    }
}
