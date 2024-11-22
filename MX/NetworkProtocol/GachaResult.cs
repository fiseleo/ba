using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class GachaResult
    {
        public long CharacterId { get; set; }

        public CharacterDB? Character { get; set; }

        public ItemDB? Stone { get; set; }

        public GachaResult(long id)
        {
            CharacterId = id;
        }

        public void SetCharacterDB(CharacterDB character)
        {
            Character = character;
        }

        public void SetStone(ItemDB parcel)
        {
            Stone = parcel;
        }
    }
}
