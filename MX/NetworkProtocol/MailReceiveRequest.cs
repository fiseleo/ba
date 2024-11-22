using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class MailReceiveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Mail_Receive; }
        }

        public List<long> MailServerIds { get; set; }

        public MailReceiveRequest() { }
    }
}
