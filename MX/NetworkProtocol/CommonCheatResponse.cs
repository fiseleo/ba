using System.Collections.Generic;
using MX.Data;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CommonCheatResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Common_Cheat; }
        }

        public AccountDB Account { get; set; }

        public AccountCurrencyDB AccountCurrency { get; set; }

        public List<CharacterDB> CharacterDBs { get; set; }

        public List<EquipmentDB> EquipmentDBs { get; set; }

        public List<WeaponDB> WeaponDBs { get; set; }

        public List<GearDB> GearDBs { get; set; }

        public List<CostumeDB> CostumeDBs { get; set; }

        public List<ItemDB> ItemDBs { get; set; }

        public List<ScenarioHistoryDB> ScenarioHistoryDBs { get; set; }

        public List<ScenarioGroupHistoryDB> ScenarioGroupHistoryDBs { get; set; }

        public List<EmblemDB> EmblemDBs { get; set; }

        public List<AttendanceBookReward> AttendanceBookRewards { get; set; }

        public List<AttendanceHistoryDB> AttendanceHistoryDBs { get; set; }

        public List<StickerDB> StickerDBs { get; set; }

        public List<MemoryLobbyDB> MemoryLobbyDBs { get; set; }

        public CheatFlags CheatFlags { get; set; }

        public CommonCheatResponse() { }
    }
}
