namespace MX.NetworkProtocol
{
    public class RaidGetBestTeamRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_GetBestTeam; }
        }
        public long SearchAccountId { get; set; }
    }
}
