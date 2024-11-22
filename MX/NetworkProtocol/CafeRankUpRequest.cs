using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CafeRankUpRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_RankUp; }
        }

        public long AccountServerId { get; set; }

        public long CafeDBId { get; set; }

        public ConsumeRequestDB ConsumeRequestDB { get; set; }

        public CafeRankUpRequest() { }
    }
}
