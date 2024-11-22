using System.Collections.Generic;
using FlatData;

namespace MX.NetworkProtocol
{
    public class OpenConditionListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.OpenCondition_List; }
        }

        public List<OpenConditionContent> ConditionContents { get; set; }

        public OpenConditionListResponse() { }
    }
}
