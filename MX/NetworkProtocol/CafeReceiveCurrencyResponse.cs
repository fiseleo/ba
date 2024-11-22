using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CafeReceiveCurrencyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_ReceiveCurrency; }
        }

        public CafeDB CafeDB { get; set; }

        public List<CafeDB> CafeDBs { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CafeReceiveCurrencyResponse() { }
    }
}
