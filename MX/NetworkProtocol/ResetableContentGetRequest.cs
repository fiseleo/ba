namespace MX.NetworkProtocol
{
    public class ResetableContentGetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ResetableContent_Get; }
        }

        public ResetableContentGetRequest() { }
    }
}
