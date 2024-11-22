using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ShopBuyGacha3Response : ShopBuyGacha2Response
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BuyGacha3; }
        }

        public ShopFreeRecruitHistoryDB FreeRecruitHistoryDB { get; set; }

        public ShopBuyGacha3Response() { }
    }
}
