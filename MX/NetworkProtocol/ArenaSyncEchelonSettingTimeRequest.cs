namespace MX.NetworkProtocol
{
    public class ArenaSyncEchelonSettingTimeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_SyncEchelonSettingTime; }
        }

        public ArenaSyncEchelonSettingTimeRequest() { }
    }
}
