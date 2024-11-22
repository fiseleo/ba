namespace MX.NetworkProtocol
{
    public class ClanCancelApplyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_CancelApply; }
        }

        public ClanCancelApplyResponse() { }
    }
}
