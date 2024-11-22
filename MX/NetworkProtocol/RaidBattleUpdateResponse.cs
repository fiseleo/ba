using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class RaidBattleUpdateResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_BattleUpdate; }
        }

        public RaidBattleDB RaidBattleDB { get; set; }

        public RaidBattleUpdateResponse() { }
    }
}
