namespace MX.NetworkProtocol
{
    public class FriendUnblockRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_Unblock; }
        }

        public long TargetAccountId { get; set; }

        public FriendUnblockRequest() { }
    }
}
