namespace MX.NetworkProtocol
{
    public class AccountCurrencySyncRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_CurrencySync; }
        }

        public AccountCurrencySyncRequest() { }
    }
}
