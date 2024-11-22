using BA.Utils;
using FlatData;
using MX.GameLogic.DBModel;
using MX.GameLogic.Service;

namespace MX.NetworkProtocol
{
    public abstract class ResponsePacket : BasePacket
    {
        public long ServerTimeTicks { get; set; } = TimeManager.KoreaNow.Ticks;
        public ServerNotificationFlag ServerNotification { get; set; }
        public List<MissionProgressDB> MissionProgressDBs { get; set; }
        public Dictionary<long, List<MissionProgressDB>> EventMissionProgressDBDict { get; set; }
        public Dictionary<
            OpenConditionContent,
            OpenConditionLockReason
        > StaticOpenConditions { get; set; }
    }
}
