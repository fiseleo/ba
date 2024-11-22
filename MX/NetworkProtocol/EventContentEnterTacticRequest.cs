namespace MX.NetworkProtocol
{
    public class EventContentEnterTacticRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_EnterTactic; }
        }

        public long EventContentId { get; set; }

        public long StageUniqueId { get; set; }

        public long EchelonIndex { get; set; }

        public long EnemyIndex { get; set; }

        public EventContentEnterTacticRequest() { }
    }
}
