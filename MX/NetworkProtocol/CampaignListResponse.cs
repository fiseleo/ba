using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CampaignListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_List; }
        }

        public List<CampaignChapterClearRewardHistoryDB> CampaignChapterClearRewardHistoryDBs { get; set; }

        public List<CampaignStageHistoryDB> StageHistoryDBs { get; set; }

        public List<StrategyObjectHistoryDB> StrategyObjecthistoryDBs { get; set; }

        public DailyResetCountDB DailyResetCountDB { get; set; }

        public CampaignListResponse() { }
    }
}
