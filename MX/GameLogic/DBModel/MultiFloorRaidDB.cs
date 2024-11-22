using System.Collections.Generic;
// using MX.Data.Excel;
using MX.GameLogic.Parcel;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class MultiFloorRaidDB
    {
        public long SeasonId { get; set; }

        public int ClearedDifficulty { get; set; }

        public DateTime LastClearDate { get; set; }

        public int RewardDifficulty { get; set; }

        public DateTime LastRewardDate { get; set; }

        public int ClearBattleFrame { get; set; }

        [JsonIgnore]
        public bool AllCleared
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public bool HasReceivableRewards
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public List<ParcelInfo> TotalReceivableRewards
        {
            get { return null; }
        }

        [JsonIgnore]
        public List<ParcelInfo> TotalReceivedRewards
        {
            get { return null; }
        }

        public MultiFloorRaidDB Clone()
        {
            return null;
        }

        public MultiFloorRaidDB() { }

        public MultiFloorRaidDB(long seasonId) { }

        public List<ParcelInfo> GetRewardsDifficultyRangeInclusive(
            int startDifficulty,
            int endDifficulty,
            bool shouldSummarize = true
        )
        {
            return null;
        }

        public bool IsDifficultyCleared(int difficulty)
        {
            return default(bool);
        }

        public bool CanReceiveRewardDifficulty(int difficulty)
        {
            return default(bool);
        }

        // public bool CanPlayDifficulty(MultiFloorRaidSeasonManageExcel seasonExcel, int difficulty)
        // {
        //     return default(bool);
        // }

        public bool CanPlayDifficulty(int difficulty)
        {
            return default(bool);
        }
    }
}
