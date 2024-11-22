using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CampaignSubStageResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_SubStageResult; }
        }

        public long TacticRank { get; set; }

        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }

        public List<CharacterDB> LevelUpCharacterDBs { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public List<ParcelInfo> FirstClearReward { get; set; }

        public List<ParcelInfo> ThreeStarReward { get; set; }

        public CampaignSubStageResultResponse() { }
    }
}
