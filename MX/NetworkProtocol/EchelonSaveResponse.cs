using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EchelonSaveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Echelon_Save; }
        }

        public EchelonDB EchelonDB { get; set; }

        public EchelonSaveResponse() { }
    }
}
