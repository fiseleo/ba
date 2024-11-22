using FlatData;
using MX.Data;

namespace MX.GameLogic.DBModel
{
    public abstract class ConquestEventObjectDB
    {
        public long ConquestObjectDBId { get; set; }

        public long EventContentId { get; set; }

        public StageDifficulty Difficulty { get; set; }

        public long TileUniqueId { get; set; }

        public long ObjectId { get; set; }

        public virtual ConquestEventObjectType ObjectType
        {
            get { return ConquestEventObjectType.None; }
        }

        public bool IsAlive { get; set; }

        public virtual void CopyFrom(ConquestEventObjectDB other) { }

        public abstract ConquestEventObjectDB Clone();

        protected static T CreateBaseClone<T>(T original)
            where T : ConquestEventObjectDB, new()
        {
            return null;
        }

        protected ConquestEventObjectDB() { }
    }
}
