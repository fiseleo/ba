using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    [Obsolete]
    public class EquipmentItemSellRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Equipment_Sell; }
        }

        public List<long> TargetServerIds { get; set; }

        public EquipmentItemSellRequest() { }
    }
}
