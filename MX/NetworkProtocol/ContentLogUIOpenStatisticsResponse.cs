namespace MX.NetworkProtocol
{
    public class ContentLogUIOpenStatisticsResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ContentLog_UIOpenStatistics; }
        }

        public ContentLogUIOpenStatisticsResponse() { }
    }
}
