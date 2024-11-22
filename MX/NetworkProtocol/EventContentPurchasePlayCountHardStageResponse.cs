using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentPurchasePlayCountHardStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_PurchasePlayCountHardStage; }
        }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }

        public EventContentPurchasePlayCountHardStageResponse() { }
    }
}
