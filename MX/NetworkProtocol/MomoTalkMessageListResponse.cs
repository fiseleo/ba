using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class MomoTalkMessageListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MomoTalk_MessageList; }
        }

        public MomoTalkOutLineDB MomoTalkOutLineDB { get; set; }

        public List<MomoTalkChoiceDB> MomoTalkChoiceDBs { get; set; }

        public MomoTalkMessageListResponse() { }
    }
}
