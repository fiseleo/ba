using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CharacterExpGrowthResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_ExpGrowth; }
        }

        public CharacterDB CharacterDB { get; set; }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public ConsumeResultDB ConsumeResultDB { get; set; }

        public CharacterExpGrowthResponse() { }
    }
}
