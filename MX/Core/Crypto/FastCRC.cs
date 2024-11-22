namespace MX.Core.Crypto
{
    public class FastCRC
    {
        public static uint[] crc_table = new uint[256];
        public readonly uint POLYNOMIAL = 0x4c1_1db7;
        public readonly uint MASK = 0x8000_0000;

        private void Generate()
        {
            for (uint i = 0; i < 256; i++)
            {
                uint crcValue = i << 24;
                for (int times = 8; times > 0; times--)
                {
                    if ((MASK & crcValue) != 0)
                    {
                        crcValue = POLYNOMIAL ^ (2 * crcValue);
                    }
                    else
                    {
                        crcValue *= 2;
                    }
                }
                crc_table[i] = crcValue;
            }
        }

        public bool GetCRC(byte[] buffer, int offset, int length, out uint crc)
        {
            crc = 0;
            for (int i = offset; i < offset + length; i++)
            {
                byte b = buffer[i];
                crc = crc_table[(crc >> 24) ^ b] ^ (crc << 8);
            }
            return true;
        }

        static FastCRC()
        {
            new FastCRC().Generate();
        }
    }
}
