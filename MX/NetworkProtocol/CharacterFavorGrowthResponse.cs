using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CharacterFavorGrowthResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_FavorGrowth; }
        }

        public CharacterDB CharacterDB { get; set; }

        public List<ItemDB> ConsumeStackableItemDBResult { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CharacterFavorGrowthResponse() { }
    }
}
