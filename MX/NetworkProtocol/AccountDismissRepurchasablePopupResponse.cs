namespace MX.NetworkProtocol
{
    public class AccountDismissRepurchasablePopupResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_DismissRepurchasablePopup; }
        }

        public AccountDismissRepurchasablePopupResponse() { }
    }
}
