namespace MX.NetworkProtocol
{
    public class CraftCompleteProcessAllRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_CompleteProcessAll; }
        }

        public CraftCompleteProcessAllRequest() { }
    }
}
