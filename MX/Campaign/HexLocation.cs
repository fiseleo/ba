using System.Collections.Generic;
using Newtonsoft.Json;

// using UnityEngine;

namespace MX.Campaign
{
    [Serializable]
    public struct HexLocation : IEquatable<HexLocation>
    {
        [JsonIgnore]
        public static HexLocation Zero
        {
            get { return default(HexLocation); }
        }

        [JsonIgnore]
        public static HexLocation Invalid
        {
            get { return default(HexLocation); }
        }

        [JsonConstructor]
        public HexLocation(int _x, int _y, int _z) { }

        public HexLocation(HexLocation hexLocation) { }

        public Hex ToHex()
        {
            return default(Hex);
        }

        // public static HexLocation VectorToLocation(Vector3 pos)
        // {
        //     return default(HexLocation);
        // }

        // public static Vector3 LocationToVector(HexLocation location)
        // {
        //     return default(Vector3);
        // }

        // public static Vector3 GetVertexPosition(
        //     HexLocation location,
        //     int directionLeft,
        //     int directionRight
        // )
        // {
        //     return default(Vector3);
        // }

        public static int Distance(HexLocation a, HexLocation b)
        {
            return 0;
        }

        public static List<HexLocation> GetLocationRing(HexLocation center, int radius)
        {
            return null;
        }

        public static HexLocation operator -(HexLocation a, HexLocation b)
        {
            return default(HexLocation);
        }

        public static HexLocation operator +(HexLocation a, HexLocation b)
        {
            return default(HexLocation);
        }

        public static HexLocation operator *(HexLocation a, int b)
        {
            return default(HexLocation);
        }

        public static bool operator ==(HexLocation a, HexLocation b)
        {
            return default(bool);
        }

        public static bool operator !=(HexLocation a, HexLocation b)
        {
            return default(bool);
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public bool Equals(HexLocation other)
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

        // Note: this type is marked as 'beforefieldinit'.
        static HexLocation() { }

        public int x;

        public int y;

        public int z;

        [JsonIgnore]
        public static readonly int NeighborCount;

        [JsonIgnore]
        public static readonly HexLocation[] Directions;
    }
}
