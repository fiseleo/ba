using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.Logic.Battles.Summary;

namespace MX.NetworkProtocol
{
    public class MultiFloorRaidEndBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MultiFloorRaid_EndBattle; }
        }

        public long SeasonId { get; set; }

        public int Difficulty { get; set; }

        public BattleSummary Summary { get; set; }

        public int EchelonId { get; set; }

        public List<ClanAssistUseInfo> AssistUseInfos { get; set; }

        public MultiFloorRaidEndBattleRequest() { }
    }
}
