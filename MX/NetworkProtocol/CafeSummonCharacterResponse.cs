using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CafeSummonCharacterResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_SummonCharacter; }
        }

        public CafeDB CafeDB { get; set; }

        public List<CafeDB> CafeDBs { get; set; }

        public CafeSummonCharacterResponse() { }
    }
}
