namespace MX.NetworkProtocol
{
    public class SystemVersionRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.System_Version; }
        }

        public SystemVersionRequest() { }
    }
}
