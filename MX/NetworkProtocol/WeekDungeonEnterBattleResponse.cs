using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class WeekDungeonEnterBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.WeekDungeon_EnterBattle; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public int Seed { get; set; }

        public int Sequence { get; set; }

        public WeekDungeonEnterBattleResponse() { }
    }
}
