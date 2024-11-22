using FlatData;

namespace MX.GameLogic.DBModel
{
    public class EventContentStoryStageSaveDB : CampaignSubStageSaveDB
    {
        public override ContentType ContentType
        {
            get { return ContentType.EventContentStoryStage; }
        }

        public EventContentStoryStageSaveDB() { }
    }
}
