namespace MX.NetworkProtocol
{
    public class RaidLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_Lobby; }
        }
    }
}
