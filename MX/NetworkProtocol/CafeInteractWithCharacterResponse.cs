using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CafeInteractWithCharacterResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_Interact; }
        }

        public CafeDB CafeDB { get; set; }

        public CharacterDB CharacterDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CafeInteractWithCharacterResponse() { }
    }
}
