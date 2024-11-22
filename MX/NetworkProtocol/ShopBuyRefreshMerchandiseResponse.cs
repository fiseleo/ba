using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ShopBuyRefreshMerchandiseResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BuyRefreshMerchandise; }
        }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public ConsumeResultDB ConsumeResultDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public List<ShopProductDB> ShopProductDB { get; set; }

        public MailDB MailDB { get; set; }

        public ShopBuyRefreshMerchandiseResponse() { }
    }
}
