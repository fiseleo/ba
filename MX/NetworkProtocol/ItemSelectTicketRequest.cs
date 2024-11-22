namespace MX.NetworkProtocol
{
    public class ItemSelectTicketRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Item_SelectTicket; }
        }

        public long TicketItemServerId { get; set; }

        public long SelectItemUniqueId { get; set; }

        public int ConsumeCount { get; set; }

        public ItemSelectTicketRequest() { }
    }
}
