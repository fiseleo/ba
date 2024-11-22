using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EliminateRaidCreateBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_CreateBattle; }
        }

        public long RaidUniqueId { get; set; }

        public bool IsPractice { get; set; }

        public ClanAssistUseInfo AssistUseInfo { get; set; }

        public EliminateRaidCreateBattleRequest() { }
    }
}
