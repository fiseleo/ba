using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CampaignDeployEchelonResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_DeployEchelon; }
        }

        public CampaignMainStageSaveDB SaveDataDB { get; set; }

        public CampaignDeployEchelonResponse() { }
    }
}
