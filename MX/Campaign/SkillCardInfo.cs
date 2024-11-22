namespace MX.Campaign
{
    public struct SkillCardInfo
    {
        public long CharacterId { readonly get; set; }

        public int HandIndex { readonly get; set; }

        public string SkillId { readonly get; set; }

        public int RemainCoolTime { readonly get; set; }
    }
}
