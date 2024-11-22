namespace MX.GameLogic.DBModel
{
    public class ArenaUserDB
    {
        public long AccountServerId { get; set; }

        public long RepresentCharacterUniqueId { get; set; }

        public long RepresentCharacterCostumeId { get; set; }

        public string NickName { get; set; }

        public long Rank { get; set; }

        public long Level { get; set; }

        public long Exp { get; set; }

        public ArenaTeamSettingDB TeamSettingDB { get; set; }

        public AccountAttachmentDB AccountAttachmentDB { get; set; }

        public ArenaUserDB() { }

        public string UserName
        {
            get { return null; }
        }
    }
}
