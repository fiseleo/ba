using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentAdventureListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_AdventureList; }
        }

        public List<CampaignStageHistoryDB> StageHistoryDBs { get; set; } = [];

        public List<StrategyObjectHistoryDB> StrategyObjecthistoryDBs { get; set; } = [];

        public List<EventContentBonusRewardDB> EventContentBonusRewardDBs { get; set; } = [];

        public List<long> AlreadyReceiveRewardId { get; set; } = [];

        public long StagePoint { get; set; }

        public EventContentAdventureListResponse() { }
    }
}
