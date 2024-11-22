using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class MailReceiveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Mail_Receive; }
        }

        public List<long> MailServerIds { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public MailReceiveResponse() { }
    }
}
