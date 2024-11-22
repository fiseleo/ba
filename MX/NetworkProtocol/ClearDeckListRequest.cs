using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ClearDeckListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ClearDeck_List; }
        }

        public ClearDeckKey ClearDeckKey { get; set; }

        public ClearDeckListRequest() { }
    }
}
