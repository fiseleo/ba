using MX.GameLogic.Parcel;

namespace MX.GameLogic.DBModel
{
    public class EventContentBonusRewardDB
    {
        public long EventContentId { get; set; }

        public long EventStageUniqueId { get; set; }

        public ParcelInfo BonusParcelInfo { get; set; }

        public EventContentBonusRewardDB() { }
    }
}
