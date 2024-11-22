using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class FriendRemoveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_Remove; }
        }

        public FriendDB[] FriendDBs { get; set; }

        public FriendDB[] SentRequestFriendDBs { get; set; }

        public FriendDB[] ReceivedRequestFriendDBs { get; set; }

        public FriendDB[] BlockedUserDBs { get; set; }

        public FriendRemoveResponse() { }
    }
}
