using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;
using Newtonsoft.Json;

namespace MX.NetworkProtocol
{
    public class ShopBuyGachaResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BuyGacha; }
        }

        [JsonIgnore]
        public AccountCurrencyDB AccountCurrencyDB
        {
            get { return null; }
        }

        public ConsumeResultDB ConsumeResultDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public ShopBuyGachaResponse() { }
    }
}
