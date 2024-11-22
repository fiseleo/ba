using MX.Campaign;

namespace MX.NetworkProtocol
{
    public class ScenarioMapMoveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_MapMove; }
        }

        public long StageUniqueId { get; set; }

        public long EchelonEntityId { get; set; }

        public HexLocation DestPosition { get; set; }

        public ScenarioMapMoveRequest() { }
    }
}
