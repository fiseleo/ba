using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentStoryStageResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_StoryStageResult; }
        }

        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public List<ParcelInfo> FirstClearReward { get; set; } = [];

        public List<EventContentCollectionDB>? EventContentCollectionDBs { get; set; }

        public EventContentStoryStageResultResponse() { }
    }
}
