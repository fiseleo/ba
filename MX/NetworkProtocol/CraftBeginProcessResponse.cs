using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CraftBeginProcessResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_BeginProcess; }
        }

        public CraftInfoDB CraftInfoDB { get; set; }

        public CraftBeginProcessResponse() { }
    }
}
