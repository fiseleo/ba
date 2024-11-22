using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentConfirmMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_ConfirmMainStage; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EventContentMainStageSaveDB SaveDataDB { get; set; }

        public EventContentConfirmMainStageResponse() { }
    }
}
