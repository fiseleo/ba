using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class WeekDungeonBattleResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.WeekDungeon_BattleResult; }
        }

        public WeekDungeonStageHistoryDB WeekDungeonStageHistoryDB { get; set; }

        public List<CharacterDB> LevelUpCharacterDBs { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public WeekDungeonBattleResultResponse() { }
    }
}
