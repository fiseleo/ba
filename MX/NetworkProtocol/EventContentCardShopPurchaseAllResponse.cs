using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentCardShopPurchaseAllResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_CardShopPurchaseAll; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public List<CardShopElementDB> CardShopElementDBs { get; set; }

        public List<CardShopPurchaseHistoryDB> CardShopPurchaseHistoryDBs { get; set; }

        public Dictionary<long, List<ParcelInfo>> RewardHistory { get; set; }

        public EventContentCardShopPurchaseAllResponse() { }
    }
}
