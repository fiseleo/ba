using FlatData;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CraftUpdateNodeLevelRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_UpdateNodeLevel; }
        }

        public ConsumeRequestDB ConsumeRequestDB { get; set; }

        public long ConsumeGoldAmount { get; set; }

        public long SlotId { get; set; }

        public CraftNodeTier CraftNodeType { get; set; }

        public CraftUpdateNodeLevelRequest() { }
    }
}
