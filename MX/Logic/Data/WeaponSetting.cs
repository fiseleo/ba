using Newtonsoft.Json;

namespace MX.Logic.Data
{
    public struct WeaponSetting : IEquatable<WeaponSetting>
    {
        public const int InvalidId = -1;

        [JsonIgnore]
        public bool IsValid { get; }
        public long UniqueId { get; set; }
        public int StarGrade { get; set; }
        public int Level { get; set; }

        public bool Equals(WeaponSetting other)
        {
            return UniqueId == other.UniqueId;
        }
    }
}
