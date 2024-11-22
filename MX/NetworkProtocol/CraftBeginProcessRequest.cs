namespace MX.NetworkProtocol
{
    public class CraftBeginProcessRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_BeginProcess; }
        }

        public long SlotId { get; set; }

        public CraftBeginProcessRequest() { }
    }
}
