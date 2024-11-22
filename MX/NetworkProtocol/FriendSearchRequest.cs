using FlatData;

namespace MX.NetworkProtocol
{
    public class FriendSearchRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_Search; }
        }

        public string FriendCode { get; set; }

        public FriendSearchLevelOption LevelOption { get; set; }

        public FriendSearchRequest() { }
    }
}
