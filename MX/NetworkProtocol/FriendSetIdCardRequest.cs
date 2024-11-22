namespace MX.NetworkProtocol
{
    public class FriendSetIdCardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_SetIdCard; }
        }

        public string Comment { get; set; }

        public long RepresentCharacterUniqueId { get; set; }

        public long EmblemId { get; set; }

        public bool SearchPermission { get; set; }

        public bool AutoAcceptFriendRequest { get; set; }

        public bool ShowAccountLevel { get; set; }

        public bool ShowFriendCode { get; set; }

        public bool ShowRaidRanking { get; set; }

        public bool ShowArenaRanking { get; set; }

        public bool ShowEliminateRaidRanking { get; set; }

        public long BackgroundId { get; set; }

        public FriendSetIdCardRequest() { }
    }
}
