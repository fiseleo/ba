namespace MX.NetworkProtocol
{
    public class ProofTokenSubmitResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ProofToken_Submit; }
        }

        public ProofTokenSubmitResponse() { }
    }
}
