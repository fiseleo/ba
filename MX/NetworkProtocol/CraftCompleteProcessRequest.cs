namespace MX.NetworkProtocol
{
    public class CraftCompleteProcessRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_CompleteProcess; }
        }

        public long SlotId { get; set; }

        public CraftCompleteProcessRequest() { }
    }
}
