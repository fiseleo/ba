namespace MX.NetworkProtocol
{
    public class CafeUpdatePresetFurnitureRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_UpdatePresetFurniture; }
        }

        public long CafeDBId { get; set; }

        public int SlotId { get; set; }

        public CafeUpdatePresetFurnitureRequest() { }
    }
}
