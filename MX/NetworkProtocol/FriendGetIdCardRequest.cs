namespace MX.NetworkProtocol
{
    public class FriendGetIdCardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_GetIdCard; }
        }

        public FriendGetIdCardRequest() { }
    }
}
