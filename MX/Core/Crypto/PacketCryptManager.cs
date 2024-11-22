using System.IO.Compression;
using System.Text;
using MX.NetworkProtocol;

namespace MX.Core.Crypto
{
    public class PacketCryptManager
    {
        // private static readonly short PROTOCOL_HEAD_RESERVE = 8;
        private readonly XORCryptor _cryptor = new();
        private readonly FastCRC _checke = new();
        private ProtocolConverter _converter = new();
        public static PacketCryptManager Instance = new();

        public byte[] RequestToBinary(Protocol protocol, string json)
        {
            byte[] compressedData = Compress(json);
            _cryptor.Encrypt(compressedData, 0, compressedData.Length);
            _checke.GetCRC(compressedData, 0, compressedData.Length, out uint crc);
            int protocolConverter = _converter.TypeConversion(crc, protocol);

            byte[][] data =
            [
                BitConverter.GetBytes(crc),
                BitConverter.GetBytes(protocolConverter),
                compressedData
            ];
            byte[] result = data.SelectMany(_ => _).ToArray();
            return result;
        }

        protected byte[] Compress(string text)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(text);
            using var memoryStream = new MemoryStream();
            using (var gzipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
            {
                gzipStream.Write(inputBytes, 0, inputBytes.Length);
            }
            byte[] compressedData = memoryStream.ToArray();

            byte[][] data = [BitConverter.GetBytes(inputBytes.Length), compressedData];
            byte[] result = data.SelectMany(_ => _).ToArray();
            return result;
        }
    }
}
