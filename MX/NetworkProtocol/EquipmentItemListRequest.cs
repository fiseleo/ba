namespace MX.NetworkProtocol
{
    public class EquipmentItemListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Equipment_List; }
        }

        public EquipmentItemListRequest() { }
    }
}
