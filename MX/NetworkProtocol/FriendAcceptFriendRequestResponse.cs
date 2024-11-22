using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class FriendAcceptFriendRequestResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_AcceptFriendRequest; }
        }

        public FriendDB[] FriendDBs { get; set; }

        public FriendDB[] SentRequestFriendDBs { get; set; }

        public FriendDB[] ReceivedRequestFriendDBs { get; set; }

        public FriendDB[] BlockedUserDBs { get; set; }

        public FriendAcceptFriendRequestResponse() { }
    }
}
