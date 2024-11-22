namespace MX.NetworkProtocol
{
    public class MissionSyncResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Mission_Sync; }
        }

        public MissionSyncResponse() { }
    }
}
