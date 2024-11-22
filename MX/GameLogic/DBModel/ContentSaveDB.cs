using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BA.Utils;
using FlatData;
using MX.GameLogic.Parcel;

namespace MX.GameLogic.DBModel
{
    public abstract class ContentSaveDB
    {
        public abstract ContentType ContentType { get; }

        public long AccountServerId { get; set; }

        public DateTime CreateTime { get; set; } = TimeManager.KoreaNow;

        [Key]
        public long StageUniqueId { get; set; }

        public long LastEnterStageEchelonNumber { get; set; }

        public List<ParcelInfo> StageEntranceFee { get; set; }

        public Dictionary<long, long> EnemyKillCountByUniqueId { get; set; }

        public long TacticClearTimeMscSum { get; set; }

        public long AccountLevelWhenCreateDB { get; set; }

        public string? BIEchelon { get; set; }

        public string? BIEchelon1 { get; set; }

        public string? BIEchelon2 { get; set; }

        public string? BIEchelon3 { get; set; }

        public string? BIEchelon4 { get; set; }

        public ContentSaveDB() { }
    }
}
