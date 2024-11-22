using System.ComponentModel.DataAnnotations.Schema;
using FlatData;
using MX.Core.Math;
using Newtonsoft.Json;

namespace MX.GameLogic.Parcel
{
    public class ParcelInfo : IEquatable<ParcelInfo>
    {
        public ParcelKeyPair Key { get; set; }

        public long Amount { get; set; }

        [NotMapped]
        public BasisPoint Multiplier { get; set; } = new();

        [JsonIgnore]
        public long MultipliedAmount
        {
            get { return Amount * Multiplier; }
        }

        public BasisPoint Probability { get; set; } = new();

        public void SetParcelKeyPair(ParcelKeyPair parcelKeyPair) { }

        public ParcelInfo(ParcelKeyPair key, long amount, BasisPoint probability) { }

        public ParcelInfo(ParcelKeyPair key, long amount, long probability) { }

        public ParcelInfo() { }

        public ParcelInfo(ParcelInfo info) { }

        public ParcelInfo(ParcelKeyPair key, long amount) { }

        public ParcelInfo(ParcelType parcelType, long uniqueId, long amount) { }

        public ParcelInfo(CurrencyTypes currencyTypes, long amount) { }

        public ParcelInfo(ParcelType parcelType, long uniqueId, long amount, BasisPoint probability)
        { }

        public ParcelInfo(ParcelType parcelType, long uniqueId, long amount, long probability) { }

        public bool Equals(ParcelInfo? other)
        {
            return Key.Equals(other?.Key);
        }
    }
}
