using FlatData;

namespace MX.GameLogic.Parcel
{
    public struct ParcelKeyPair : IEquatable<ParcelKeyPair>, IComparable<ParcelKeyPair>
    {
        public ParcelKeyPair(ParcelType type, long uniqueId)
        {
            Type = type;
            Id = uniqueId;
        }

        public ParcelType Type { readonly get; set; }

        public long Id { readonly get; set; }

        public bool Equals(ParcelKeyPair other)
        {
            return Type.Equals(other.Type) && Id.Equals(other.Id);
        }

        public int CompareTo(ParcelKeyPair other)
        {
            return Type.CompareTo(other.Type) * 100000 + Id.CompareTo(other.Id);
        }

        // Note: this type is marked as 'beforefieldinit'.
        static ParcelKeyPair() { }

        public static readonly ParcelKeyPair Empty;
    }
}
