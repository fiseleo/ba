using System.Collections.Generic;
using FlatData;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ClanAllAssistListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_AllAssistList; }
        }

        public EchelonType EchelonType { get; set; }

        public List<ClanAssistUseInfo> PendingAssistUseInfo { get; set; }

        public ClanAllAssistListRequest() { }
    }
}
