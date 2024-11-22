using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class GuideMissionSeasonListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Mission_GuideMissionSeasonList; }
        }

        public List<GuideMissionSeasonDB> GuideMissionSeasonDBs { get; set; }

        public GuideMissionSeasonListResponse() { }
    }
}
