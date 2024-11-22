namespace MX.NetworkProtocol
{
    public class FriendGetFriendDetailedInfoRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_GetFriendDetailedInfo; }
        }

        public long FriendAccountId { get; set; }

        public FriendGetFriendDetailedInfoRequest() { }
    }
}
