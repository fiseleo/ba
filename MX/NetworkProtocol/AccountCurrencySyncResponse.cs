using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class AccountCurrencySyncResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_CurrencySync; }
        }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public AccountCurrencySyncResponse() { }
    }
}
