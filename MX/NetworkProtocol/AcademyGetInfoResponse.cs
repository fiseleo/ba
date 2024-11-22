using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class AcademyGetInfoResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Academy_GetInfo; }
        }

        public AcademyDB AcademyDB { get; set; }

        public List<AcademyLocationDB> AcademyLocationDBs { get; set; }

        public AcademyGetInfoResponse() { }
    }
}
