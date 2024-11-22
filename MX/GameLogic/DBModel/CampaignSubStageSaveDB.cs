using FlatData;

namespace MX.GameLogic.DBModel
{
    public class CampaignSubStageSaveDB : ContentSaveDB
    {
        public override ContentType ContentType
        {
            get { return ContentType.CampaignSubStage; }
        }

        public CampaignSubStageSaveDB() { }
    }
}
