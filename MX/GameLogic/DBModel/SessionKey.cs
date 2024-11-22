namespace MX.GameLogic.DBModel
{
    public class SessionKey
    {
        public long AccountServerId { get; set; }
        public required string MxToken { get; set; }
    }
}
