using MX.Campaign;
using MX.Logic.Battles.Summary;

namespace MX.NetworkProtocol
{
    public class EventContentTacticResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_TacticResult; }
        }

        public long EventContentId { get; set; }

        public bool PassCheckCharacter { get; set; }

        public BattleSummary Summary { get; set; }

        public SkillCardHand Hand { get; set; }

        public TacticSkipSummary SkipSummary { get; set; }

        public EventContentTacticResultRequest() { }
    }
}
