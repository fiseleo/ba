using FlatData;

namespace MX.GameLogic.DBModel
{
    public class ConquestEchelonDB
    {
        public long EventContentId { get; set; }

        public StageDifficulty Difficulty { get; set; }

        public long TileUniqueId { get; set; }

        public EchelonDB EchelonDB { get; set; }

        public long AssistCharacterUniqueId { get; set; }

        public ClanAssistUseInfo AssistUseInfo { get; set; }

        public ConquestEchelonDB Clone()
        {
            return null;
        }

        public void CopyFrom(ConquestEchelonDB other) { }

        public void ResetAssist() { }

        public void SetAssist(
            ClanAssistUseInfo assistUseInfo,
            AssistCharacterDB assistCharacterDB
        ) { }

        public ConquestEchelonDB() { }
    }
}
