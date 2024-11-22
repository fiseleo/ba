using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MX.GameLogic.DBModel;
using Newtonsoft.Json;

namespace MX.GameLogic.Parcel
{
    public class ParcelResultDB
    {
        public AccountDB AccountDB { get; set; } = null!;

        public List<AcademyLocationDB> AcademyLocationDBs { get; set; } = [];

        public bool ShouldSerializeAcademyLocationDBs()
        {
            return AcademyLocationDBs.Count != 0;
        }

        public AccountCurrencyDB AccountCurrencyDB { get; set; } = null!;

        public List<CharacterDB> CharacterDBs { get; set; } = [];

        public List<WeaponDB> WeaponDBs { get; set; } = [];

        public List<CostumeDB> CostumeDBs { get; set; } = [];

        public bool ShouldSerializeCharacterDBs()
        {
            return CharacterDBs.Count != 0;
        }

        public List<CharacterDB> TSSCharacterDBs { get; set; } = [];

        public bool ShouldSerializeTSSCharacterDBs()
        {
            return TSSCharacterDBs.Count != 0;
        }

        public Dictionary<long, EquipmentDB> EquipmentDBs { get; set; } = [];

        public bool ShouldSerializeEquipmentDBs()
        {
            return EquipmentDBs.Count != 0;
        }

        public List<long> RemovedEquipmentIds { get; set; } = [];

        public bool ShouldSerializeRemovedEquipmentIds()
        {
            return RemovedEquipmentIds.Count != 0;
        }

        public Dictionary<long, ItemDB> ItemDBs { get; set; } = [];

        public bool ShouldSerializeItemDBs()
        {
            return ItemDBs.Count != 0;
        }

        public List<long> RemovedItemIds { get; set; } = [];

        public bool ShouldSerializeRemovedItemIds()
        {
            return RemovedItemIds.Count != 0;
        }

        public Dictionary<long, FurnitureDB> FurnitureDBs { get; set; } = [];

        public bool ShouldSerializeFurnitureDBs()
        {
            return FurnitureDBs.Count != 0;
        }

        public List<long> RemovedFurnitureIds { get; set; } = [];

        public bool ShouldSerializeRemovedFurnitureIds()
        {
            return RemovedFurnitureIds.Count != 0;
        }

        public Dictionary<long, IdCardBackgroundDB> IdCardBackgroundDBs { get; set; } = [];

        public bool ShouldSerializeIdCardBackgroundDBs()
        {
            return IdCardBackgroundDBs.Count != 0;
        }

        public List<EmblemDB> EmblemDBs { get; set; } = [];

        public bool ShouldSerializeEmblemDBs()
        {
            return EmblemDBs.Count != 0;
        }

        public List<StickerDB> StickerDBs { get; set; } = [];

        public bool ShouldSerializeStickerDBs()
        {
            return StickerDBs.Count != 0;
        }

        public List<MemoryLobbyDB> MemoryLobbyDBs { get; set; } = [];

        public bool ShouldSerializeMemoryLobbyDBs()
        {
            return MemoryLobbyDBs.Count != 0;
        }

        public List<long> CharacterNewUniqueIds { get; set; } = [];

        public bool ShouldSerializeCharacterNewUniqueIds()
        {
            return CharacterNewUniqueIds.Count != 0;
        }

        public Dictionary<long, int> SecretStoneCharacterIdAndCounts { get; set; } = [];

        public bool ShouldSerializeSecretStoneCharacterIdAndCounts()
        {
            return SecretStoneCharacterIdAndCounts.Count != 0;
        }

        [NotMapped]
        public List<ParcelInfo> DisplaySequence { get; set; } = [];

        public bool ShouldSerializeDisplaySequence()
        {
            return DisplaySequence.Count != 0;
        }

        [NotMapped]
        public List<ParcelInfo> ParcelForMission { get; set; } = [];

        public bool ShouldSerializeParcelForMission()
        {
            return ParcelForMission.Count != 0;
        }

        [NotMapped]
        public List<ParcelResultStepInfo> ParcelResultStepInfoList { get; set; } = [];

        public bool ShouldSerializeParcelResultStepInfoList()
        {
            return ParcelResultStepInfoList.Count != 0;
        }

        public long BaseAccountExp { get; set; }

        public long AdditionalAccountExp { get; set; }

        [JsonIgnore]
        public List<long> GachaResultCharacters { get; private set; } = [];

        public void AddGachaLog(IList<GachaLogDB> logs)
        {
            logs.Select(v => v.CharacterId).ToList().ForEach(GachaResultCharacters.Add);
        }

        public void Clear() { }

        public ParcelResultDB() { }
    }
}
