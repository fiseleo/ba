using System.Collections.Generic;
using MX.Campaign;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentTacticResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_TacticResult; }
        }

        public long TacticRank { get; set; }

        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }

        public List<CharacterDB> LevelUpCharacterDBs { get; set; }

        public List<ParcelInfo> FirstClearReward { get; set; }

        public Strategy StrategyObject { get; set; }

        public Dictionary<long, List<ParcelInfo>> StrategyObjectRewards { get; set; }

        public List<ParcelInfo> BonusReward { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EventContentMainStageSaveDB SaveDataDB { get; set; }

        public List<EventContentCollectionDB> EventContentCollectionDBs { get; set; }

        public EventContentTacticResultResponse() { }
    }
}
