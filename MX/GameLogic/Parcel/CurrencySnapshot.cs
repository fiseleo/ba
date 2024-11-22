using System.Collections.Generic;
using FlatData;
using MX.GameLogic.DBModel;
using MX.NetworkProtocol;
using Newtonsoft.Json;

namespace MX.GameLogic.Parcel
{
    public class CurrencySnapshot
    {
        public AccountCurrencyDB LastAccountCurrencyDB { get; private set; }

        [JsonIgnore]
        public Dictionary<CurrencyTypes, long> CurrencyValues
        {
            get { return null; }
        }

        [JsonProperty]
        private CurrencyValue currencyValue { get; }

        [JsonIgnore]
        public DateTime ServerTimeSnapshot { get; }

        public long Gold
        {
            get { return 0L; }
        }

        public long Gem
        {
            get { return 0L; }
        }

        public long GemBonus
        {
            get { return 0L; }
        }

        public long GemPaid
        {
            get { return 0L; }
        }

        public long ActionPoint
        {
            get { return 0L; }
        }

        public long ArenaTicket
        {
            get { return 0L; }
        }

        public long RaidTicket
        {
            get { return 0L; }
        }

        public long WeekDungeonChaserATicket
        {
            get { return 0L; }
        }

        public long WeekDungeonChaserBTicket
        {
            get { return 0L; }
        }

        public long WeekDungeonChaserCTicket
        {
            get { return 0L; }
        }

        public long WeekDungeonFindGiftTicket
        {
            get { return 0L; }
        }

        public long WeekDungeonBloodTicket
        {
            get { return 0L; }
        }

        public long AcademyTicket
        {
            get { return 0L; }
        }

        public long SchoolDungeonATicket
        {
            get { return 0L; }
        }

        public long SchoolDungeonBTicket
        {
            get { return 0L; }
        }

        public long SchoolDungeonCTicket
        {
            get { return 0L; }
        }

        public long TimeAttackDungeonTicket
        {
            get { return 0L; }
        }

        public long MasterCoin
        {
            get { return 0L; }
        }

        public long WorldRaidTicketA
        {
            get { return 0L; }
        }

        public long WorldRaidTicketB
        {
            get { return 0L; }
        }

        public long WorldRaidTicketC
        {
            get { return 0L; }
        }

        public long ChaserTotalTicket
        {
            get { return 0L; }
        }

        public long SchoolDungeonTotalTicket
        {
            get { return 0L; }
        }

        public long EliminateTicketA
        {
            get { return 0L; }
        }

        public long EliminateTicketB
        {
            get { return 0L; }
        }

        public long EliminateTicketC
        {
            get { return 0L; }
        }

        public long EliminateTicketD
        {
            get { return 0L; }
        }

        public CurrencySnapshot(AccountCurrencyDB currencyDB, DateTime serverTime) { }

        public CurrencySnapshot(CurrencySnapshot other) { }

        public bool CanAffordCost(CurrencyTransaction cost)
        {
            return default(bool);
        }

        public void SetValue(CurrencyTypes type, long value) { }

        public long GetValue(CurrencyTypes type)
        {
            return 0L;
        }

        public CurrencySnapshot Clone()
        {
            return null;
        }

        public WebAPIErrorCode CheckNegativeAsset(IEnumerable<ParcelInfo> rewards)
        {
            return WebAPIErrorCode.None;
        }

        private bool HasTargetCurrencyReward(
            CurrencyTypes currencyTypes,
            IEnumerable<ParcelInfo> rewards
        )
        {
            return default(bool);
        }
    }
}
