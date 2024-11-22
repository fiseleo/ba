using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EchelonSaveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Echelon_Save; }
        }

        public EchelonDB EchelonDB { get; set; }

        public List<ClanAssistUseInfo> AssistUseInfos { get; set; }

        public bool IsPractice { get; set; }

        public EchelonSaveRequest() { }
    }
}
