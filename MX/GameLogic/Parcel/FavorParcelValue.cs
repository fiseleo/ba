using System.Collections.Generic;
using MX.Data;

namespace MX.GameLogic.Parcel
{
    public readonly struct FavorParcelValue : IEquatable<FavorParcelValue>
    {
        public int FavorRank { get; }

        public int FavorExp { get; }

        public IList<FavorLevelReward> Rewards { get; }

        public bool IsEmpty
        {
            get { return default(bool); }
        }

        public FavorParcelValue(int rank, int exp, IEnumerable<FavorLevelReward> rewards) { }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public bool Equals(FavorParcelValue other)
        {
            return default(bool);
        }

        // Note: this type is marked as 'beforefieldinit'.
        static FavorParcelValue() { }

        public static readonly FavorParcelValue Empty;
    }
}
