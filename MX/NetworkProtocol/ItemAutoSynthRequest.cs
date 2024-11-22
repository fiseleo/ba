using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ItemAutoSynthRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Item_AutoSynth; }
        }

        public List<ParcelKeyPair> TargetParcels { get; set; }

        public ItemAutoSynthRequest() { }
    }
}
