namespace MX.NetworkProtocol
{
    public class ClanApplicantRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Applicant; }
        }

        public long OffSet { get; set; }

        public ClanApplicantRequest() { }
    }
}
