using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class TimeAttackDungeonGiveUpResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.TimeAttackDungeon_GiveUp; }
        }

        public TimeAttackDungeonRoomDB RoomDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public bool AchieveSeasonBestRecord { get; set; }

        public long SeasonBestRecord { get; set; }

        public TimeAttackDungeonGiveUpResponse() { }
    }
}
