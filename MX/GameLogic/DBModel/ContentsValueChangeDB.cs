using FlatData;

namespace MX.GameLogic.DBModel
{
    public abstract class ContentsValueChangeDB
    {
        public abstract ContentsChangeType ContentsChangeType { get; }

        protected ContentsValueChangeDB() { }
    }
}
