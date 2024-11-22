using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class MissionMultipleRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Mission_MultipleReward; }
        }

        public List<MissionHistoryDB> AddedHistoryDBs { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public MissionMultipleRewardResponse() { }
    }
}
