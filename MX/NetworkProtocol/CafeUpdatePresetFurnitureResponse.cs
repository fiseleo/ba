namespace MX.NetworkProtocol
{
    public class CafeUpdatePresetFurnitureResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_UpdatePresetFurniture; }
        }

        public CafeUpdatePresetFurnitureResponse() { }
    }
}
