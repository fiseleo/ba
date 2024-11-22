using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    [Obsolete]
    public class EquipmentItemSellResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Equipment_Sell; }
        }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public EquipmentItemSellResponse() { }
    }
}
