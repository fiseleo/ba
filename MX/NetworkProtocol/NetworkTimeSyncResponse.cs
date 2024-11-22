namespace MX.NetworkProtocol
{
    public class NetworkTimeSyncResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.NetworkTime_Sync; }
        }

        public long ReceiveTick { get; set; }

        public long EchoSendTick { get; set; }

        public NetworkTimeSyncResponse() { }
    }
}
