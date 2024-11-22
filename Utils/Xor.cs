using MX.Core.Math;

namespace BA.Utils
{
    public static class Xor
    {
        public static byte[] ConsumeFirst(byte[] consumed, byte[] repeated)
        {
            for (int i = 0, j = 0; i < consumed.Length; i++, j++)
            {
                if (j == repeated.Length)
                    j = 0;
                consumed[i] ^= repeated[j];
            }
            return consumed;
        }

        public static byte[] ConsumeFirst(byte[] consumed, string key)
        {
            int seed = XXHash.CalculateHash(key);
            var mt = new MersenneTwister(seed);
            byte[] bytes = mt.NextBytes(consumed.Length);
            return ConsumeFirst(consumed, bytes);
        }
    }
}
