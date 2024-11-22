using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ArenaHistoryResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_History; }
        }

        public List<ArenaHistoryDB> ArenaHistoryDBs { get; set; }

        public List<ArenaDamageReportDB> ArenaDamageReportDB { get; set; }

        public ArenaHistoryResponse() { }
    }
}
