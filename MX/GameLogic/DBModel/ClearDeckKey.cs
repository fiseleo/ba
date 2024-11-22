using FlatData;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public struct ClearDeckKey : IEquatable<ClearDeckKey>
    {
        [JsonProperty]
        public ContentType ContentType { readonly get; private set; }

        [JsonProperty]
        public long[] Arguments { readonly get; private set; }

        public ClearDeckKey(ContentType contentType, params long[] args) { }

        public static ClearDeckKey WorldRaid(long seasonId, long groupId, long stageId)
        {
            return default(ClearDeckKey);
        }

        public static ClearDeckKey TimeAttackDungeon(long seasonId, long geasId)
        {
            return default(ClearDeckKey);
        }

        public static ClearDeckKey EventContentChallengeMainGround(
            long eventContentId,
            long stageId
        )
        {
            return default(ClearDeckKey);
        }

        public static ClearDeckKey WeekDungeon(long stageId)
        {
            return default(ClearDeckKey);
        }

        public static ClearDeckKey Chaser(long stageId)
        {
            return default(ClearDeckKey);
        }

        public static ClearDeckKey SchoolDungeon(long stageId)
        {
            return default(ClearDeckKey);
        }

        public static ClearDeckKey FieldContentStage(long seasonId, long stageId)
        {
            return default(ClearDeckKey);
        }

        public static ClearDeckKey MultiFloorRaid(long seasonId, long stageId)
        {
            return default(ClearDeckKey);
        }

        public static bool operator ==(ClearDeckKey a, ClearDeckKey b)
        {
            return default(bool);
        }

        public static bool operator !=(ClearDeckKey a, ClearDeckKey b)
        {
            return default(bool);
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public bool Equals(ClearDeckKey other)
        {
            return default(bool);
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
