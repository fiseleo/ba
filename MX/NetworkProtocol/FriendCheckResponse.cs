namespace MX.NetworkProtocol
{
    public class FriendCheckResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_Check; }
        }

        public FriendCheckResponse() { }
    }
}
