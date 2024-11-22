using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class ContentLogUIOpenStatisticsRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ContentLog_UIOpenStatistics; }
        }

        public Dictionary<string, int> OpenCountPerPrefab { get; set; }

        public ContentLogUIOpenStatisticsRequest() { }
    }
}
