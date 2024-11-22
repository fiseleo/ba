namespace MX.NetworkProtocol
{
    public class ArenaLoginRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_Login; }
        }

        public ArenaLoginRequest() { }
    }
}
