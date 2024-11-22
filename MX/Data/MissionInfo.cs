using System.Collections.Generic;
using FlatData;
using MX.GameLogic.Parcel;

namespace MX.Data
{
    public class MissionInfo : IMissionConstraint
    {
        public virtual bool CanComplete(DateTime serverTime)
        {
            return default(bool);
        }

        public virtual bool CanReceiveReward(DateTime serverTime)
        {
            return default(bool);
        }

        public override string ToString()
        {
            return null;
        }

        public MissionInfo() { }

        public MissionInfo(MissionExcel excel) { }

        public long Id { get; set; }

        public MissionCategory Category { get; set; }

        public MissionResetType ResetType { get; set; }

        public MissionToastDisplayConditionType ToastDisplayType { get; set; }

        public uint Description { get; set; }

        public bool IsVisible { get; set; }

        public bool IsLimited { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime StartableEndDate { get; set; }

        public DateTime EndDate { get; set; }

        public long EndDday { get; set; }

        public AccountState AccountState { get; set; }

        public long AccountLevel { get; set; }

        public List<long> PreMissionIds { get; set; }

        public long NextMissionId { get; set; }

        public SuddenMissionContentType[] SuddenMissionContentTypes { get; set; }

        public MissionCompleteConditionType CompleteConditionType { get; set; }

        public long CompleteConditionCount { get; set; }

        public List<long> CompleteConditionParameters { get; set; }

        public string RewardIcon { get; set; }

        public List<ParcelInfo> Rewards { get; set; }

        public ContentType DateAutoRefer { get; set; }

        public MissionInfo Clone()
        {
            return null;
        }

        public MissionInfo Resolve(DateTime serverTime)
        {
            return null;
        }

        // public bool TryResolve(DateTime serverTime, out MissionInfo resolved)
        // {
        //     return default(bool);
        // }

        public string ToastImagePath { get; set; }

        public long DisplayOrder { get; set; }

        public bool HasFollowingMission { get; set; }

        public string[] Shortcuts { get; set; }

        public long ChallengeStageId { get; set; }
    }
}
