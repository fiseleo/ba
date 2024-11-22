using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CharacterGearUnlockResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.CharacterGear_Unlock; }
        }

        public GearDB GearDB { get; set; }

        public CharacterDB CharacterDB { get; set; }

        public CharacterGearUnlockResponse() { }
    }
}
