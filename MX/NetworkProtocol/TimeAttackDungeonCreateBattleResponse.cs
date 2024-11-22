using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class TimeAttackDungeonCreateBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.TimeAttackDungeon_CreateBattle; }
        }

        public TimeAttackDungeonRoomDB RoomDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public TimeAttackDungeonCreateBattleResponse() { }
    }
}
