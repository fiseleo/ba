using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CharacterSkillLevelUpdateResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_UpdateSkillLevel; }
        }

        public CharacterDB CharacterDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CharacterSkillLevelUpdateResponse() { }
    }
}
