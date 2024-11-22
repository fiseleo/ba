using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentDiceRaceLapRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_DiceRaceLapReward; }
        }

        public EventContentDiceRaceDB DiceRaceDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EventContentDiceRaceLapRewardResponse() { }
    }
}
