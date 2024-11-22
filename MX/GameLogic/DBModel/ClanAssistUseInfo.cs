using FlatData;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class ClanAssistUseInfo
    {
        public long CharacterAccountId { get; set; }

        public long CharacterDBId { get; set; }

        public EchelonType EchelonType { get; set; }

        public int SlotNumber { get; set; }

        public AssistRelation AssistRelation { get; set; }

        public int EchelonSlotType { get; set; }

        public int EchelonSlotIndex { get; set; }

        public int CombatStyleIndex { get; set; }

        [JsonIgnore]
        public long DecodedShardId
        {
            get { return 0L; }
        }

        [JsonIgnore]
        public long DecodedCharacterDBId
        {
            get { return 0L; }
        }

        public bool IsMulligan { get; set; }

        public bool IsTSAInteraction { get; set; }

        public ClanAssistUseInfo() { }

        public ClanAssistUseInfo(
            long accountId,
            long characterDBId,
            EchelonType echelonType,
            int slotNumber,
            int slotType,
            int slotIndex,
            AssistRelation assistRelation,
            bool isMulligan = false,
            bool isTSAInteraction = false,
            int combatStyleIndex = 0
        ) { }

        public ClanAssistUseInfo(
            AssistCharacterDB assistDB,
            int echelonSlotType,
            int echelonSlotIndex,
            bool isMulligan,
            bool isTSAInteraction,
            int combatStyleIndex
        ) { }

        public ClanAssistUseInfo(ClanAssistUseInfo assistUseInfo) { }
    }
}
