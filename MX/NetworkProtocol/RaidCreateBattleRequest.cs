using System.Collections.Generic;
using FlatData;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class RaidCreateBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_CreateBattle; }
        }

        public long RaidUniqueId { get; set; }

        public bool IsPractice { get; set; }

        public List<int> Tags { get; set; }

        public bool IsPublic { get; set; }

        public Difficulty Difficulty { get; set; }

        public ClanAssistUseInfo AssistUseInfo { get; set; }

        public RaidCreateBattleRequest() { }
    }
}
