using System.Collections.Generic;
using MX.Campaign;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentMapMoveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_MapMove; }
        }

        public EventContentMainStageSaveDB SaveDataDB { get; set; }

        public long EchelonEntityId { get; set; }

        public Strategy StrategyObject { get; set; }

        public List<ParcelInfo> StrategyObjectParcelInfos { get; set; }

        public EventContentMapMoveResponse() { }
    }
}
