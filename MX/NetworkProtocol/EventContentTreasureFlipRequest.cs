using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentTreasureFlipRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_TreasureFlip; }
        }

        public long EventContentId { get; set; }

        public int Round { get; set; }

        public List<EventContentTreasureCell> Cells { get; set; }

        public EventContentTreasureFlipRequest() { }
    }
}
