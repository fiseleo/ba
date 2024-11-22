namespace MX.GameLogic.DBModel
{
    public class ToastDB
    {
        public long UniqueId { get; set; }

        public string Text { get; set; }

        public string ToastId { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime EndDate { get; set; }

        public int LifeTime { get; set; }

        public int Delay { get; set; }

        public ToastDB() { }
    }
}
