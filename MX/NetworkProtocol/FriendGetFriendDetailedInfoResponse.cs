using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class FriendGetFriendDetailedInfoResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_GetFriendDetailedInfo; }
        }

        public string Nickname { get; set; }

        public long Level { get; set; }

        public string ClanName { get; set; }

        public string Comment { get; set; }

        public long FriendCount { get; set; }

        public string FriendCode { get; set; }

        public long RepresentCharacterUniqueId { get; set; }

        public long RepresentCharacterCostumeId { get; set; }

        public long CharacterCount { get; set; }

        public long? LastNormalCampaignClearStageId { get; set; }

        public long? LastHardCampaignClearStageId { get; set; }

        public long? ArenaRanking { get; set; }

        public long? RaidRanking { get; set; }

        public int? RaidTier { get; set; }

        public DetailedAccountInfoDB DetailedAccountInfoDB { get; set; }

        public AccountAttachmentDB AttachmentDB { get; set; }

        public AssistCharacterDB[] AssistCharacterDBs { get; set; }

        public FriendGetFriendDetailedInfoResponse() { }
    }
}
