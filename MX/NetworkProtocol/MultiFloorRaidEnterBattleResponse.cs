using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class MultiFloorRaidEnterBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MultiFloorRaid_EnterBattle; }
        }

        public List<AssistCharacterDB> AssistCharacterDBs { get; set; }

        public MultiFloorRaidEnterBattleResponse() { }
    }
}
