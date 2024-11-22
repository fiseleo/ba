using FlatData;

namespace MX.GameLogic.DBModel
{
    public class EventContentMainGroundStageSaveDB : CampaignSubStageSaveDB
    {
        public override ContentType ContentType
        {
            get { return ContentType.EventContentMainGroundStage; }
        }

        public EventContentMainGroundStageSaveDB() { }
    }
}
