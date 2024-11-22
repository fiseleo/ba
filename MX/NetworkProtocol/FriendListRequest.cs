namespace MX.NetworkProtocol
{
    public class FriendListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_List; }
        }

        public FriendListRequest() { }
    }
}
