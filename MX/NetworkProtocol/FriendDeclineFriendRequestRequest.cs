namespace MX.NetworkProtocol
{
    public class FriendDeclineFriendRequestRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_DeclineFriendRequest; }
        }

        public long TargetAccountId { get; set; }

        public FriendDeclineFriendRequestRequest() { }
    }
}
