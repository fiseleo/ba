using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CampaignRetreatResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_Retreat; }
        }

        public List<long> ReleasedEchelonNumbers { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CampaignRetreatResponse() { }
    }
}
