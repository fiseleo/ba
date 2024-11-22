namespace MX.NetworkProtocol
{
    public class NotificationEventContentReddotRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Notification_EventContentReddotCheck; }
        }

        public NotificationEventContentReddotRequest() { }
    }
}
