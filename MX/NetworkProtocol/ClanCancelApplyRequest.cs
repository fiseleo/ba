namespace MX.NetworkProtocol
{
    public class ClanCancelApplyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_CancelApply; }
        }

        public ClanCancelApplyRequest() { }
    }
}
