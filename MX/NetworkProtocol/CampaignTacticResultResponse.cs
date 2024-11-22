using System.Collections.Generic;
using MX.Campaign;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CampaignTacticResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_TacticResult; }
        }

        public long TacticRank { get; set; }

        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }

        public List<CharacterDB> LevelUpCharacterDBs { get; set; }

        public List<ParcelInfo> FirstClearReward { get; set; }

        public List<ParcelInfo> ThreeStarReward { get; set; }

        public Strategy StrategyObject { get; set; }

        public Dictionary<long, List<ParcelInfo>> StrategyObjectRewards { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CampaignMainStageSaveDB SaveDataDB { get; set; }

        public CampaignTacticResultResponse() { }
    }
}
