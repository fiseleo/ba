namespace MX.NetworkProtocol
{
    public class ProofTokenRequestQuestionRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ProofToken_RequestQuestion; }
        }

        public ProofTokenRequestQuestionRequest() { }
    }
}
