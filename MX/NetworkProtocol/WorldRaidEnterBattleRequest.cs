using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class WorldRaidEnterBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.WorldRaid_EnterBattle; }
        }

        public long SeasonId { get; set; }

        public long GroupId { get; set; }

        public long UniqueId { get; set; }

        public long EchelonId { get; set; }

        public bool IsPractice { get; set; }

        public bool IsTicket { get; set; }

        public List<ClanAssistUseInfo> AssistUseInfos { get; set; }

        public WorldRaidEnterBattleRequest() { }
    }
}
