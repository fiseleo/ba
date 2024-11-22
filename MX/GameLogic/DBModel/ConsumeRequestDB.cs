using System.Collections.Generic;
using FlatData;
using MX.GameLogic.Parcel;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class ConsumeRequestDB
    {
        public Dictionary<long, long> ConsumeItemServerIdAndCounts { get; set; }

        public Dictionary<long, long> ConsumeEquipmentServerIdAndCounts { get; set; }

        public Dictionary<long, long> ConsumeFurnitureServerIdAndCounts { get; set; }

        [JsonIgnore]
        public bool IsItemsValid
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public bool IsEquipmentsValid
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public bool IsFurnituresValid
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public bool IsValid
        {
            get { return default(bool); }
        }

        public ConsumeRequestDB() { }

        public ConsumeRequestDB WithParcels(ParcelInfo parcelInfo, IDictionary<long, long> items)
        {
            return null;
        }

        public ConsumeRequestDB WithParcels(ParcelType parcelType, IDictionary<long, long> items)
        {
            return null;
        }

        public ConsumeRequestDB WithParcel(ParcelInfo parcelInfo, long serverId, long count)
        {
            return null;
        }

        public ConsumeRequestDB WithParcel(ParcelType parcelType, long serverId, long count)
        {
            return null;
        }

        public ConsumeRequestDB WithItems(IDictionary<long, long> items)
        {
            return null;
        }

        public ConsumeRequestDB WithItems(IEnumerable<long> source)
        {
            return null;
        }

        public ConsumeRequestDB WithItem(long serverId, long count)
        {
            return null;
        }

        public ConsumeRequestDB WithEquipments(IDictionary<long, long> equipments)
        {
            return null;
        }

        public ConsumeRequestDB WithEquipments(IEnumerable<long> source)
        {
            return null;
        }

        public ConsumeRequestDB WithEquipment(long serverId, long count)
        {
            return null;
        }

        public ConsumeRequestDB WithFurnitures(IDictionary<long, long> furnitures)
        {
            return null;
        }

        public ConsumeRequestDB WithFurnitures(IEnumerable<long> source)
        {
            return null;
        }

        public ConsumeRequestDB WithFurniture(long serverId, long count)
        {
            return null;
        }

        public ConsumeRequestDB MergeWith(ConsumeRequestDB other)
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }
    }
}
