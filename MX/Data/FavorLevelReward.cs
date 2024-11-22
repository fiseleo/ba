using System.Collections.Generic;
using FlatData;
using MX.GameLogic.Parcel;

namespace MX.Data
{
    public class FavorLevelReward
    {
        public long CharacterId { get; set; }

        public long FavorLevel { get; set; }

        public List<ValueTuple<EquipmentOptionType, long>> AddedStats { get; }

        public List<ParcelInfo> RewardParcels { get; }

        public FavorLevelReward(FavorLevelRewardExcel excel) { }
    }
}
