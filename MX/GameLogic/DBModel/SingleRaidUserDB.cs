namespace MX.GameLogic.DBModel
{
    public class SingleRaidUserDB : RaidUserDB
    {
        public RaidTeamSettingDB RaidTeamSettingDB { get; set; }

        public SingleRaidUserDB() { }

        public override RaidUserDB Clone()
        {
            return null;
        }
    }
}
