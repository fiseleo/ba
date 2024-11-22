using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public abstract class BasePacket
    {
        public SessionKey? SessionKey { get; set; }
        public abstract Protocol Protocol { get; }
        public long AccountId => SessionKey?.AccountServerId ?? 0;
    }
}
