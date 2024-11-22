namespace MX.Core.Crypto
{
    internal class XORCryptor
    {
        private readonly uint ENCRYPTION_KEY = 2948064217;

        public bool Encrypt(byte[] data, int offset, int length)
        {
            for (int i = offset; i < offset + length; i++)
            {
                data[i] ^= (byte)ENCRYPTION_KEY;
            }
            return true;
        }
    }
}
