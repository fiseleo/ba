using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class MomoTalkFavorScheduleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MomoTalk_FavorSchedule; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public Dictionary<long, List<long>> FavorScheduleRecords { get; set; }

        public MomoTalkFavorScheduleResponse() { }
    }
}
