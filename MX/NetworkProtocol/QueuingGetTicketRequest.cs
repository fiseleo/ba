namespace MX.NetworkProtocol
{
    public class QueuingGetTicketRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Queuing_GetTicket; }
        }

        public long YostarUID { get; set; }

        public string YostarToken { get; set; }

        public bool MakeStandby { get; set; }

        public bool PassCheck { get; set; }

        public bool PassCheckYostar { get; set; }

        public string WaitingTicket { get; set; }

        public string ClientVersion { get; set; }

        public QueuingGetTicketRequest() { }
    }
}
