using System.Collections.Generic;
using Newtonsoft.Json;

namespace MX.Core.Math
{
    [Serializable]
    public struct BasisPoint : IEquatable<BasisPoint>, IComparable<BasisPoint>
    {
        [JsonIgnore]
        public long RawValue
        {
            get { return rawValue; }
        }

        public BasisPoint(long rawValue)
        {
            this.rawValue = rawValue;
        }

        // public static BasisPoint Min(BasisPoint lhs, BasisPoint rhs)
        // {
        //     return default(BasisPoint);
        // }

        // public static BasisPoint Max(BasisPoint lhs, BasisPoint rhs)
        // {
        //     return default(BasisPoint);
        // }

        // public static BasisPoint Clamp(BasisPoint value, BasisPoint min, BasisPoint max)
        // {
        //     return default(BasisPoint);
        // }

        // public static BasisPoint FromFloat(float value)
        // {
        //     return default(BasisPoint);
        // }

        // public static BasisPoint FromDouble(double value)
        // {
        //     return default(BasisPoint);
        // }

        // public static BasisPoint FromLong(long value)
        // {
        //     return default(BasisPoint);
        // }

        // public double ToDouble()
        // {
        //     return 0.0;
        // }

        // public float ToFloat()
        // {
        //     return 0f;
        // }

        // public long ToLong()
        // {
        //     return 0L;
        // }

        // public static BasisPoint Sum(IEnumerable<BasisPoint> list)
        // {
        //     return default(BasisPoint);
        // }

        public static long MultiplyLong(long value, BasisPoint basisPoint)
        {
            double result = OneOver10_4 * ((double)basisPoint.rawValue * value);

            if (double.IsInfinity(result))
                return long.MaxValue;

            return (long)result;
        }

        // public static BasisPoint Multiply(BasisPoint lhs, BasisPoint rhs)
        // {
        //     return default(BasisPoint);
        // }

        // public static BasisPoint Divide(BasisPoint lhs, BasisPoint rhs)
        // {
        //     return default(BasisPoint);
        // }

        // public static BasisPoint Divide(long lhs, BasisPoint rhs)
        // {
        //     return default(BasisPoint);
        // }

        // public static BasisPoint Divide(BasisPoint lhs, long rhs)
        // {
        //     return default(BasisPoint);
        // }

        // public static BasisPoint operator *(BasisPoint lhs, BasisPoint rhs)
        // {
        //     return default(BasisPoint);
        // }

        public static long operator *(long lhs, BasisPoint rhs)
        {
            return MultiplyLong(lhs, rhs);
        }

        // public static long operator *(BasisPoint lhs, long rhs)
        // {
        //     return 0L;
        // }

        // public static BasisPoint operator /(BasisPoint lhs, BasisPoint rhs)
        // {
        //     return default(BasisPoint);
        // }

        // public static BasisPoint operator /(long lhs, BasisPoint rhs)
        // {
        //     return default(BasisPoint);
        // }

        // public static BasisPoint operator /(BasisPoint lhs, long rhs)
        // {
        //     return default(BasisPoint);
        // }

        // public static BasisPoint operator +(BasisPoint lhs, BasisPoint rhs)
        // {
        //     return default(BasisPoint);
        // }

        // public static BasisPoint operator +(long lhs, BasisPoint rhs)
        // {
        //     return default(BasisPoint);
        // }

        // public static BasisPoint operator +(BasisPoint lhs, long rhs)
        // {
        //     return default(BasisPoint);
        // }

        // public static BasisPoint operator -(BasisPoint lhs, BasisPoint rhs)
        // {
        //     return default(BasisPoint);
        // }

        // public static BasisPoint operator -(long lhs, BasisPoint rhs)
        // {
        //     return default(BasisPoint);
        // }

        // public static BasisPoint operator -(BasisPoint lhs, long rhs)
        // {
        //     return default(BasisPoint);
        // }

        // public static bool operator ==(BasisPoint x, BasisPoint y)
        // {
        //     return default(bool);
        // }

        // public static bool operator !=(BasisPoint x, BasisPoint y)
        // {
        //     return default(bool);
        // }

        public int CompareTo(BasisPoint other)
        {
            return rawValue.CompareTo(other.rawValue);
        }

        // public static bool operator <(BasisPoint left, BasisPoint right)
        // {
        //     return default(bool);
        // }

        // public static bool operator <=(BasisPoint left, BasisPoint right)
        // {
        //     return default(bool);
        // }

        // public static bool operator >(BasisPoint left, BasisPoint right)
        // {
        //     return default(bool);
        // }

        // public static bool operator >=(BasisPoint left, BasisPoint right)
        // {
        //     return default(bool);
        // }

        // public override int GetHashCode()
        // {
        //     return 0;
        // }

        // public override bool Equals(object obj)
        // {
        //     return default(bool);
        // }

        public bool Equals(BasisPoint other)
        {
            return rawValue == other.rawValue;
        }

        // public override string ToString()
        // {
        //     return null;
        // }

        // Note: this type is marked as 'beforefieldinit'.
        // static BasisPoint() { }

        // private static readonly long Multiplier;

        private static readonly double OneOver10_4 = 1.0 / 10000.0;

        public static readonly BasisPoint Zero;

        public static readonly BasisPoint One;

        public static readonly BasisPoint Epsilon;

        public static readonly double DoubleEpsilon;

        [JsonProperty]
        private long rawValue = 10000;
    }
}
