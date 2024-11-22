using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ShopBuyAPResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BuyAP; }
        }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public ConsumeResultDB ConsumeResultDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public MailDB MailDB { get; set; }

        public ShopProductDB ShopProductDB { get; set; }

        public ShopBuyAPResponse() { }
    }
}
