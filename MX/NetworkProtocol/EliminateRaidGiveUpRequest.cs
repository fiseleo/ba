namespace MX.NetworkProtocol
{
    public class EliminateRaidGiveUpRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_GiveUp; }
        }

        public long RaidServerId { get; set; }

        public bool IsPractice { get; set; }

        public EliminateRaidGiveUpRequest() { }
    }
}
