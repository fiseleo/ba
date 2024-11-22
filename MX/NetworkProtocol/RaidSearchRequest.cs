using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    [Obsolete("MultiRaid")]
    public class RaidSearchRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_Search; }
        }

        public string SecretCode { get; set; }

        public List<string> Tags { get; set; }

        public RaidSearchRequest() { }
    }
}
