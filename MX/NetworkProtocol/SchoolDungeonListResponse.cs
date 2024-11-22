using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class SchoolDungeonListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.SchoolDungeon_List; }
        }

        public List<SchoolDungeonStageHistoryDB> SchoolDungeonStageHistoryDBList { get; set; }

        public SchoolDungeonListResponse() { }
    }
}
