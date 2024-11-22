using System.Collections.Generic;
using FlatData;
using MX.GameLogic.DBModel;
using Newtonsoft.Json;

namespace MX.GameLogic.Parcel
{
    public class ParcelCost
    {
        public List<ParcelInfo> ParcelInfos { get; set; }

        public CurrencyTransaction Currency { get; set; }

        public List<EquipmentDB> EquipmentDBs { get; set; }

        public List<ItemDB> ItemDBs { get; set; }

        public List<FurnitureDB> FurnitureDBs { get; set; }

        [JsonIgnore]
        public bool HasCurrency
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public bool HasItem
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public bool IsEmpty
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public IEnumerable<ConsumableItemBaseDB> ConsumableItemBaseDBs
        {
            get { return null; }
        }

        public ConsumeCondition ConsumeCondition { get; set; }

        public ParcelCost() { }

        public ParcelCost(IEnumerable<ParcelInfo> costParcelInfos) { }

        public ParcelCost(
            IEnumerable<ParcelInfo> costParcelInfos,
            ConsumeCondition consumeCondition
        ) { }

        public ParcelCost(CurrencyTransaction currencyTransaction) { }

        public ParcelCost(ParcelInfo costParcelInfo) { }

        public ParcelCost(
            CurrencyTransaction currencyTransaction,
            IEnumerable<ParcelInfo> costParcelInfos
        ) { }

        public ParcelCost(IEnumerable<ParcelInfo> costParcelInfos, long multipleCount) { }

        public void Add(IEnumerable<ParcelInfo> parcelInfos) { }

        public void Add(ParcelInfo parcelInfo) { }

        public void Add(ParcelCost other) { }

        public ParcelCost[] GetSubCost()
        {
            return null;
        }

        public static bool operator ==(ParcelCost lhs, ParcelCost rhs)
        {
            return default(bool);
        }

        public static bool operator !=(ParcelCost lhs, ParcelCost rhs)
        {
            return default(bool);
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return null;
        }

        private List<ConsumableItemBaseDB> _consumableItemBaseDBs;
    }
}
