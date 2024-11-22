using MX.Logic.BattleEntities;

namespace MX.Logic.Data
{
    public struct DebuffDescription : IEquatable<DebuffDescription>
    {
        public long AccountId { readonly get; set; }

        public string LogicEffectTemplateId { readonly get; set; }

        public string LogicEffectGroupId { readonly get; set; }

        public int LogicEffectLevel { readonly get; set; }

        public int DurationFrame { readonly get; set; }

        public SkillSlot SkillSlot { readonly get; set; }

        public int IssuedTimestamp { readonly get; set; }

        public bool IsValid(int currentTimestamp)
        {
            return default(bool);
        }

        public DebuffDescription(DebuffDescription description, int timestamp) { }

        public DebuffDescription(long accountId, DebuffEventArgs data, int level) { }

        public bool Equals(DebuffDescription other)
        {
            return default(bool);
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public static bool operator ==(DebuffDescription left, DebuffDescription right)
        {
            return default(bool);
        }

        public static bool operator !=(DebuffDescription left, DebuffDescription right)
        {
            return default(bool);
        }
    }
}
