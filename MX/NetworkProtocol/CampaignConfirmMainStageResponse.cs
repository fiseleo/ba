using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CampaignConfirmMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_ConfirmMainStage; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CampaignMainStageSaveDB SaveDataDB { get; set; }

        public CampaignConfirmMainStageResponse() { }
    }
}
