using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class NotificationLobbyCheckResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Notification_LobbyCheck; }
        }

        public long UnreadMailCount { get; set; }

        public List<EventRewardIncreaseDB> EventRewardIncreaseDBs { get; set; }

        public NotificationLobbyCheckResponse() { }
    }
}
