namespace MX.NetworkProtocol
{
    public class FriendSendFriendRequestRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_SendFriendRequest; }
        }

        public long TargetAccountId { get; set; }

        public FriendSendFriendRequestRequest() { }
    }
}
