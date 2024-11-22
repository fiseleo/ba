// using MX.Data.Excel;

namespace MX.Data
{
    public class EventContentTreasureInfo
    {
        public long EventContentId { get; }

        public int LoopRound { get; }

        public string TitleLocalize { get; }

        public string TreasureBGImagePath { get; }

        public bool IsLoop(int round)
        {
            return default(bool);
        }

        public int MetaRound(int round)
        {
            return 0;
        }

        // public EventContentTreasureInfo(EventContentTreasureExcel excel) { }
    }
}
