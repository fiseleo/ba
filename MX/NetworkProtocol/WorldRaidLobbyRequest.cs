namespace MX.NetworkProtocol
{
    public class WorldRaidLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.WorldRaid_Lobby; }
        }

        public long SeasonId { get; set; }

        public WorldRaidLobbyRequest() { }
    }
}
