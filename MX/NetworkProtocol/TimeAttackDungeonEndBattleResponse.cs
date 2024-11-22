using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class TimeAttackDungeonEndBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.TimeAttackDungeon_EndBattle; }
        }

        public TimeAttackDungeonRoomDB RoomDB { get; set; }

        public long TotalPoint { get; set; }

        public long DefaultPoint { get; set; }

        public long TimePoint { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public TimeAttackDungeonEndBattleResponse() { }
    }
}
