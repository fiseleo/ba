using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class ClanMemberDescriptionDB
    {
        public long Exp { get; set; }

        public string Comment { get; set; }

        public int CollectedCharactersCount { get; set; }

        public long ArenaSeasonBestRanking { get; set; }

        public long ArenaSeasonCurrentRanking { get; set; }

        public ClanMemberDescriptionDB() { }

        public ClanMemberDescriptionDB(
            AccountDB accountDB,
            IEnumerable<CharacterDB> characterDBs,
            long bestRanking,
            long currentRanking
        ) { }
    }
}
