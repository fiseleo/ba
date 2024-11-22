using Newtonsoft.Json;

namespace MX.Logic.BattleEntities
{
    [Serializable]
    public struct EntityId : IComparable, IComparable<EntityId>, IEquatable<EntityId>
    {
        // Fields
        private const uint typeMask = 4278190080;
        private const int instanceIdMask = 16777215;

        [JsonProperty]
        private int uniqueId;

        // Properties
        public static EntityId Invalid { get; }

        [JsonIgnore]
        public BattleEntityType EntityType { get; }

        [JsonIgnore]
        public int InstanceId { get; }

        [JsonIgnore]
        public int UniqueId { get; }

        [JsonIgnore]
        public bool IsValid { get; }

        // Methods


        public static EntityId Parse(string value)
        {
            var id = int.Parse(value);
            return new EntityId(id);
        }

        [JsonConstructor]
        private EntityId(int id)
        {
            uniqueId = id;
        }

        public int CompareTo(object? obj)
        {
            // TODO
            return 1;
        }

        public int CompareTo(EntityId other)
        {
            // TODO
            return uniqueId - other.uniqueId;
        }

        public bool Equals(EntityId other)
        {
            // TODO
            return uniqueId == other.uniqueId;
        }

        public override string ToString()
        {
            return uniqueId.ToString();
        }
    }
}
