using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentCardShopPurchaseResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_CardShopPurchase; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CardShopElementDB CardShopElementDB { get; set; }

        public List<CardShopPurchaseHistoryDB> CardShopPurchaseHistoryDBs { get; set; }

        public EventContentCardShopPurchaseResponse() { }
    }
}
