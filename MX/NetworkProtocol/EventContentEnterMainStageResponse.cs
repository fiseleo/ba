using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentEnterMainStageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_EnterMainStage; }
        }

        public EventContentMainStageSaveDB SaveDataDB { get; set; }

        public bool IsOnSubEvent { get; set; }

        public EventContentEnterMainStageResponse() { }
    }
}
