using MX.Data;

namespace MX.GameLogic.DBModel
{
    public class ConquestTreasureBoxDB : ConquestEventObjectDB
    {
        public override ConquestEventObjectType ObjectType
        {
            get { return ConquestEventObjectType.None; }
        }

        public override ConquestEventObjectDB Clone()
        {
            return null;
        }

        public ConquestTreasureBoxDB() { }
    }
}
