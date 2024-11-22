namespace MX.GameLogic.DBModel
{
    public class VisitingCharacterDB
    {
        public long UniqueId { get; set; }

        public long ServerId { get; set; }

        public override string ToString()
        {
            return null;
        }

        public bool Equals(VisitingCharacterDB other)
        {
            return default(bool);
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public VisitingCharacterDB() { }
    }
}
