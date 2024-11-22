using MX.Logic.Skills;

// using MX.Logic.Skills.LogicEffects;

namespace MX.Logic.BattleEntities
{
    public class DebuffEventArgs : EventArgs
    {
        public EntityId InvokerId { get; }

        public string LogicEffectGroupId { get; }

        public string LogicEffectTemplateId { get; }

        public int Level { get; }

        public int DurationFrame { get; }

        public SkillSpecification SkillSpecification { get; }

        // public DebuffEventArgs(EntityId id, StatChangeEffect statChange, int level) { }
    }
}
