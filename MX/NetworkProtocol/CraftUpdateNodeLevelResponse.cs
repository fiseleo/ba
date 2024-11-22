using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CraftUpdateNodeLevelResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_UpdateNodeLevel; }
        }

        public CraftInfoDB CraftInfoDB { get; set; }

        public CraftNodeDB CraftNodeDB { get; set; }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public ConsumeResultDB ConsumeResultDB { get; set; }

        public CraftUpdateNodeLevelResponse() { }
    }
}
