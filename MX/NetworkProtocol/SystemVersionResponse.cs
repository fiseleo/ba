namespace MX.NetworkProtocol
{
    public class SystemVersionResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.System_Version; }
        }

        public long CurrentVersion { get; set; }

        public long MinimumVersion { get; set; }

        public bool IsDevelopment { get; set; }

        public SystemVersionResponse() { }
    }
}
