namespace MX.NetworkProtocol
{
    public class FriendAcceptFriendRequestRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_AcceptFriendRequest; }
        }

        public long TargetAccountId { get; set; }

        public FriendAcceptFriendRequestRequest() { }
    }
}
