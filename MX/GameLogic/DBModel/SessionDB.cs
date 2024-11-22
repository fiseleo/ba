namespace MX.GameLogic.DBModel
{
    public class SessionDB
    {
        public SessionKey SessionKey { get; set; }

        public DateTime LastConnect { get; set; }

        public int ConnectionTime { get; set; }

        public SessionDB() { }
    }
}
