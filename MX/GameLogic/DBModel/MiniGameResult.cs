using FlatData;

namespace MX.GameLogic.DBModel
{
    public class MiniGameResult
    {
        public EventContentType ContentType
        {
            get { return EventContentType.Stage; }
        }

        public long EventContentId { get; set; }

        public long UniqueId { get; set; }

        public long TotalScore { get; private set; }

        public long ComboCount { get; private set; }

        public long FeverCount { get; private set; }

        public bool AllCombo { get; private set; }

        public long HPBonusScore { get; private set; }

        public long NoteCount { get; private set; }

        public long CriticalCount { get; private set; }

        public MiniGameResult(
            long eventContentId,
            long uniqueId,
            long totalScore,
            long comboCount,
            long feverCount,
            bool allCombo,
            long hpBonusScore,
            long noteCount,
            long criticalCount
        ) { }
    }
}
