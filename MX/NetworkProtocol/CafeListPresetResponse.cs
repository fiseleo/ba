using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CafeListPresetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_ListPreset; }
        }

        public List<CafePresetDB> CafePresetDBs { get; set; }

        public CafeListPresetResponse() { }
    }
}
