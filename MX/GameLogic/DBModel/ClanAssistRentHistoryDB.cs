namespace MX.GameLogic.DBModel
{
    public class ClanAssistRentHistoryDB
    {
        public long AssistCharacterAccountId { get; set; }

        public long AssistCharacterDBId { get; set; }

        public DateTime RentDate { get; set; }

        public long AssistCharacterId { get; set; }

        public bool IsRentAvailable(DateTime serverTime)
        {
            return default(bool);
        }

        public ClanAssistRentHistoryDB CloneWithEncodedCharacterDBId(long shardId)
        {
            return null;
        }

        public ClanAssistRentHistoryDB() { }
    }
}
