using System.Collections.Generic;
using MX.Campaign;

namespace MX.NetworkProtocol
{
    public class EventContentDeployEchelonRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_DeployEchelon; }
        }

        public long EventContentId { get; set; }

        public long StageUniqueId { get; set; }

        public List<HexaUnit> DeployedEchelons { get; set; }

        public EventContentDeployEchelonRequest() { }
    }
}
