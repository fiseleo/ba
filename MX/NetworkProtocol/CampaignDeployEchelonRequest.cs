using System.Collections.Generic;
using MX.Campaign;

namespace MX.NetworkProtocol
{
    public class CampaignDeployEchelonRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_DeployEchelon; }
        }

        public long StageUniqueId { get; set; }

        public List<HexaUnit> DeployedEchelons { get; set; }

        public CampaignDeployEchelonRequest() { }
    }
}
