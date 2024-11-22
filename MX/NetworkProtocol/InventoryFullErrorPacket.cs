using System.Collections.Generic;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class InventoryFullErrorPacket : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Error; }
        }

        public WebAPIErrorCode ErrorCode
        {
            get { return WebAPIErrorCode.InventoryAlreadyFull; }
        }

        public List<ParcelInfo> ParcelInfos { get; set; }

        public InventoryFullErrorPacket() { }
    }
}
