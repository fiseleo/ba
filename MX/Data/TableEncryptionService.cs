using System.Text;
using BA.Utils;
using MX.Core.Math;

namespace MX.Data
{
    public static class TableEncryptionService
    {
        public static byte[] CreateKey(string name)
        {
            int seed = XXHash.CalculateHash(name);
            var mt = new MersenneTwister(seed);
            return mt.NextBytes(8);
        }

        public static byte[] XOR(string name, byte[] bytes)
        {
            int seed = XXHash.CalculateHash(name);
            var mt = new MersenneTwister(seed);
            var key = mt.NextBytes(bytes.Length);
            return Xor.ConsumeFirst(bytes, key);
        }

        public static int Convert(int value, byte[] key)
        {
            byte[] before = BitConverter.GetBytes(value);
            byte[] after = Xor.ConsumeFirst(before, key);
            return BitConverter.ToInt32(after, 0);
        }

        public static long Convert(long value, byte[] key)
        {
            byte[] before = BitConverter.GetBytes(value);
            byte[] after = Xor.ConsumeFirst(before, key);
            return BitConverter.ToInt64(after, 0);
        }

        public static uint Convert(uint value, byte[] key)
        {
            byte[] before = BitConverter.GetBytes(value);
            byte[] after = Xor.ConsumeFirst(before, key);
            return BitConverter.ToUInt32(after, 0);
        }

        public static ulong Convert(ulong value, byte[] key)
        {
            byte[] before = BitConverter.GetBytes(value);
            byte[] after = Xor.ConsumeFirst(before, key);
            return BitConverter.ToUInt64(after, 0);
        }

        public static float Encrypt(float value, byte[] key)
        {
            int ratio = key[0] % 10;
            if (ratio <= 1)
                ratio = 7;
            if ((key[0] & 1) != 0)
                ratio = -ratio;

            value *= 10000.0f;
            int v = float.IsInfinity(value) ? int.MinValue : (int)value;

            return ratio * v;
        }

        public static float Convert(float value, byte[] key)
        {
            int ratio = key[0] % 10;
            if (ratio <= 1)
                ratio = 7;
            if ((key[0] & 1) != 0)
                ratio = -ratio;

            value = float.IsInfinity(value) ? -2147483648f : (int)value;

            return value / ratio / 10000.0f;
        }

        public static double Encrypt(double value, byte[] key)
        {
            int ratio = key[0] % 10;
            if (ratio <= 1)
                ratio = 7;
            if ((key[0] & 1) != 0)
                ratio = -ratio;

            value *= 1000000.0;
            long v = double.IsInfinity(value) ? long.MinValue : (long)value;

            return ratio * v;
        }

        public static double Convert(double value, byte[] key)
        {
            int ratio = key[0] % 10;
            if (ratio <= 1)
                ratio = 7;
            if ((key[0] & 1) != 0)
                ratio = -ratio;

            float v = double.IsInfinity(value) ? -9223372036854775808f : (long)value;

            return value / ratio / 1000000.0;
        }

        public static string Encrypt(string value, byte[] key)
        {
            byte[] before = Encoding.Unicode.GetBytes(value);
            byte[] after = Xor.ConsumeFirst(before, key);
            return System.Convert.ToBase64String(after);
        }

        public static string Convert(string value, byte[] key)
        {
            byte[] before = System.Convert.FromBase64String(value);
            byte[] after = Xor.ConsumeFirst(before, key);
            return Encoding.Unicode.GetString(after);
        }
    }
}
