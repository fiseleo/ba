using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CafeApplyTemplateResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_ApplyTemplate; }
        }

        public List<CafeDB> CafeDBs { get; set; }

        public List<FurnitureDB> FurnitureDBs { get; set; }

        public CafeApplyTemplateResponse() { }
    }
}
