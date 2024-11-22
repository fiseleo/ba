using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentRestartMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_RestartMainStage; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EventContentMainStageSaveDB SaveDataDB { get; set; }

        public EventContentRestartMainStageResponse() { }
    }
}
