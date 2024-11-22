using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class AccountSetTutorialRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_SetTutorial; }
        }

        public List<long> TutorialIds { get; set; }

        public AccountSetTutorialRequest() { }
    }
}
