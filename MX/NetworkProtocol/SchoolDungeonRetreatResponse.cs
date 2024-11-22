using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class SchoolDungeonRetreatResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.SchoolDungeon_Retreat; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public SchoolDungeonRetreatResponse() { }
    }
}
