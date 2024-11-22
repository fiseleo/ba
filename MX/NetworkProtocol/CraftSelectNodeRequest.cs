namespace MX.NetworkProtocol
{
    public class CraftSelectNodeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_SelectNode; }
        }

        public long SlotId { get; set; }

        public long LeafNodeIndex { get; set; }

        public CraftSelectNodeRequest() { }
    }
}
