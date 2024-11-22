using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CraftAutoBeginProcessResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_AutoBeginProcess; }
        }

        public List<CraftInfoDB> CraftInfoDBs { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CraftAutoBeginProcessResponse() { }
    }
}
