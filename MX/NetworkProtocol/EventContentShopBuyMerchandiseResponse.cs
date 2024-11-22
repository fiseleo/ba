using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentShopBuyMerchandiseResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_ShopBuyMerchandise; }
        }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public ConsumeResultDB ConsumeResultDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public MailDB MailDB { get; set; }

        public ShopProductDB ShopProductDB { get; set; }

        public List<EventContentCollectionDB> EventContentCollectionDBs { get; set; }

        public EventContentShopBuyMerchandiseResponse() { }
    }
}
