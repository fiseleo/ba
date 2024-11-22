using FlatData;

namespace MX.NetworkProtocol
{
    [Obsolete("MultiRaid")]
    public class RaidListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_List; }
        }

        public string RaidBossGroup { get; set; }

        public Difficulty RaidDifficulty { get; set; }

        public RaidRoomSortOption RaidRoomSortOption { get; set; }

        public RaidListRequest() { }
    }
}
