using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    [Obsolete("MultiRaid")]
    public class RaidShareResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_Share; }
        }

        public RaidDB RaidDB { get; set; }

        public RaidShareResponse() { }
    }
}
