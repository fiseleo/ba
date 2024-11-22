using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class AccountDismissRepurchasablePopupRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_DismissRepurchasablePopup; }
        }

        public List<long> ProductIds { get; set; }

        public AccountDismissRepurchasablePopupRequest() { }
    }
}
