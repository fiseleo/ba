namespace MX.NetworkProtocol
{
    public class NotificationLobbyCheckRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Notification_LobbyCheck; }
        }

        public NotificationLobbyCheckRequest() { }
    }
}
