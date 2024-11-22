using MX.Logic.Battles.Summary;

namespace MX.NetworkProtocol
{
    public class CampaignTutorialStageResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_TutorialStageResult; }
        }

        public BattleSummary Summary { get; set; }

        public CampaignTutorialStageResultRequest() { }
    }
}
