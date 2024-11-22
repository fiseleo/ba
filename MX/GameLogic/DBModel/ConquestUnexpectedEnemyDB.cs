using MX.Data;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class ConquestUnexpectedEnemyDB : ConquestEventObjectDB
    {
        [JsonIgnore]
        public long UnitId
        {
            get { return 0L; }
        }

        public override ConquestEventObjectType ObjectType
        {
            get { return ConquestEventObjectType.None; }
        }

        public override ConquestEventObjectDB Clone()
        {
            return null;
        }

        public ConquestUnexpectedEnemyDB() { }
    }
}
