namespace MX.NetworkProtocol
{
    public class EchelonListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Echelon_List; }
        }

        public EchelonListRequest() { }
    }
}
