using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class AccountLoginSyncRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_LoginSync; }
        }

        public List<Protocol> SyncProtocols { get; set; }

        public AccountLoginSyncRequest() { }
    }
}
