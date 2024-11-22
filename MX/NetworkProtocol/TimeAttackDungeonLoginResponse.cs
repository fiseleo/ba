using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class TimeAttackDungeonLoginResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.TimeAttackDungeon_Login; }
        }

        public TimeAttackDungeonRoomDB PreviousRoomDB { get; set; }

        public TimeAttackDungeonLoginResponse() { }
    }
}
