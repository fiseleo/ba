namespace MX.NetworkProtocol
{
    public class CafeTrophyHistoryRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_TrophyHistory; }
        }

        public CafeTrophyHistoryRequest() { }
    }
}
