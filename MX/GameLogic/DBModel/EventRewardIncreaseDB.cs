using FlatData;
using MX.Core.Math;

namespace MX.GameLogic.DBModel
{
    public class EventRewardIncreaseDB
    {
        public EventTargetType EventTargetType { get; set; }

        public BasisPoint Multiplier { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsActive(DateTime serverTime)
        {
            return default(bool);
        }

        public bool OverLap(EventRewardIncreaseDB other)
        {
            return default(bool);
        }

        public EventRewardIncreaseDB() { }
    }
}
