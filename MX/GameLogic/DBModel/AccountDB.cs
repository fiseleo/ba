using System.ComponentModel.DataAnnotations;
using FlatData;

namespace MX.GameLogic.DBModel
{
    public class AccountDB
    {
        [Key]
        public long ServerId { get; set; }

        public string Nickname { get; set; } = string.Empty;

        public string? CallName { get; set; }

        public string? DevId { get; set; }

        public AccountState State { get; set; }

        public int Level { get; set; }

        public long Exp { get; set; }

        public string? Comment { get; set; }

        public int LobbyMode { get; set; }

        public long RepresentCharacterServerId { get; set; }

        public long MemoryLobbyUniqueId { get; set; }

        public DateTime LastConnectTime { get; set; }

        public DateTime BirthDay { get; set; }

        public DateTime CallNameUpdateTime { get; set; }

        public long PublisherAccountId { get; set; }

        public int? RetentionDays { get; set; }

        public int? VIPLevel { get; set; }

        public DateTime CreateDate { get; set; }

        public int? UnReadMailCount { get; set; }

        public DateTime? LinkRewardDate { get; set; }

        public AccountDB ExpTransactionClone()
        {
            return null;
        }

        public bool IsLevelOrExpHigherThan(AccountDB other)
        {
            return default(bool);
        }

        public AccountDB()
        {
            State = AccountState.Normal;
            Level = 1;
            LastConnectTime = DateTime.Now;
            CreateDate = DateTime.Now;
        }
    }
}
