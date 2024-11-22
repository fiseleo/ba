using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentEndTurnResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_EndTurn; }
        }

        public EventContentMainStageSaveDB SaveDataDB { get; set; }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public EventContentEndTurnResponse() { }
    }
}
