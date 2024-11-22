namespace MX.NetworkProtocol
{
    public class TimeAttackDungeonLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.TimeAttackDungeon_Lobby; }
        }

        public TimeAttackDungeonLobbyRequest() { }
    }
}
