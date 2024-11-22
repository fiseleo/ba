using FlatData;

namespace MX.GameLogic.DBModel
{
    public class EventContentSubStageSaveDB : CampaignSubStageSaveDB
    {
        public override ContentType ContentType
        {
            get { return ContentType.None; }
        }

        public EventContentSubStageSaveDB() { }
    }
}
