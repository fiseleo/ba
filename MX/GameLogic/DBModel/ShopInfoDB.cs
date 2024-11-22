using System.Collections.Generic;
using FlatData;

namespace MX.GameLogic.DBModel
{
    public class ShopInfoDB
    {
        public long EventContentId { get; set; }

        public ShopCategoryType Category { get; set; }

        public long? ManualRefreshCount { get; set; }

        public bool IsRefresh { get; set; }

        public DateTime? NextAutoRefreshDate { get; set; }

        public DateTime? LastAutoRefreshDate { get; set; }

        public List<ShopProductDB> ShopProductList { get; set; }

        public ShopInfoDB() { }
    }
}
