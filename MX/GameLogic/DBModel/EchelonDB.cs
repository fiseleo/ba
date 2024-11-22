using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FlatData;
using Microsoft.EntityFrameworkCore;
using MX.Campaign;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    [PrimaryKey(
        nameof(AccountServerId),
        nameof(EchelonType),
        nameof(EchelonNumber),
        nameof(ExtensionType)
    )]
    public class EchelonDB
    {
        public long AccountServerId { get; set; }

        public EchelonType EchelonType { get; set; }

        public long EchelonNumber { get; set; }

        public EchelonExtensionType ExtensionType { get; set; }

        public long LeaderServerId { get; set; }

        [JsonIgnore]
        public int MainSlotCount
        {
            get { return 0; }
        }

        [JsonIgnore]
        public int SupportSlotCount
        {
            get { return 0; }
        }

        public List<long> MainSlotServerIds { get; set; }

        public bool TryResetMain(IList<long> main)
        {
            return default(bool);
        }

        public List<long> SupportSlotServerIds { get; set; }

        public bool TryResetSupport(IList<long> support)
        {
            return default(bool);
        }

        public long TSSInteractionServerId { get; set; }

        public EchelonDB.EchelonStatusFlag UsingFlag { get; set; }

        [JsonIgnore]
        public bool IsUsing
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public List<long> AllCharacterServerIds
        {
            get { return null; }
        }

        [JsonIgnore]
        public List<long> AllCharacterWithoutTSSServerIds
        {
            get { return null; }
        }

        [JsonIgnore]
        public List<long> BattleCharacterServerIds
        {
            get { return null; }
        }

        public List<long> SkillCardMulliganCharacterIds { get; set; } = [];

        public int[] CombatStyleIndex { get; set; } = [0, 0, 0, 0, 0, 0];

        [JsonConstructor]
        protected EchelonDB() { }

        public EchelonDB(
            long accountId,
            EchelonExtensionType extensionType = EchelonExtensionType.Base
        ) { }

        public EchelonDB(EchelonDB other) { }

        public EchelonDB(
            long accountId,
            EchelonType echelonType,
            long echelonNumber,
            EchelonExtensionType extensionType,
            EchelonPresetDB presetDB,
            IEnumerable<CharacterDB> characterDBs
        ) { }

        public bool ContainsCharacter(long characterServerId)
        {
            return default(bool);
        }

        public long GetStrategyLeaderCharacterServerId(HexaUnit hexaUnit)
        {
            return 0L;
        }

        public enum EchelonStatusFlag
        {
            None,
            BeforeDeploy,
            OnDuty
        }
    }
}
