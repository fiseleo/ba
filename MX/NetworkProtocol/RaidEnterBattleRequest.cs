using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class RaidEnterBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_EnterBattle; }
        }

        public long RaidServerId { get; set; }

        public long RaidUniqueId { get; set; }

        public bool IsPractice { get; set; }

        public long EchelonId { get; set; }

        public ClanAssistUseInfo AssistUseInfo { get; set; }

        public RaidEnterBattleRequest() { }
    }
}
