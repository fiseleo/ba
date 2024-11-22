using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class RaidParticipateCharactersDB
    {
        public long RaidServerId { get; set; }

        public long AccountServerId { get; set; }

        public List<long> ParticipateCharacterServerIds { get; set; } = [];

        public bool ShouldSerializeParticipateCharacterServerIds()
        {
            return ParticipateCharacterServerIds.Count > 0;
        }

        public RaidParticipateCharactersDB() { }
    }
}
