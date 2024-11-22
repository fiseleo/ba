using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CampaignEnterMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_EnterMainStage; }
        }

        public CampaignMainStageSaveDB SaveDataDB { get; set; }

        public CampaignEnterMainStageResponse() { }
    }
}
