using FlatData;

namespace MX.GameLogic.DBModel
{
    public class CampaignExtraStageSaveDB : ContentSaveDB
    {
        public override ContentType ContentType
        {
            get { return ContentType.None; }
        }

        public CampaignExtraStageSaveDB() { }
    }
}
