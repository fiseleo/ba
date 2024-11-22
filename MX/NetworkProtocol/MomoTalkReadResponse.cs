using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class MomoTalkReadResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MomoTalk_Read; }
        }

        public MomoTalkOutLineDB MomoTalkOutLineDB { get; set; }

        public List<MomoTalkChoiceDB> MomoTalkChoiceDBs { get; set; }

        public MomoTalkReadResponse() { }
    }
}
