namespace MX.NetworkProtocol
{
    public class CampaignEnterSubStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_EnterSubStage; }
        }

        public long StageUniqueId { get; set; }

        public long LastEnterStageEchelonNumber { get; set; }

        public CampaignEnterSubStageRequest() { }
    }
}
