namespace MX.NetworkProtocol
{
    [Flags]
    public enum ServerNotificationFlag
    {
        None = 0,

        NewMailArrived = 4,

        HasUnreadMail = 8,

        NewToastDetected = 16,

        CanReceiveArenaDailyReward = 32,

        CanReceiveRaidReward = 64,

        ServerMaintenance = 256,

        CannotReceiveMail = 512,

        InventoryFullRewardMail = 1024,

        CanReceiveClanAttendanceReward = 2048,

        HasClanApplicant = 4096,

        HasFriendRequest = 8192,

        CheckConquest = 16384,

        CanReceiveEliminateRaidReward = 32768,

        CanReceiveMultiFloorRaidReward = 65536
    }
}
