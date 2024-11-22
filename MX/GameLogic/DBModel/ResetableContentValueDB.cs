using System.Runtime.InteropServices;

namespace MX.GameLogic.DBModel
{
    public class ResetableContentValueDB : IEquatable<ResetableContentValueDB>
    {
        public ResetableContentId ResetableContentId { get; set; }

        public long ContentValue { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public ResetableContentValueDB() { }

        public ResetableContentValueDB(ResetableContentValueDB resetableDB) { }

        public ResetableContentValueDB Clone()
        {
            return null;
        }

        // public bool Update(
        //     DateTime serverTime,
        //     long rawAmount,
        //     out long rewardAmount,
        //     [Optional] long? eventContentId
        // )
        // {
        //     return default(bool);
        // }

        public void ResetValue(DateTime serverTime) { }

        private long MaximumAmount([Optional] long? eventContentId)
        {
            return 0L;
        }

        private bool NeedToResetTime(DateTime serverTime)
        {
            return default(bool);
        }

        public bool Equals(ResetableContentValueDB other)
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
    }
}
