using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EliminateRaidSweepResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_Sweep; }
        }

        public long TotalSeasonPoint { get; set; }

        public List<List<ParcelInfo>> Rewards { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EliminateRaidSweepResponse() { }
    }
}
