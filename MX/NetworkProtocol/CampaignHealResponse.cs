using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CampaignHealResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_Heal; }
        }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public DailyResetCountDB DailyResetCountDB { get; set; }

        public CampaignMainStageSaveDB SaveDataDB { get; set; }

        public CampaignHealResponse() { }
    }
}
