namespace MX.NetworkProtocol
{
    public class MiniGameMissionListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MiniGame_MissionList; }
        }

        public long EventContentId { get; set; }

        public MiniGameMissionListRequest() { }
    }
}
