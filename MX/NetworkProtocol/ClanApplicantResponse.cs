using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ClanApplicantResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Applicant; }
        }

        public List<ClanMemberDB> ClanMemberDBs { get; set; }

        public ClanApplicantResponse() { }
    }
}
