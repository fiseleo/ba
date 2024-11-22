using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CharacterTranscendenceResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_Transcendence; }
        }

        public CharacterDB CharacterDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CharacterTranscendenceResponse() { }
    }
}
