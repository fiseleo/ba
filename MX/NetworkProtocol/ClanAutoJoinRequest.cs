namespace MX.NetworkProtocol
{
    public class ClanAutoJoinRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_AutoJoin; }
        }

        public ClanAutoJoinRequest() { }
    }
}
