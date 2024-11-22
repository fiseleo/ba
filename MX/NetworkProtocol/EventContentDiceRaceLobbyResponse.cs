using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentDiceRaceLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_DiceRaceLobby; }
        }

        public EventContentDiceRaceDB DiceRaceDB { get; set; }

        public EventContentDiceRaceLobbyResponse() { }
    }
}
