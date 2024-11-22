namespace MX.NetworkProtocol
{
    public class ArenaSettingChangeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_SettingChange; }
        }

        public long MapId { get; set; }

        public ArenaSettingChangeRequest() { }
    }
}
