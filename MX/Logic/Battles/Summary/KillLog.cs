using MX.Logic.BattleEntities;

namespace MX.Logic.Battles.Summary
{
    [Serializable]
    public struct KillLog : IEquatable<KillLog>
    {
        public int Frame { get; set; }
        public EntityId EntityId { get; set; }

        public bool Equals(KillLog other)
        {
            return EntityId.Equals(other.EntityId);
        }
    }
}
