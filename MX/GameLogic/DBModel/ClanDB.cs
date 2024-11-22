using FlatData;

namespace MX.GameLogic.DBModel
{
    public class ClanDB
    {
        public long ClanDBId { get; set; }

        public string? ClanName { get; set; }
        public string? ClanChannelName { get; set; }

        public string? ClanPresidentNickName { get; set; }

        public long ClanPresidentRepresentCharacterUniqueId { get; set; }

        public long ClanPresidentRepresentCharacterCostumeId { get; set; }

        public string? ClanNotice { get; set; }
        public long ClanMemberCount { get; set; }

        public ClanJoinOption ClanJoinOption { get; set; }
    }
}
