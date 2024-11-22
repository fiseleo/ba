namespace MX.NetworkProtocol
{
    public class ClanPermitRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Permit; }
        }

        public long ApplicantAccountId { get; set; }

        public bool IsPerMit { get; set; }

        public ClanPermitRequest() { }
    }
}
