using System.Collections.Generic;
using FlatData;
using Newtonsoft.Json;

namespace MX.GameLogic.Parcel
{
    public class CurrencyTransaction : ParcelBase, IEquatable<CurrencyTransaction>
    {
        [JsonProperty]
        private CurrencyValue currencyValue { get; }

        [JsonIgnore]
        public override ParcelType Type
        {
            get { return ParcelType.None; }
        }

        [JsonIgnore]
        public override IEnumerable<ParcelInfo> ParcelInfos
        {
            get { return null; }
        }

        [JsonIgnore]
        public IDictionary<CurrencyTypes, long> CurrencyValues
        {
            get { return null; }
        }

        [JsonIgnore]
        public CurrencyTransaction Inverse
        {
            get { return null; }
        }

        [JsonIgnore]
        public bool IsEmpty
        {
            get { return default(bool); }
        }

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

        public CurrencyTransaction() { }

        public CurrencyTransaction(CurrencyTypes type, long value) { }

        public CurrencyTransaction(IDictionary<CurrencyTypes, long> source) { }

        public CurrencyTransaction(CurrencyTransaction other) { }

        protected CurrencyTransaction(CurrencyValue currencyValue) { }

        public void SetValue(CurrencyTypes type, long value) { }

        public long GetValue(CurrencyTypes type)
        {
            return 0L;
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public static bool operator ==(CurrencyTransaction left, CurrencyTransaction right)
        {
            return default(bool);
        }

        public static bool operator !=(CurrencyTransaction left, CurrencyTransaction right)
        {
            return default(bool);
        }

        public bool Equals(CurrencyTransaction other)
        {
            return default(bool);
        }

        public static CurrencyTransaction operator +(
            CurrencyTransaction lhs,
            CurrencyTransaction rhs
        )
        {
            return null;
        }

        public static CurrencyTransaction operator -(
            CurrencyTransaction lhs,
            CurrencyTransaction rhs
        )
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }
    }
}
