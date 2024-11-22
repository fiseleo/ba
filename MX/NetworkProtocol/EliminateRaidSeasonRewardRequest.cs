namespace MX.NetworkProtocol
{
    public class EliminateRaidSeasonRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_SeasonReward; }
        }

        public EliminateRaidSeasonRewardRequest() { }
    }
}
