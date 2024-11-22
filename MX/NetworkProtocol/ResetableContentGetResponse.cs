using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ResetableContentGetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ResetableContent_Get; }
        }

        public List<ResetableContentValueDB> ResetableContentValueDBs { get; set; }

        public ResetableContentGetResponse() { }
    }
}
