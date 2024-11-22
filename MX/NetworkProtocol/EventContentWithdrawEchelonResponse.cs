using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentWithdrawEchelonResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_WithdrawEchelon; }
        }

        public EventContentMainStageSaveDB SaveDataDB { get; set; }

        public List<EchelonDB> WithdrawEchelonDBs { get; set; }

        public EventContentWithdrawEchelonResponse() { }
    }
}
