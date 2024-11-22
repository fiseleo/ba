namespace MX.NetworkProtocol
{
    public class MailListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Mail_List; }
        }

        public bool IsReadMail { get; set; }

        public DateTime PivotTime { get; set; }

        public long PivotIndex { get; set; }

        public bool IsDescending { get; set; }

        public MailListRequest() { }
    }
}
