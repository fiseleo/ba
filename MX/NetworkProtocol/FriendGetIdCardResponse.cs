using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class FriendGetIdCardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_GetIdCard; }
        }

        public FriendIdCardDB FriendIdCardDB { get; set; }

        public FriendGetIdCardResponse() { }
    }
}
