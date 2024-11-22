using System.Collections.Generic;
using FlatData;
using MX.GameLogic.Parcel;

namespace MX.Data
{
    public class CampaignChapterRewardInfo
    {
        public List<ParcelInfo> ParcelInfos { get; private set; }

        public long CampaignChapterStar { get; set; }

        public CampaignChapterRewardInfo(CampaignChapterRewardExcel excel) { }
    }
}
