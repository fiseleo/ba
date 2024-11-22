using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    [Obsolete]
    public class ItemLockResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Item_Lock; }
        }

        public ItemDB ItemDB { get; set; }

        public ItemLockResponse() { }
    }
}
