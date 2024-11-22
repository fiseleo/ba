namespace MX.NetworkProtocol
{
    public class CampaignEnterMainStageStrategySkipRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_EnterMainStageStrategySkip; }
        }

        public long StageUniqueId { get; set; }

        public long LastEnterStageEchelonNumber { get; set; }

        public CampaignEnterMainStageStrategySkipRequest() { }
    }
}
