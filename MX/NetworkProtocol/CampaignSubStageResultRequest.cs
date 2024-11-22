using MX.Logic.Battles.Summary;

namespace MX.NetworkProtocol
{
    public class CampaignSubStageResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_SubStageResult; }
        }

        public bool PassCheckCharacter { get; set; }

        public BattleSummary Summary { get; set; }

        public CampaignSubStageResultRequest() { }
    }
}
