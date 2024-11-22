namespace MX.NetworkProtocol
{
    public class CharacterSetCostumeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_SetCostume; }
        }

        public long CharacterUniqueId { get; set; }

        public long? CostumeIdToSet { get; set; }

        public CharacterSetCostumeRequest() { }
    }
}
