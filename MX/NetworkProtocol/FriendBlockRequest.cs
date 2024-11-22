namespace MX.NetworkProtocol
{
    public class FriendBlockRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_Block; }
        }

        public long TargetAccountId { get; set; }

        public FriendBlockRequest() { }
    }
}
