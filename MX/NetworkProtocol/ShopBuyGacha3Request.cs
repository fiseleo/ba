using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ShopBuyGacha3Request : ShopBuyGacha2Request
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BuyGacha3; }
        }

        public long FreeRecruitId { get; set; }

        public ParcelCost Cost { get; set; }

        public ShopBuyGacha3Request() { }
    }
}
