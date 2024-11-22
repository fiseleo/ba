using System.Collections.Generic;
using FlatData;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.Data
{
    public class AttendanceBookReward
    {
        public long UniqueId { get; set; }

        public AttendanceType Type { get; set; }

        public AccountState AccountType { get; set; }

        public long DisplayOrder { get; set; }

        public long AccountLevelLimit { get; set; }

        public string Title { get; set; }

        public string TitleImagePath { get; set; }

        public AttendanceCountRule CountRule { get; set; }

        public AttendanceResetType CountReset { get; set; }

        public long BookSize { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime StartableEndDate { get; set; }

        public DateTime EndDate { get; set; }

        public long ExpiryDate { get; set; }

        public MailType MailType { get; set; }

        public Dictionary<long, string> DailyRewardIcons { get; set; }

        public Dictionary<long, List<ParcelInfo>> DailyRewards { get; set; }

        public AttendanceBookReward() { }

        public AttendanceBookReward(
            AttendanceExcel book,
            IEnumerable<AttendanceRewardExcel> rewards
        ) { }

        public bool IsValidBookSize()
        {
            return default(bool);
        }

        public bool IsOpen(
            DateTime serverTime,
            AccountDB accountDB,
            IEnumerable<AttendanceHistoryDB> histories
        )
        {
            return default(bool);
        }
    }
}
