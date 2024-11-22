using FlatData;

namespace MX.GameLogic.DBModel
{
    public class AccountAchievementDB
    {
        public long AccountServerId { get; set; }

        public long AchievementUniqueId { get; set; }

        public long AchievementValue { get; set; }

        public AccountAchievementDB() { }

        public AccountAchievementDB(long accountId, AccountAchievementType type, long value) { }

        public AccountAchievementDB(long accountId, long uniqueId, long value) { }

        public AccountAchievementDB Clone()
        {
            return null;
        }
    }
}
