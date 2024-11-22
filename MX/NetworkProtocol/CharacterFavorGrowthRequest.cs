using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class CharacterFavorGrowthRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_FavorGrowth; }
        }

        public long TargetCharacterDBId { get; set; }

        public Dictionary<long, int> ConsumeItemDBIdsAndCounts { get; set; }

        public CharacterFavorGrowthRequest() { }
    }
}
