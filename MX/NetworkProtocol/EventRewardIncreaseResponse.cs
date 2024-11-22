using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventRewardIncreaseResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Event_RewardIncrease; }
        }

        public List<EventRewardIncreaseDB> EventRewardIncreaseDBs { get; set; }

        public EventRewardIncreaseResponse() { }
    }
}
