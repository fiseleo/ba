using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ShopBeforehandGachaGetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BeforehandGachaGet; }
        }

        public bool AlreadyPicked { get; set; }

        public BeforehandGachaSnapshotDB BeforehandGachaSnapshot { get; set; }

        public ShopBeforehandGachaGetResponse() { }
    }
}
