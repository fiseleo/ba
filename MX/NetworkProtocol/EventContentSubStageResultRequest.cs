using MX.Logic.Battles.Summary;

namespace MX.NetworkProtocol
{
    public class EventContentSubStageResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_SubStageResult; }
        }

        public long EventContentId { get; set; }

        public bool PassCheckCharacter { get; set; }

        public BattleSummary Summary { get; set; }

        public EventContentSubStageResultRequest() { }
    }
}
