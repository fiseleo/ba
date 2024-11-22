namespace MX.GameLogic.DBModel
{
    public class EliminateRaidUserDB : RaidUserDB
    {
        public Dictionary<string, long> BossGroupToRankingPoint;

        public override RaidUserDB Clone()
        {
            throw new NotImplementedException();
        }
    }
}
