using System.Text.Json.Serialization;

namespace MX.NetworkProtocol
{
    public abstract class RequestPacket : BasePacket
    {
        private static int _counter;

        public int ClientUpTime { get; set; }
        public bool Resendable { get; set; } = true;
        public long Hash
        {
            get { return CreateHash(Protocol); }
            set { }
        }
        public bool IsTest { get; set; }

        [JsonIgnore]
        public DateTime? ModifiedServerTime__DebugOnly { get; set; }

        public static long CreateHash(Protocol protocol)
        {
            return ((long)_counter++) | ((long)protocol << 32);
        }
    }
}
