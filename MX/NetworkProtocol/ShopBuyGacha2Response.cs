using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ShopBuyGacha2Response : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_BuyGacha2; }
        }

        public DateTime UpdateTime { get; set; }

        public long GemBonusRemain { get; set; }

        public long GemPaidRemain { get; set; }

        public List<ItemDB> ConsumedItems { get; set; }

        public List<GachaResult> GachaResults { get; set; }

        public List<ItemDB> AcquiredItems { get; set; }

        public ShopBuyGacha2Response() { }
    }
}
