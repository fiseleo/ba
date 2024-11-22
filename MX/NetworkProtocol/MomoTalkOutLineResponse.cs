using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class MomoTalkOutLineResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MomoTalk_OutLine; }
        }

        public List<MomoTalkOutLineDB> MomoTalkOutLineDBs { get; set; }

        public Dictionary<long, List<long>> FavorScheduleRecords { get; set; }

        public MomoTalkOutLineResponse() { }
    }
}
