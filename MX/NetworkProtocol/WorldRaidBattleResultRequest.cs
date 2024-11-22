using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.Logic.Battles.Summary;

namespace MX.NetworkProtocol
{
    public class WorldRaidBattleResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.WorldRaid_BattleResult; }
        }

        public long SeasonId { get; set; }

        public long GroupId { get; set; }

        public long UniqueId { get; set; }

        public long EchelonId { get; set; }

        public bool IsPractice { get; set; }

        public bool IsTicket { get; set; }

        public BattleSummary Summary { get; set; }

        public List<ClanAssistUseInfo> AssistUseInfos { get; set; }

        public WorldRaidBattleResultRequest() { }
    }
}
