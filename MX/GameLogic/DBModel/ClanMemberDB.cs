using FlatData;

namespace MX.GameLogic.DBModel
{
    public class ClanMemberDB
    {
        public long AccountId { get; set; }
        public long AccountLevel { get; set; }
        public string? AccountNickName { get; set; }
        public long ClanDBId { get; set; }
        public long RepresentCharacterUniqueId { get; set; }
        public long RepresentCharacterCostumeId { get; set; }
        public long AttendanceCount { get; set; }
        public ClanSocialGrade ClanSocialGrade { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime SocialGradeUpdateTime { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime GameLoginDate { get; set; }
        public DateTime AppliedDate { get; set; }
        public AccountAttachmentDB AttachmentDB { get; set; }
    }
}
