using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CampaignPurchasePlayCountHardStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_PurchasePlayCountHardStage; }
        }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }

        public CampaignPurchasePlayCountHardStageResponse() { }
    }
}
