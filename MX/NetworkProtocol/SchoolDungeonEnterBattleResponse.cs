using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class SchoolDungeonEnterBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.SchoolDungeon_EnterBattle; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public SchoolDungeonEnterBattleResponse() { }
    }
}
