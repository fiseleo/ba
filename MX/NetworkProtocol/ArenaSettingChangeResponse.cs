namespace MX.NetworkProtocol
{
    public class ArenaSettingChangeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_SettingChange; }
        }

        public ArenaSettingChangeResponse() { }
    }
}
