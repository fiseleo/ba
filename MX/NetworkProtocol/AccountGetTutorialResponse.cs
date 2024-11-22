using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class AccountGetTutorialResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_GetTutorial; }
        }

        public List<long> TutorialIds { get; set; }

        public AccountGetTutorialResponse() { }
    }
}
