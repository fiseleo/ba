using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class OpenConditionEventListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.OpenCondition_EventList; }
        }

        public List<long> ConquestEventIds { get; set; }

        public Dictionary<long, long> WorldRaidSeasonAndGroupIds { get; set; }

        public OpenConditionEventListRequest() { }
    }
}
