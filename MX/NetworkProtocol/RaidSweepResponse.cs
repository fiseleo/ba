using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class RaidSweepResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_Sweep; }
        }

        public long TotalSeasonPoint { get; set; }

        public List<List<ParcelInfo>> Rewards { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public RaidSweepResponse() { }
    }
}
