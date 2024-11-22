using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class ConquestInfoDB
    {
        public long AccountId { get; set; }

        public long EventContentId { get; set; }

        public int EventGauge { get; set; }

        public int EventSpawnCount { get; set; }

        public int EchelonChangeCount { get; set; }

        public int TodayConquestRentCount { get; set; }

        public int TodayOperationRentCount { get; set; }

        public long CumulatedConditionValue { get; set; }

        public long ReceivedCalculateRewardConditionAmount { get; set; }

        [JsonIgnore]
        public long CalculateRewardConditionValue
        {
            get { return 0L; }
        }

        public long? AlertMassErosionId { get; set; }

        public void CopyFrom(ConquestInfoDB other) { }

        public ConquestInfoDB Clone()
        {
            return null;
        }

        public ConquestInfoDB() { }
    }
}
