namespace MX.GameLogic.DBModel
{
    public abstract class RaidUserDB : ICloneable
    {
        public long AccountId { get; set; }

        public long RepresentCharacterUniqueId { get; set; }

        public long RepresentCharacterCostumeId { get; set; }

        public long Level { get; set; }

        public string Nickname { get; set; }

        public int Tier { get; set; }

        public long Rank { get; set; }

        public long BestRankingPoint { get; set; }

        public double BestRankingPointDetail { get; set; }

        public AccountAttachmentDB AccountAttachmentDB { get; set; }

        public abstract RaidUserDB Clone();

        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }
    }
}
