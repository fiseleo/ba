namespace MX.NetworkProtocol
{
    public class EventContentDiceRaceRollRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_DiceRaceRoll; }
        }

        public long EventContentId { get; set; }

        public EventContentDiceRaceRollRequest() { }
    }
}
