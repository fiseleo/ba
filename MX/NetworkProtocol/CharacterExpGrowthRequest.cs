using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CharacterExpGrowthRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_ExpGrowth; }
        }

        public long TargetCharacterServerId { get; set; }

        public ConsumeRequestDB ConsumeRequestDB { get; set; }

        public CharacterExpGrowthRequest() { }
    }
}
