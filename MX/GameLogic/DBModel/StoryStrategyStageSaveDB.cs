using FlatData;
using MX.Data;

namespace MX.GameLogic.DBModel
{
    public class StoryStrategyStageSaveDB : CampaignMainStageSaveDB
    {
        public override ContentType ContentType
        {
            get { return ContentType.None; }
        }

        public StoryStrategyStageSaveDB() { }

        public StoryStrategyStageSaveDB(StoryStrategyStageSaveDB other) { }

        public override CampaignMainStageSaveDB Clone()
        {
            return null;
        }

        // public override CampaignStageInfo GetStageInfo()
        // {
        //     return null;
        // }
    }
}
