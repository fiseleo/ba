namespace MX.NetworkProtocol
{
    public class FriendRemoveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_Remove; }
        }

        public FriendRemoveRequest() { }

        public long TargetAccountId;
    }
}
