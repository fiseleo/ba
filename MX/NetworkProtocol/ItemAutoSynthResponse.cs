using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ItemAutoSynthResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Item_AutoSynth; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public ItemAutoSynthResponse() { }
    }
}
