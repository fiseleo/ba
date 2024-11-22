using MX.Campaign;
using MX.Logic.Battles.Summary;

namespace MX.NetworkProtocol
{
    public class CampaignTacticResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_TacticResult; }
        }

        public bool PassCheckCharacter { get; set; }

        public BattleSummary Summary { get; set; }

        public SkillCardHand Hand { get; set; }

        public TacticSkipSummary SkipSummary { get; set; }

        public CampaignTacticResultRequest() { }
    }
}
