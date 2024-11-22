using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class CharacterWeaponExpGrowthRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_WeaponExpGrowth; }
        }

        public long TargetCharacterServerId { get; set; }

        public Dictionary<long, long> ConsumeUniqueIdAndCounts { get; set; }

        public CharacterWeaponExpGrowthRequest() { }
    }
}
