namespace MX.NetworkProtocol
{
    public class CharacterGearUnlockRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.CharacterGear_Unlock; }
        }

        public long CharacterServerId { get; set; }

        public int SlotIndex { get; set; }

        public CharacterGearUnlockRequest() { }
    }
}
