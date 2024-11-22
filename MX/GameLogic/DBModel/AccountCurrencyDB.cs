using System.Collections.Generic;
using FlatData;
using MX.GameLogic.Parcel;

namespace MX.GameLogic.DBModel
{
    public class AccountCurrencyDB
    {
        public long AccountLevel { get; set; } = 1;

        public long AcademyLocationRankSum { get; set; } = 1;

        public Dictionary<CurrencyTypes, long> CurrencyDict { get; set; } = [];

        public bool ShouldSerializeCurrencyDict()
        {
            return CurrencyDict.Count > 0;
        }

        public Dictionary<CurrencyTypes, DateTime> UpdateTimeDict { get; set; } = [];

        public bool ShouldSerializeUpdateTimeDict()
        {
            return UpdateTimeDict.Count > 0;
        }

        public CurrencySnapshot CreateSnapshot(DateTime serverTime)
        {
            return null;
        }

        public AccountCurrencyDB() { }

        public AccountCurrencyDB(
            Dictionary<CurrencyTypes, long> currencySource,
            Dictionary<CurrencyTypes, DateTime> updateTimeSource
        ) { }
    }
}
