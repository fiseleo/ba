using System.Collections.Generic;
using FlatData;

namespace MX.GameLogic.Parcel
{
    public class CurrencyValue : IEquatable<CurrencyValue>
    {
        public Dictionary<CurrencyTypes, long> Values { get; private set; }

        public Dictionary<CurrencyTypes, long> Tickets
        {
            get { return null; }
        }

        public Dictionary<CurrencyTypes, long> Property
        {
            get { return null; }
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

        public CurrencyValue() { }

        public CurrencyValue(IDictionary<CurrencyTypes, long> keyValuePairs) { }

        public CurrencyValue CreateInverse()
        {
            return null;
        }

        public bool IsEmpty
        {
            get { return default(bool); }
        }

        public long GetValue(CurrencyTypes type)
        {
            return 0L;
        }

        public void SetValue(CurrencyTypes type, long value) { }

        public static bool IsSchoolDungeonTicketReward(ParcelInfo parcelInfo)
        {
            return default(bool);
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public static bool operator ==(CurrencyValue left, CurrencyValue right)
        {
            return default(bool);
        }

        public static bool operator !=(CurrencyValue left, CurrencyValue right)
        {
            return default(bool);
        }

        public bool Equals(CurrencyValue other)
        {
            return default(bool);
        }

        public override string ToString()
        {
            return null;
        }

        public static CurrencyValue operator +(CurrencyValue lhs, CurrencyValue rhs)
        {
            return null;
        }

        public static CurrencyValue operator -(CurrencyValue lhs, CurrencyValue rhs)
        {
            return null;
        }

        public void Add(CurrencyValue other) { }

        public void Subtract(CurrencyValue other) { }

        // Note: this type is marked as 'beforefieldinit'.
        static CurrencyValue() { }

        public static readonly IEnumerable<CurrencyTypes> DBCurrencyTypes;

        public static readonly IEnumerable<CurrencyTypes> DBPropertyCurrencyTypes;

        public static readonly IEnumerable<CurrencyTypes> DBTicketCurrencyTypes;

        public static readonly IEnumerable<CurrencyTypes> ValidCurrencyTypes;

        public static readonly IEnumerable<CurrencyTypes> WorldRaidTickets;

        public static readonly IEnumerable<CurrencyTypes> BILogCurrencyTypes;
    }
}
