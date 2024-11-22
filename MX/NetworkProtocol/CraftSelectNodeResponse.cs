using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CraftSelectNodeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_SelectNode; }
        }

        public CraftNodeDB SelectedNodeDB { get; set; }

        public CraftSelectNodeResponse() { }
    }
}
