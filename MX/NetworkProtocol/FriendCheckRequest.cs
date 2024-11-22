namespace MX.NetworkProtocol
{
    public class FriendCheckRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_Check; }
        }

        public FriendCheckRequest() { }
    }
}
