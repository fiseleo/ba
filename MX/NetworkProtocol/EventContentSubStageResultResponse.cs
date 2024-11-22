using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentSubStageResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_SubStageResult; }
        }

        public long TacticRank { get; set; }

        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }

        public List<CharacterDB> LevelUpCharacterDBs { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public List<ParcelInfo> FirstClearReward { get; set; }

        public List<ParcelInfo> BonusReward { get; set; }

        public List<EventContentCollectionDB> EventContentCollectionDBs { get; set; }

        public EventContentSubStageResultResponse() { }
    }
}
