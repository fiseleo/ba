namespace MX.NetworkProtocol
{
    public class ProofTokenSubmitRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ProofToken_Submit; }
        }

        public ProofTokenSubmitRequest() { }

        public long Answer;
    }
}
