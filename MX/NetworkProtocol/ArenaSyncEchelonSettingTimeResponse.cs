namespace MX.NetworkProtocol
{
    public class ArenaSyncEchelonSettingTimeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_SyncEchelonSettingTime; }
        }

        public DateTime EchelonSettingTime { get; set; }

        public ArenaSyncEchelonSettingTimeResponse() { }
    }
}
