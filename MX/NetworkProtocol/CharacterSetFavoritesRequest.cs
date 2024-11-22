using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class CharacterSetFavoritesRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_SetFavorites; }
        }

        public Dictionary<long, bool> ActivateByServerIds { get; set; }

        public CharacterSetFavoritesRequest() { }
    }
}
