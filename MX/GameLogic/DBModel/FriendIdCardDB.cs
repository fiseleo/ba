namespace MX.GameLogic.DBModel
{
    public class FriendIdCardDB
    {
        public FriendIdCardDB() { }

        public FriendIdCardDB(FriendIdCardDB db) { }

        public int Level { get; set; }

        public string FriendCode { get; set; }

        public string Comment { get; set; }

        public DateTime LastConnectTime { get; set; }

        public long RepresentCharacterUniqueId { get; set; }

        public long RepresentCharacterCostumeId { get; set; }

        public bool SearchPermission { get; set; }

        public bool AutoAcceptFriendRequest { get; set; }

        public long CardBackgroundId { get; set; }

        public bool ShowAccountLevel { get; set; }

        public bool ShowFriendCode { get; set; }

        public bool ShowRaidRanking { get; set; }

        public bool ShowArenaRanking { get; set; }

        public bool ShowEliminateRaidRanking { get; set; }

        public long? ArenaRanking { get; set; }

        public long? RaidRanking { get; set; }

        public int? RaidTier { get; set; }

        public long? EliminateRaidRanking { get; set; }

        public int? EliminateRaidTier { get; set; }

        public long EmblemId { get; set; }
    }
}
