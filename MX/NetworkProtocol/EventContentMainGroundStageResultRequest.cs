using MX.Logic.Battles.Summary;

namespace MX.NetworkProtocol
{
    public class EventContentMainGroundStageResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_MainGroundStageResult; }
        }

        public long EventContentId { get; set; }

        public bool PassCheckCharacter { get; set; }

        public BattleSummary Summary { get; set; }

        public EventContentMainGroundStageResultRequest() { }
    }
}
