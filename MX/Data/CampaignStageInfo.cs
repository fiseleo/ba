using System.Collections.Generic;
using FlatData;
using MX.Campaign;
using MX.GameLogic.Parcel;

namespace MX.Data
{
    public class CampaignStageInfo
    {
        public long UniqueId { get; set; }

        public string DevName { get; set; }

        public long ChapterNumber { get; set; }

        public string StageNumber { get; set; }

        public long TutorialStageNumber { get; set; }

        public long[] PrerequisiteScenarioIds { get; set; }

        public int RecommandLevel { get; set; }

        public string StrategyMap { get; set; }

        public string BackgroundBG { get; set; }

        public long StoryUniqueId { get; set; }

        public long ChapterUniqueId { get; set; }

        public long DailyPlayCountLimit
        {
            get { return 0L; }
        }

        public StageTopography StageTopography { get; set; }

        public int StageEnterCostAmount { get; set; }

        public int MaxTurn { get; set; }

        public int MaxEchelonCount { get; set; }

        public StageDifficulty StageDifficulty { get; set; }

        public HashSet<long> PrerequisiteStageUniqueIds { get; set; }

        public long DailyPlayLimit { get; set; }

        public TimeSpan PlayTimeLimit { get; set; }

        public long PlayTurnLimit { get; set; }

        public ParcelCost EnterCost
        {
            get { return null; }
        }

        public ParcelCost PurchasePlayCountHardStageCost { get; set; }

        // public HexaTileMap HexaTileMap { get; set; }

        public long StarConditionTurnCount { get; set; }

        public long StarConditionSTacticRackCount { get; set; }

        public long RewardUniqueId { get; set; }

        public long TacticRewardPlayerExp { get; set; }

        public long TacticRewardExp { get; set; }

        public virtual bool ShowClearDeckButton
        {
            get { return default(bool); }
        }

        public List<ValueTuple<ParcelInfo, RewardTag>> StageReward { get; set; }

        public List<ValueTuple<ParcelInfo, RewardTag>> DisplayReward { get; set; }

        public StrategyEnvironment StrategyEnvironment { get; set; }

        public ContentType ContentType { get; set; }

        public long GroundId { get; set; }

        public int StrategySkipGroundId { get; }

        public long BattleDuration { get; set; }

        public long BGMId { get; set; }

        public long FixedEchelonId { get; set; }

        public bool IsEventContent
        {
            get { return default(bool); }
        }

        public ParcelInfo EnterParcelInfo { get; set; }

        public bool IsDeprecated { get; set; }

        public EchelonExtensionType EchelonExtensionType { get; set; }

        public CampaignStageInfo() { }

        public CampaignStageInfo(
            CampaignChapterInfo chapter,
            CampaignChapterInfo previousChapter,
            CampaignStageExcel stageExcel,
            IEnumerable<CampaignStageRewardExcel> stageRewards,
            string rawDataRoot
        ) { }

        public CampaignStageInfo(CampaignStageExcel stageExcel) { }

        public virtual string GetStageName()
        {
            return null;
        }

        public virtual string GetStageNumber()
        {
            return null;
        }

        public string GetInProgressChapter()
        {
            return null;
        }

        // Note: this type is marked as 'beforefieldinit'.
        static CampaignStageInfo() { }

        public static readonly CampaignStageInfo Invalid;

        public long[] EnterScenarioID;

        public long[] ClearScenarioID;
    }
}
