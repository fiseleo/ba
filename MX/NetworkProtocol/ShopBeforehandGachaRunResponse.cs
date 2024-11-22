using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ShopBeforehandGachaRunResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BeforehandGachaRun; }
        }

        public BeforehandGachaSnapshotDB SelectGachaSnapshot { get; set; }

        public ShopBeforehandGachaRunResponse() { }
    }
}
