using Newtonsoft.Json;

namespace MX.NetworkProtocol
{
    public class IrcServerConfig
    {
        public string HostAddress { get; set; }

        public int Port { get; set; }

        public string Password { get; set; }

        [JsonIgnore]
        public bool IsValid
        {
            get { return default(bool); }
        }

        public override string ToString()
        {
            return null;
        }

        public IrcServerConfig() { }
    }
}
