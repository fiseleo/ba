namespace MX.NetworkProtocol
{
    public class EliminateRaidLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_Lobby; }
        }

        public EliminateRaidLobbyRequest() { }
    }
}
