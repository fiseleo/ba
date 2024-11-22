namespace MX.GameLogic.DBModel
{
    public class RaidPlayerInfoDB
    {
        public long RaidServerId { get; set; }

        public long AccountId { get; set; }

        public DateTime JoinDate { get; set; }

        public long DamageAmount { get; set; }

        public int RaidEndRewardFlag { get; set; }

        public int RaidPlayCount { get; set; }

        public string Nickname { get; set; }

        public long CharacterId { get; set; }

        public long CostumeId { get; set; }

        public long? AccountLevel { get; set; }

        public RaidPlayerInfoDB() { }
    }
}
