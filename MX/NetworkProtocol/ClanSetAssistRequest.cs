using FlatData;

namespace MX.NetworkProtocol
{
    public class ClanSetAssistRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_SetAssist; }
        }

        public EchelonType EchelonType { get; set; }

        public int SlotNumber { get; set; }

        public long CharacterDBId { get; set; }

        public int CombatStyleIndex { get; set; }

        public ClanSetAssistRequest() { }
    }
}
