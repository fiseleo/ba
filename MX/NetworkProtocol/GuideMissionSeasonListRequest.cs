namespace MX.NetworkProtocol
{
    public class GuideMissionSeasonListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Mission_GuideMissionSeasonList; }
        }

        public GuideMissionSeasonListRequest() { }
    }
}
