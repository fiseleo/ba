using System.Collections.Generic;

namespace MX.Campaign
{
    public class SkillCardHand
    {
        public float Cost { get; set; }

        public List<SkillCardInfo> SkillCardsInHand { get; set; }

        public SkillCardHand() { }

        public SkillCardHand Clone()
        {
            return null;
        }
    }
}
