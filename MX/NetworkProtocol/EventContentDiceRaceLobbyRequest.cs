namespace MX.NetworkProtocol
{
    public class EventContentDiceRaceLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_DiceRaceLobby; }
        }

        public long EventContentId { get; set; }

        public EventContentDiceRaceLobbyRequest() { }
    }
}
