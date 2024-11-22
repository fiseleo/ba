using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentTreasureFlipResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_TreasureFlip; }
        }

        public EventContentTreasureHistoryDB BoardHistoryDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EventContentTreasureFlipResponse() { }
    }
}
