namespace MX.GameLogic.DBModel
{
    public class FriendDB
    {
        public FriendDB() { }

        public long AccountId;

        public int Level;

        public string Nickname;

        public DateTime LastConnectTime;

        public long RepresentCharacterUniqueId;

        public long RepresentCharacterCostumeId;

        public long FriendCount;

        public AccountAttachmentDB AttachmentDB;
    }
}
