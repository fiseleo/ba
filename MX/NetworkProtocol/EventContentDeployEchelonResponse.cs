using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentDeployEchelonResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_DeployEchelon; }
        }

        public EventContentMainStageSaveDB SaveDataDB { get; set; }

        public EventContentDeployEchelonResponse() { }
    }
}
