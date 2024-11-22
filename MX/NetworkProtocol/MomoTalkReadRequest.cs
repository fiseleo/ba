namespace MX.NetworkProtocol
{
    public class MomoTalkReadRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MomoTalk_Read; }
        }

        public long CharacterDBId { get; set; }

        public long LastReadMessageGroupId { get; set; }

        public long? ChosenMessageId { get; set; }

        public MomoTalkReadRequest() { }
    }
}
