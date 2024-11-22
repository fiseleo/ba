using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class CampaignWithdrawEchelonRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_WithdrawEchelon; }
        }

        public long StageUniqueId { get; set; }

        public List<long> WithdrawEchelonEntityId { get; set; }

        public CampaignWithdrawEchelonRequest() { }
    }
}
