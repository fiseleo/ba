using System.Collections.Generic;
using FlatData;

namespace MX.Data
{
    public class CampaignChapterInfo
    {
        public long UniqueId { get; set; }

        public string DevName { get; set; }

        public string NormalImagePath { get; set; }

        public string HardImagePath { get; set; }

        public long Order { get; set; }

        public HashSet<long> PrerequisiteStageUniqueIds { get; set; }

        public List<long> NormalStageUniqueIds { get; set; }

        public List<long> NormalExtraStageUniqueIds { get; set; }

        public List<long> HardStageUniqueIds { get; set; }

        public List<long> VeryHardStageUniqueIds { get; set; }

        public List<long> StageUniqueIdsAll { get; set; }

        public CampaignChapterRewardInfo NormalChapterRewardInfo { get; set; }

        public CampaignChapterRewardInfo HardChapterRewardInfo { get; set; }

        public CampaignChapterRewardInfo VeryHardChapterRewardInfo { get; set; }

        public bool IsTacticSkip { get; set; }

        public CampaignChapterInfo(
            CampaignChapterExcel? previousChapterExcel,
            CampaignChapterExcel excel,
            CampaignChapterRewardExcel? normalChapterReward,
            CampaignChapterRewardExcel? hardChapterReward,
            CampaignChapterRewardExcel? veryHardChapterReward
        ) { }

        public bool ContainsNormalStage(long stageUniqueId)
        {
            return default(bool);
        }

        public bool ContainsNormalExtraStage(long stageUniqueId)
        {
            return default(bool);
        }

        public bool ContainsHardStage(long stageUniqueId)
        {
            return default(bool);
        }

        public bool ContainsVeryHardStage(long stageUniqueId)
        {
            return default(bool);
        }

        public bool ContainsStage(long stageUniqueId)
        {
            return default(bool);
        }

        public long GetPreviousStageUniqueId(long stageUniqueId)
        {
            return 0L;
        }

        public long GetNextStageUniqueId(long stageUniqueId)
        {
            return 0L;
        }

        public long GetLastStageId(StageDifficulty stageDifficulty)
        {
            return 0L;
        }

        public List<long> GetNonExtraStageIds(StageDifficulty stageDifficulty)
        {
            return null;
        }

        public CampaignChapterRewardInfo GetChapterRewardInfo(StageDifficulty stageDifficulty)
        {
            return null;
        }
    }
}
