using System.Collections.Generic;
using FlatData;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class NotificationEventContentReddotResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Notification_EventContentReddotCheck; }
        }

        public Dictionary<long, List<NotificationEventReddot>> Reddots { get; set; }

        public Dictionary<
            long,
            List<EventContentCollectionDB>
        > EventContentUnlockCGDBs { get; set; }

        public NotificationEventContentReddotResponse() { }
    }
}
