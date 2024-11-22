using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CharacterListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Character_List; }
        }

        public List<CharacterDB> CharacterDBs { get; set; }

        public List<CharacterDB> TSSCharacterDBs { get; set; }

        public List<WeaponDB> WeaponDBs { get; set; }

        public List<CostumeDB> CostumeDBs { get; set; }

        public CharacterListResponse() { }
    }
}
