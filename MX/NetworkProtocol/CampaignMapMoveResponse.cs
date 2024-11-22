using System.Collections.Generic;
using MX.Campaign;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CampaignMapMoveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_MapMove; }
        }

        public CampaignMainStageSaveDB SaveDataDB { get; set; }

        public long EchelonEntityId { get; set; }

        public Strategy StrategyObject { get; set; }

        public List<ParcelInfo> StrategyObjectParcelInfos { get; set; }

        public CampaignMapMoveResponse() { }
    }
}
