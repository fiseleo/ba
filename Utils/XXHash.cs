using System.IO.Hashing;
using System.Text;

namespace BA.Utils
{
    public class XXHash
    {
        public static int CalculateHash(string input)
        {
            byte[] data = Encoding.UTF8.GetBytes(input);
            byte[] b = XxHash32.Hash(data);
            Array.Reverse(b);
            return BitConverter.ToInt32(b, 0);
        }
    }
}
