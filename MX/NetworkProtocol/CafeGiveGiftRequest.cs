using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CafeGiveGiftRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_GiveGift; }
        }

        public long CafeDBId { get; set; }

        public long CharacterUniqueId { get; set; }

        public ConsumeRequestDB ConsumeRequestDB { get; set; }

        public CafeGiveGiftRequest() { }
    }
}
