using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class WorldRaidEnterBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.WorldRaid_EnterBattle; }
        }

        public RaidBattleDB RaidBattleDB { get; set; }

        public List<AssistCharacterDB> AssistCharacterDBs { get; set; }

        public WorldRaidEnterBattleResponse() { }
    }
}
