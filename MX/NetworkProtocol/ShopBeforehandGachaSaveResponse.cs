using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ShopBeforehandGachaSaveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BeforehandGachaSave; }
        }

        public BeforehandGachaSnapshotDB SelectGachaSnapshot { get; set; }

        public ShopBeforehandGachaSaveResponse() { }
    }
}
