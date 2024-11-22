namespace MX.NetworkProtocol
{
    public class NetworkTimeSyncRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.NetworkTime_Sync; }
        }

        public NetworkTimeSyncRequest() { }
    }
}
