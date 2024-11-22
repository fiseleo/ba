using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EliminateRaidCreateBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_CreateBattle; }
        }

        public RaidDB RaidDB { get; set; }

        public RaidBattleDB RaidBattleDB { get; set; }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public AssistCharacterDB AssistCharacterDB { get; set; }

        public EliminateRaidCreateBattleResponse() { }
    }
}
