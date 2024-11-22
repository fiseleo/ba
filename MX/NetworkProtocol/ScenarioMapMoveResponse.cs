using System.Collections.Generic;
using MX.Campaign;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ScenarioMapMoveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Scenario_MapMove; }
        }

        public StoryStrategyStageSaveDB SaveDataDB { get; set; }

        public List<long> ScenarioIds { get; set; }

        public long EchelonEntityId { get; set; }

        public Strategy StrategyObject { get; set; }

        public List<ParcelInfo> StrategyObjectParcelInfos { get; set; }

        public ScenarioMapMoveResponse() { }
    }
}
