using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CampaignEnterSubStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_EnterSubStage; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CampaignSubStageSaveDB SaveDataDB { get; set; }

        public CampaignEnterSubStageResponse() { }
    }
}
