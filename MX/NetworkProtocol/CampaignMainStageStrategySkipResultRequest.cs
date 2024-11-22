using MX.Logic.Battles.Summary;

namespace MX.NetworkProtocol
{
    public class CampaignMainStageStrategySkipResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_MainStageStrategySkipResult; }
        }

        public bool PassCheckCharacter { get; set; }

        public BattleSummary Summary { get; set; }

        public CampaignMainStageStrategySkipResultRequest() { }
    }
}
