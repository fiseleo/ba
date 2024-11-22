using System.Collections.Generic;
using FlatData;

namespace MX.GameLogic.DBModel
{
    public class RaidTeamSettingDB
    {
        public long AccountId { get; set; }

        public long TryNumber { get; set; }

        public EchelonType EchelonType { get; set; }

        public EchelonExtensionType EchelonExtensionType { get; set; }

        public IList<RaidCharacterDB> MainCharacterDBs { get; set; }

        public IList<RaidCharacterDB> SupportCharacterDBs { get; set; }

        public IList<long> SkillCardMulliganCharacterIds { get; set; }

        public long TSSInteractionUniqueId { get; set; }

        public long LeaderCharacterUniqueId { get; set; }

        public RaidTeamSettingDB() { }

        public RaidTeamSettingDB(ClearDeckDB clearDeckDB) { }

        public static RaidTeamSettingDB Clone(RaidTeamSettingDB raidTeamSettingDB)
        {
            return null;
        }

        public RaidTeamSettingDB Clone()
        {
            return null;
        }
    }
}
