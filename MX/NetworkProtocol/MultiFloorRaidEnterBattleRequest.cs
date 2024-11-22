using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class MultiFloorRaidEnterBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MultiFloorRaid_EnterBattle; }
        }

        public long SeasonId { get; set; }

        public int Difficulty { get; set; }

        public int EchelonId { get; set; }

        public List<ClanAssistUseInfo> AssistUseInfos { get; set; }

        public MultiFloorRaidEnterBattleRequest() { }
    }
}
