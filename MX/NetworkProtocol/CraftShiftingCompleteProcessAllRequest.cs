namespace MX.NetworkProtocol
{
    public class CraftShiftingCompleteProcessAllRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_ShiftingCompleteProcessAll; }
        }

        public CraftShiftingCompleteProcessAllRequest() { }
    }
}
