namespace MX.NetworkProtocol
{
    public class RaidLoginRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_Login; }
        }

        public RaidLoginRequest() { }
    }
}
