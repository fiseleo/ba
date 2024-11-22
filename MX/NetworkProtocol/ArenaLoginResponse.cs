using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ArenaLoginResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_Login; }
        }

        public ArenaPlayerInfoDB ArenaPlayerInfoDB { get; set; }

        public ArenaLoginResponse() { }
    }
}
