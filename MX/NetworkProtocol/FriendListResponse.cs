using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class FriendListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_List; }
        }

        public IdCardBackgroundDB[] IdCardBackgroundDBs { get; set; }

        public FriendDB[] FriendDBs { get; set; }

        public FriendDB[] SentRequestFriendDBs { get; set; }

        public FriendDB[] ReceivedRequestFriendDBs { get; set; }

        public FriendDB[] BlockedUserDBs { get; set; }

        public FriendListResponse() { }

        public FriendIdCardDB FriendIdCardDB;
    }
}
