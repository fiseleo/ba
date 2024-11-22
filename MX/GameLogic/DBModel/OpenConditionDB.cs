using FlatData;

namespace MX.GameLogic.DBModel
{
    public class OpenConditionDB
    {
        public OpenConditionContent ContentType { get; set; }

        public bool HideWhenLocked { get; set; }

        public long AccountLevel { get; set; }

        public long ScenarioModeId { get; set; }

        public long CampaignStageUniqueId { get; set; }

        public MultipleConditionCheckType MultipleConditionCheckType { get; set; }

        public WeekDay OpenDayOfWeek { get; set; }

        public long OpenHour { get; set; }

        public WeekDay CloseDayOfWeek { get; set; }

        public long CloseHour { get; set; }

        public long CafeIdForCafeRank { get; set; }

        public long CafeRank { get; set; }

        public long OpenedCafeId { get; set; }

        public OpenConditionDB() { }

        public OpenConditionDB(OpenConditionExcel excel) { }
    }
}
