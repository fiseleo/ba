namespace MX.NetworkProtocol
{
    public class EliminateRaidGetBestTeamRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_GetBestTeam; }
        }
        public long SearchAccountId { get; set; }
    }
}
