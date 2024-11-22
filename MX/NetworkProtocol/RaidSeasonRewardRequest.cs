namespace MX.NetworkProtocol
{
    public class RaidSeasonRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_SeasonReward; }
        }

        public RaidSeasonRewardRequest() { }
    }
}
