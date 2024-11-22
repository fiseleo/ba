using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class OpenConditionSetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.OpenCondition_Set; }
        }

        public List<OpenConditionDB> ConditionDBs { get; set; }

        public OpenConditionSetResponse() { }
    }
}
