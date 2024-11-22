using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CraftAutoBeginProcessRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_AutoBeginProcess; }
        }

        public CraftPresetSlotDB PresetSlotDB { get; set; }

        public long Count { get; set; }

        public CraftAutoBeginProcessRequest() { }
    }
}
