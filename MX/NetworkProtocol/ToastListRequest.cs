namespace MX.NetworkProtocol
{
    public class ToastListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Toast_List; }
        }

        public ToastListRequest() { }
    }
}
