namespace MX.NetworkProtocol
{
    public class FriendSetIdCardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_SetIdCard; }
        }

        public FriendSetIdCardResponse() { }
    }
}
