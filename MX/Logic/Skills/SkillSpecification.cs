using MX.Logic.BattleEntities;

namespace MX.Logic.Skills
{
    public class SkillSpecification
    {
        public string SkillGroupId { get; }

        public int SkillLevel { get; }

        public string SkillDataKey { get; }

        public string VisualDataKey { get; }

        public SkillSlot SkillSlot { get; }

        public SkillType SkillType { get; }

        public SkillSpecification(
            string skillGroupId,
            string skillDataKey,
            string visualDataKey,
            int skillLevel,
            SkillSlot skillSlot
        ) { }

        public SkillSpecification Clone()
        {
            return null;
        }
    }
}
