using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.GameLogic.DBModel
{
    public class ClanAssistRewardInfo
    {
        public long CharacterDBId { get; set; }

        public DateTime DeployDate { get; set; }

        public long RentCount { get; set; }

        public List<ParcelInfo> CumultativeRewardParcels { get; set; }

        public List<ParcelInfo> RentRewardParcels { get; set; }

        public ClanAssistRewardInfo() { }
    }
}
