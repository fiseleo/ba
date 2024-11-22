using FlatData;

namespace MX.GameLogic.DBModel
{
    public class FieldStageSaveDB : ContentSaveDB
    {
        public override ContentType ContentType
        {
            get { return ContentType.None; }
        }

        public FieldStageSaveDB() { }
    }
}
