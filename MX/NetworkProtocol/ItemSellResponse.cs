using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    [Obsolete]
    public class ItemSellResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Item_Sell; }
        }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public ItemSellResponse() { }
    }
}
