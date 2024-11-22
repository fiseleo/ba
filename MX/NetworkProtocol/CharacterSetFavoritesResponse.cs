using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CharacterSetFavoritesResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_SetFavorites; }
        }

        public List<CharacterDB> CharacterDBs { get; set; }

        public CharacterSetFavoritesResponse() { }
    }
}
