using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentEnterStoryStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_EnterStoryStage; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EventContentStoryStageSaveDB SaveDataDB { get; set; }

        public EventContentEnterStoryStageResponse() { }
    }
}
