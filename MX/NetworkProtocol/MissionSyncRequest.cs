namespace MX.NetworkProtocol
{
    public class MissionSyncRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Mission_Sync; }
        }

        public MissionSyncRequest() { }
    }
}
