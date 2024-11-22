using MX.Data;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class ConquestErosionDB : ConquestEventObjectDB
    {
        public override ConquestEventObjectType ObjectType
        {
            get { return ConquestEventObjectType.None; }
        }

        [JsonIgnore]
        public long ErosionId
        {
            get { return 0L; }
        }

        public long ConditionSnapshot { get; set; }

        public DateTime CreateDate { get; set; }

        [Obsolete]
        public bool CanInteract(ConquestInfoDB infoDB)
        {
            return default(bool);
        }

        [Obsolete]
        public long GetConditionValue(ConquestInfoDB infoDB)
        {
            return 0L;
        }

        public override void CopyFrom(ConquestEventObjectDB other) { }

        public override ConquestEventObjectDB Clone()
        {
            return null;
        }

        public ConquestErosionDB() { }
    }
}
