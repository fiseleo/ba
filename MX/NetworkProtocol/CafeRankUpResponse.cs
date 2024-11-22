using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CafeRankUpResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_RankUp; }
        }

        public CafeDB CafeDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public ConsumeResultDB ConsumeResultDB { get; set; }

        public CafeRankUpResponse() { }
    }
}
