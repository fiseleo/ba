namespace MX.NetworkProtocol
{
    public class EliminateRaidLoginRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_Login; }
        }

        public EliminateRaidLoginRequest() { }
    }
}
