using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CampaignRestartMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_RestartMainStage; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CampaignMainStageSaveDB SaveDataDB { get; set; }

        public CampaignRestartMainStageResponse() { }
    }
}
