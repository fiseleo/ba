using FlatData;
using MX.Core.Math;

namespace MX.GameLogic.DBModel
{
    public class WorldRaidBossDamageRatio : ContentsValueChangeDB
    {
        public override ContentsChangeType ContentsChangeType
        {
            get { return ContentsChangeType.None; }
        }

        public BasisPoint DamageRatio { get; set; }

        public WorldRaidBossDamageRatio() { }
    }
}
