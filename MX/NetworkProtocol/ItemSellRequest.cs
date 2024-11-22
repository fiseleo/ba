using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    [Obsolete]
    public class ItemSellRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Item_Sell; }
        }

        public List<long> TargetServerIds { get; set; }

        public ItemSellRequest() { }
    }
}
