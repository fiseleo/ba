using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    [Obsolete("MultiRaid")]
    public class RaidRewardAllResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_RewardAll; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public RaidRewardAllResponse() { }
    }
}
