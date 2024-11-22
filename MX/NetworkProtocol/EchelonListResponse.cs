using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EchelonListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Echelon_List; }
        }

        public List<EchelonDB> EchelonDBs { get; set; }

        public EchelonDB ArenaEchelonDB { get; set; }

        public EchelonListResponse() { }
    }
}
