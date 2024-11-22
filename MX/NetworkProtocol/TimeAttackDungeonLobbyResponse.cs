using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class TimeAttackDungeonLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.TimeAttackDungeon_Lobby; }
        }

        public Dictionary<long, TimeAttackDungeonRoomDB> RoomDBs { get; set; }

        public TimeAttackDungeonRoomDB PreviousRoomDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public bool AchieveSeasonBestRecord { get; set; }

        public long SeasonBestRecord { get; set; }

        public TimeAttackDungeonLobbyResponse() { }
    }
}
