using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CampaignEnterTutorialStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_EnterTutorialStage; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CampaignTutorialStageSaveDB SaveDataDB { get; set; }

        public CampaignEnterTutorialStageResponse() { }
    }
}
