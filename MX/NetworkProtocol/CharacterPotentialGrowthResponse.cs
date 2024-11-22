using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CharacterPotentialGrowthResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_PotentialGrowth; }
        }

        public CharacterDB CharacterDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CharacterPotentialGrowthResponse() { }
    }
}
