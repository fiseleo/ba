using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CharacterBatchSkillLevelUpdateResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_BatchSkillLevelUpdate; }
        }

        public CharacterDB CharacterDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CharacterBatchSkillLevelUpdateResponse() { }
    }
}
