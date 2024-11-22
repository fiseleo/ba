namespace MX.NetworkProtocol
{
    public class AccountAuthRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_Auth; }
        }

        public long Version { get; set; }

        public string DevId { get; set; }

        public long IMEI { get; set; }

        public string AccessIP { get; set; }

        public string MarketId { get; set; }

        public string UserType { get; set; }

        public string AdvertisementId { get; set; }

        public string OSType { get; set; }

        public string OSVersion { get; set; }

        public string DeviceUniqueId { get; set; }

        public string DeviceModel { get; set; }

        public int DeviceSystemMemorySize { get; set; }

        public AccountAuthRequest() { }
    }
}
