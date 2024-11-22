using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CampaignWithdrawEchelonResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_WithdrawEchelon; }
        }

        public CampaignMainStageSaveDB SaveDataDB { get; set; }

        public List<EchelonDB> WithdrawEchelonDBs { get; set; }

        public CampaignWithdrawEchelonResponse() { }
    }
}
