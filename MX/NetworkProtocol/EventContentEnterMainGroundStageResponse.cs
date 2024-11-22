using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentEnterMainGroundStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_EnterMainGroundStage; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EventContentMainGroundStageSaveDB SaveDataDB { get; set; }

        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }

        public EventContentEnterMainGroundStageResponse() { }
    }
}
