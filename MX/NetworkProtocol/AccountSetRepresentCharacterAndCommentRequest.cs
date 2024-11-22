namespace MX.NetworkProtocol
{
    public class AccountSetRepresentCharacterAndCommentRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_SetRepresentCharacterAndComment; }
        }

        public long RepresentCharacterServerId { get; set; }

        public string Comment { get; set; }

        public AccountSetRepresentCharacterAndCommentRequest() { }
    }
}
