using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EliminateRaidEnterBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_EnterBattle; }
        }

        public RaidDB RaidDB { get; set; }

        public RaidBattleDB RaidBattleDB { get; set; }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public AssistCharacterDB AssistCharacterDB { get; set; }

        public EliminateRaidEnterBattleResponse() { }
    }
}
