using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class WorldRaidBattleResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.WorldRaid_BattleResult; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public WorldRaidBattleResultResponse() { }
    }
}
