using System.Collections.Generic;
using MX.Data;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class AccountAuthResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_Auth; }
        }

        public long CurrentVersion { get; set; }

        public long MinimumVersion { get; set; }

        public bool IsDevelopment { get; set; }

        public bool BattleValidation { get; set; }

        public bool UpdateRequired { get; set; }

        public string TTSCdnUri { get; set; }

        public AccountDB AccountDB { get; set; }

        public IEnumerable<AttendanceBookReward> AttendanceBookRewards { get; set; }

        public IEnumerable<AttendanceHistoryDB> AttendanceHistoryDBs { get; set; }

        public IEnumerable<OpenConditionDB> OpenConditions { get; set; }

        public IEnumerable<PurchaseCountDB> RepurchasableMonthlyProductCountDBs { get; set; }

        public IEnumerable<ParcelInfo> MonthlyProductParcel { get; set; }

        public IEnumerable<ParcelInfo> MonthlyProductMail { get; set; }

        public IEnumerable<ParcelInfo> BiweeklyProductParcel { get; set; }

        public IEnumerable<ParcelInfo> BiweeklyProductMail { get; set; }

        public IEnumerable<ParcelInfo> WeeklyProductParcel { get; set; }

        public IEnumerable<ParcelInfo> WeeklyProductMail { get; set; }

        public string EncryptedUID { get; set; }

        public AccountAuthResponse() { }
    }
}
