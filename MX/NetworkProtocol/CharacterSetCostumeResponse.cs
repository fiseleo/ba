using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CharacterSetCostumeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_SetCostume; }
        }

        public CostumeDB SetCostumeDB { get; set; }

        public CostumeDB UnsetCostumeDB { get; set; }

        public CharacterSetCostumeResponse() { }
    }
}
