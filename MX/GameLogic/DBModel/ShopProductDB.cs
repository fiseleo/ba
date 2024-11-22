using FlatData;
using MX.Data;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class ShopProductDB
    {
        public long EventContentId { get; set; }

        public long ShopExcelId { get; set; }

        public ShopCategoryType Category { get; set; }

        public long DisplayOrder { get; set; }

        public long PurchaseCount { get; set; }

        [JsonIgnore]
        public bool SoldOut
        {
            get { return default(bool); }
        }

        public long PurchaseCountLimit { get; set; }

        public long Price { get; set; }

        public ShopProductType ProductType { get; set; }

        public ShopProductDB() { }

        // public ShopProductDB(ShopExcelData shopExcelData) { }

        // public ShopProductDB(ShopRefreshExcelData shopRefreshExcelData) { }

        public long GetGoodsId(bool isRefresh)
        {
            return 0L;
        }
    }
}
