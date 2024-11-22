using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class OpenConditionSetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.OpenCondition_Set; }
        }

        public OpenConditionDB ConditionDB { get; set; }

        public OpenConditionSetRequest() { }
    }
}
