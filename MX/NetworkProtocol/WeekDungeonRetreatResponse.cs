using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class WeekDungeonRetreatResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.WeekDungeon_Retreat; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public WeekDungeonRetreatResponse() { }
    }
}
