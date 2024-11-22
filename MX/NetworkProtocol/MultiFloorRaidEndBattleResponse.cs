using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class MultiFloorRaidEndBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MultiFloorRaid_EndBattle; }
        }

        public MultiFloorRaidDB MultiFloorRaidDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public MultiFloorRaidEndBattleResponse() { }
    }
}
