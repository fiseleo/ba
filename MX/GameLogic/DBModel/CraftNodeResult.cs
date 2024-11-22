using FlatData;
using MX.GameLogic.Parcel;

namespace MX.GameLogic.DBModel
{
    public class CraftNodeResult
    {
        public CraftNodeTier NodeTier { get; set; }

        public ParcelInfo ParcelInfo { get; set; }

        public CraftNodeResult() { }
    }
}
