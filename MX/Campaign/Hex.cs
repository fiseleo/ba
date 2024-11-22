// using UnityEngine;

namespace MX.Campaign
{
    [Serializable]
    public struct Hex : IEquatable<Hex>
    {
        public Hex(int _q, int _r) { }

        public HexLocation ToLocation()
        {
            return default(HexLocation);
        }

        // public static Hex VectorToHex(Vector3 pos)
        // {
        //     return default(Hex);
        // }

        // public static Vector3 HexToVector(Hex hex)
        // {
        //     return default(Vector3);
        // }

        public static Hex operator -(Hex a, Hex b)
        {
            return default(Hex);
        }

        public static Hex operator +(Hex a, Hex b)
        {
            return default(Hex);
        }

        public static bool operator ==(Hex a, Hex b)
        {
            return default(bool);
        }

        public static bool operator !=(Hex a, Hex b)
        {
            return default(bool);
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public bool Equals(Hex other)
        {
            return default(bool);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public int col;

        public int row;
    }
}
