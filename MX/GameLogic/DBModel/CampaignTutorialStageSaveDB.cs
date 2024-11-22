using FlatData;

namespace MX.GameLogic.DBModel
{
    public class CampaignTutorialStageSaveDB : ContentSaveDB
    {
        public override ContentType ContentType
        {
            get { return ContentType.None; }
        }

        public CampaignTutorialStageSaveDB() { }
    }
}
