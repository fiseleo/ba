using System.Collections.Generic;
// using MX.Data.Excel;
using MX.GameLogic.Parcel;

namespace MX.Data
{
    public class EventContentTreasureRoundInfo
    {
        public long EventContentId { get; }

        public int Round { get; }

        public long CostGoodsId { get; }

        public long CellRewardId { get; }

        public int BoardSizeX { get; }

        public int BoardSizeY { get; }

        // public List<EventContentTreasureItem> Treasures { get; }

        public List<ParcelInfo> CellRewards { get; }

        public List<ParcelInfo> CellCosts { get; }

        public bool IsVisualSortUnstructed { get; set; }

        public int TreasureTotalCount
        {
            get { return 0; }
        }

        public int TreasureItemAmount(long rewardId)
        {
            return 0;
        }

        // public EventContentTreasureRoundInfo(
        //     EventContentTreasureRoundExcel excel,
        //     List<ParcelInfo> rewards,
        //     List<ParcelInfo> costs,
        //     List<EventContentTreasureItem> treasures
        // ) { }
    }
}
