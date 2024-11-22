namespace MX.NetworkProtocol
{
    public class FriendCancelFriendRequestRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_CancelFriendRequest; }
        }

        public FriendCancelFriendRequestRequest() { }

        public long TargetAccountId;
    }
}
