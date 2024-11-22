namespace MX.NetworkProtocol
{
    public class EventContentPurchasePlayCountHardStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_PurchasePlayCountHardStage; }
        }

        public long EventContentId { get; set; }

        public long StageUniqueId { get; set; }

        public EventContentPurchasePlayCountHardStageRequest() { }
    }
}
