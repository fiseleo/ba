namespace MX.NetworkProtocol
{
    public class CafeRemoveAllFurnitureRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_RemoveAll; }
        }

        public long CafeDBId { get; set; }

        public CafeRemoveAllFurnitureRequest() { }
    }
}
