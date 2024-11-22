using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class WeekDungeonListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.WeekDungeon_List; }
        }

        public List<long> AdditionalStageIdList { get; set; }

        public List<WeekDungeonStageHistoryDB> WeekDungeonStageHistoryDBList { get; set; }

        public WeekDungeonListResponse() { }
    }
}
