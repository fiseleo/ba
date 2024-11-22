namespace MX.NetworkProtocol
{
    public class RaidGiveUpRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_GiveUp; }
        }

        public long RaidServerId { get; set; }

        public bool IsPractice { get; set; }

        public RaidGiveUpRequest() { }
    }
}
