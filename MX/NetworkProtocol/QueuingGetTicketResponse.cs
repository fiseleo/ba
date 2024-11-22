namespace MX.NetworkProtocol
{
    public class QueuingGetTicketResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Queuing_GetTicket; }
        }

        public string WaitingTicket { get; set; }

        public string EnterTicket { get; set; }

        public long TicketSequence { get; set; }

        public long AllowedSequence { get; set; }

        public double RequiredSecondsPerUser { get; set; }

        public string Birth { get; set; }

        public string ServerSeed { get; set; }

        public void Reset() { }

        public QueuingGetTicketResponse() { }
    }
}
