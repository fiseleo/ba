using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class SchoolDungeonBattleResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.SchoolDungeon_BattleResult; }
        }

        public SchoolDungeonStageHistoryDB SchoolDungeonStageHistoryDB { get; set; }

        public List<CharacterDB> LevelUpCharacterDBs { get; set; }

        public List<ParcelInfo> FirstClearReward { get; set; }

        public List<ParcelInfo> ThreeStarReward { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public SchoolDungeonBattleResultResponse() { }
    }
}
