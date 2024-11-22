using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ScenarioClearResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_Clear; }
        }

        public ScenarioHistoryDB ScenarioHistoryDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public ScenarioClearResponse() { }
    }
}
