using System.Collections.Generic;
using MX.Data;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class MissionListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Mission_List; }
        }

        public List<long> MissionHistoryUniqueIds { get; set; }

        public List<MissionProgressDB> ProgressDBs { get; set; }

        public MissionInfo DailySuddenMissionInfo { get; set; }

        public List<long> ClearedOrignalMissionIds { get; set; }

        public MissionListResponse() { }
    }
}
