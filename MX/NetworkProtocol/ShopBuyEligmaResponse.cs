using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ShopBuyEligmaResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BuyEligma; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public ConsumeResultDB ConsumeResultDB { get; set; }

        public ShopProductDB ShopProductDB { get; set; }

        public ShopBuyEligmaResponse() { }
    }
}
