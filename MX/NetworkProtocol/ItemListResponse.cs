using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ItemListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Item_List; }
        }

        public List<ItemDB> ItemDBs { get; set; }

        public List<ItemDB> ExpiryItemDBs { get; set; }

        public ItemListResponse() { }
    }
}
