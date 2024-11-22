using System.Collections.Generic;
using MX.Data;

namespace MX.NetworkProtocol
{
    public class ContentSweepMultiSweepRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ContentSweep_MultiSweep; }
        }

        public IEnumerable<MultiSweepParameter> MultiSweepParameters { get; set; }

        public ContentSweepMultiSweepRequest() { }
    }
}
