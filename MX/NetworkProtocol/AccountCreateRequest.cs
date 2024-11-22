namespace MX.NetworkProtocol
{
    public class AccountCreateRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_Create; }
        }

        public string DevId { get; set; }

        public long Version { get; set; }

        public long IMEI { get; set; }

        public string AccessIP { get; set; }

        public string MarketId { get; set; }

        public string UserType { get; set; }

        public string AdvertisementId { get; set; }

        public string OSType { get; set; }

        public string OSVersion { get; set; }

        public AccountCreateRequest() { }
    }
}
