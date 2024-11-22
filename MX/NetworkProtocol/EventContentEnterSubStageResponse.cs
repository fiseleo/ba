using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentEnterSubStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_EnterSubStage; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EventContentSubStageSaveDB SaveDataDB { get; set; }

        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }

        public EventContentEnterSubStageResponse() { }
    }
}
