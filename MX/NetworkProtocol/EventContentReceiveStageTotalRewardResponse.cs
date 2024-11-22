using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentReceiveStageTotalRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_ReceiveStageTotalReward; }
        }

        public long EventContentId { get; set; }

        public List<long> AlreadyReceiveRewardId { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EventContentReceiveStageTotalRewardResponse() { }
    }
}
