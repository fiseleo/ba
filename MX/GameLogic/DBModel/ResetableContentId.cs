using FlatData;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public struct ResetableContentId : IEquatable<ResetableContentId>
    {
        [JsonProperty]
        public ResetContentType Type { readonly get; private set; }

        [JsonProperty]
        public long Mapped { readonly get; private set; }

        public ResetableContentId(long mapped) { }

        public ResetableContentId(ResetContentType type, long idToCombine = 0L) { }

        public static bool operator ==(ResetableContentId lhs, ResetableContentId rhs)
        {
            return default(bool);
        }

        public static bool operator !=(ResetableContentId lhs, ResetableContentId rhs)
        {
            return default(bool);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public bool Equals(ResetableContentId other)
        {
            return default(bool);
        }
    }
}
