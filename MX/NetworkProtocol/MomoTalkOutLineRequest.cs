namespace MX.NetworkProtocol
{
    public class MomoTalkOutLineRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MomoTalk_OutLine; }
        }

        public MomoTalkOutLineRequest() { }
    }
}
