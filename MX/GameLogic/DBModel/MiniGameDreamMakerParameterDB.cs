using FlatData;

namespace MX.GameLogic.DBModel
{
    public class MiniGameDreamMakerParameterDB
    {
        public DreamMakerParameterType ParameterType { get; set; }

        public long BaseAmount { get; set; }

        public long CurrentAmount { get; set; }

        public MiniGameDreamMakerParameterDB Clone()
        {
            return null;
        }

        public MiniGameDreamMakerParameterDB() { }
    }
}
