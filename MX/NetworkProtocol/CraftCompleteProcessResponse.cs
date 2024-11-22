using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CraftCompleteProcessResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_CompleteProcess; }
        }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public CraftInfoDB CraftInfoDB { get; set; }

        public ItemDB TicketItemDB { get; set; }

        public CraftCompleteProcessResponse() { }
    }
}
