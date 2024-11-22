using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class TimeAttackDungeonSweepResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.TimeAttackDungeon_Sweep; }
        }

        public List<List<ParcelInfo>> Rewards { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public TimeAttackDungeonRoomDB RoomDB { get; set; }

        public TimeAttackDungeonSweepResponse() { }
    }
}
