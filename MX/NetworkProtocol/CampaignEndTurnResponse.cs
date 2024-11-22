using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CampaignEndTurnResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_EndTurn; }
        }

        public CampaignMainStageSaveDB SaveDataDB { get; set; }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public CampaignEndTurnResponse() { }
    }
}
