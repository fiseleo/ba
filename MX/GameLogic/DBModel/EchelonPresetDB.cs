using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using FlatData;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class EchelonPresetDB
    {
        [DefaultValue(-1)]
        public int GroupIndex { get; set; } = -1;

        [DefaultValue(-1)]
        public int Index { get; set; } = -1;

        public string Label { get; set; }

        public long LeaderUniqueId { get; set; }

        public long TSSInteractionUniqueId { get; set; }

        public long[] StrikerUniqueIds { get; set; }

        public long[] SpecialUniqueIds { get; set; }

        public int[] CombatStyleIndex { get; set; }

        public List<long> MulliganUniqueIds { get; set; }

        public EchelonExtensionType ExtensionType { get; set; }

        [JsonIgnore]
        public int StrikerSlotCount
        {
            get { return 0; }
        }

        [JsonIgnore]
        public int SpecialSlotCount
        {
            get { return 0; }
        }

        public EchelonPresetDB Clone()
        {
            return null;
        }

        [JsonConstructor]
        protected EchelonPresetDB() { }

        public EchelonPresetDB(int groupIndex, int index, EchelonExtensionType extensionType) { }

        public EchelonPresetDB(
            int groupIndex,
            int index,
            EchelonExtensionType extensionType,
            long[] strikerUniqueIds,
            long[] specialUniqueIds,
            long leaderUniqueId,
            long tssInteractionUniqueId,
            [Optional] long[] mulliganUniqueIds,
            [Optional] int[] combatStyleIndex
        ) { }

        public EchelonPresetDB(
            int groupIndex,
            int index,
            EchelonDB echelonDB,
            IEnumerable<CharacterDB> characterDBs,
            [Optional] IEnumerable<ClanAssistUseInfo> assistUseInfos,
            [Optional] IEnumerable<AssistCharacterDB> assistCharacterDBs
        ) { }

        public bool IsNotEmpty()
        {
            return default(bool);
        }
    }
}
