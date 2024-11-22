using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class FriendSearchResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_Search; }
        }

        public FriendDB[] SearchResult { get; set; }

        public FriendSearchResponse() { }
    }
}
