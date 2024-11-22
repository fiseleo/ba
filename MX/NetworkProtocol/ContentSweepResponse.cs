using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ContentSweepResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ContentSweep_Request; }
        }

        public List<List<ParcelInfo>> ClearParcels { get; set; }

        public List<ParcelInfo> BonusParcels { get; set; }

        public List<List<ParcelInfo>> EventContentBonusParcels { get; set; }

        public ParcelResultDB ParcelResult { get; set; }

        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }

        public ContentSweepResponse() { }
    }
}
