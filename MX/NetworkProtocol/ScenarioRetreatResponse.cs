using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ScenarioRetreatResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_Retreat; }
        }

        public List<long> ReleasedEchelonNumbers { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public ScenarioRetreatResponse() { }
    }
}
