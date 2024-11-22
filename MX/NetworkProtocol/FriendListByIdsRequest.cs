namespace MX.NetworkProtocol
{
    public class FriendListByIdsRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_ListByIds; }
        }

        public long[] TargetAccountIds { get; set; }

        public FriendListByIdsRequest() { }
    }
}
