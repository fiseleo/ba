using System.Collections.Generic;
using FlatData;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class ArenaTeamSettingDB
    {
        public EchelonType EchelonType { get; set; }

        public long LeaderCharacterId { get; set; }

        public long TSSInteractionCharacterId { get; set; }

        [JsonIgnore]
        public long TSSInteractionCharacterServerId
        {
            get { return 0L; }
        }

        public IList<ArenaCharacterDB> MainCharacters { get; set; }

        public IList<ArenaCharacterDB> SupportCharacters { get; set; }

        public ArenaCharacterDB TSSCharacterDB { get; set; }

        [JsonIgnore]
        public int SquadCount
        {
            get { return 0; }
        }

        public long MapId { get; set; }

        public ArenaTeamSettingDB() { }

        public bool CanBattle()
        {
            return default(bool);
        }
    }
}
