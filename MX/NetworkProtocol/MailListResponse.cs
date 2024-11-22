using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class MailListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Mail_List; }
        }

        public List<MailDB> MailDBs { get; set; }

        public long Count { get; set; }

        public MailListResponse() { }
    }
}
