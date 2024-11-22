namespace MX.NetworkProtocol
{
    public class ProofTokenRequestQuestionResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ProofToken_RequestQuestion; }
        }

        public ProofTokenRequestQuestionResponse() { }

        public long Hint;

        public string Question;
    }
}
