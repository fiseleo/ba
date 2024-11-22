namespace MX.GameLogic.DBModel
{
    public class BanDB
    {
        public long ServerId { get; set; }

        public long UniqueId { get; set; }

        public DateTime BanStartDate { get; set; }

        public DateTime BanEndDate { get; set; }

        public DateTime RegisterDate { get; set; }

        public byte CancelFlag { get; set; }

        public DateTime CancelDate { get; set; }

        public string Reason { get; set; }

        public BanDB() { }
    }
}
