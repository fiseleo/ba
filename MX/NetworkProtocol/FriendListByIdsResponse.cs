using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class FriendListByIdsResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_ListByIds; }
        }

        public FriendDB[] ListResult { get; set; }

        public FriendListByIdsResponse() { }
    }
}
