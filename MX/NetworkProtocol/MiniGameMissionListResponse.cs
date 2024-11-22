using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class MiniGameMissionListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MiniGame_MissionList; }
        }

        public List<long> MissionHistoryUniqueIds { get; set; }

        public List<MissionProgressDB> ProgressDBs { get; set; }

        public MiniGameMissionListResponse() { }
    }
}
