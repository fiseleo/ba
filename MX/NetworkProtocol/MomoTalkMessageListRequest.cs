namespace MX.NetworkProtocol
{
    public class MomoTalkMessageListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MomoTalk_MessageList; }
        }

        public long CharacterDBId { get; set; }

        public MomoTalkMessageListRequest() { }
    }
}
