namespace MX.NetworkProtocol
{
    public class OpenConditionListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.OpenCondition_List; }
        }

        public OpenConditionListRequest() { }
    }
}
