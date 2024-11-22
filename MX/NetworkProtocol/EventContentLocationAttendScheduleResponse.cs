using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EventContentLocationAttendScheduleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_LocationAttendSchedule; }
        }

        public EventContentLocationDB EventContentLocationDB { get; set; }

        public IEnumerable<EventContentCollectionDB> EventContentCollectionDBs { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public List<ParcelInfo> ExtraRewards { get; set; }

        public EventContentLocationAttendScheduleResponse() { }
    }
}
