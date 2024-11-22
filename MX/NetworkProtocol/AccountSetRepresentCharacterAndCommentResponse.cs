using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class AccountSetRepresentCharacterAndCommentResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_SetRepresentCharacterAndComment; }
        }

        public AccountDB AccountDB { get; set; }

        public CharacterDB RepresentCharacterDB { get; set; }

        public AccountSetRepresentCharacterAndCommentResponse() { }
    }
}
