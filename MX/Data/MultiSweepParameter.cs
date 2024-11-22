using FlatData;

namespace MX.Data
{
    public class MultiSweepParameter
    {
        public MultiSweepParameter() { }

        public MultiSweepParameter(ContentType contentType, long stageId, int sweepCount) { }

        public MultiSweepParameter(
            long eventContentId,
            ContentType contentType,
            long stageId,
            int sweepCount
        ) { }

        public long? EventContentId;

        public ContentType ContentType;

        public long StageId;

        public int SweepCount;
    }
}
