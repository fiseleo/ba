using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentCardShopListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_CardShopList; }
        }

        public List<CardShopElementDB> CardShopElementDBs { get; set; }

        public Dictionary<long, List<ParcelInfo>> RewardHistory { get; set; }

        public EventContentCardShopListResponse() { }
    }
}
