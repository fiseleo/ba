using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CampaignConfirmTutorialStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_ConfirmTutorialStage; }
        }

        public CampaignMainStageSaveDB SaveDataDB { get; set; }

        public CampaignConfirmTutorialStageResponse() { }
    }
}
