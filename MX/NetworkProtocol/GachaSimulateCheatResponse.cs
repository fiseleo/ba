using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class GachaSimulateCheatResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.None; }
        }

        public Dictionary<long, int> CharacterIdAndCount { get; set; }

        public long SimulationCount { get; set; }

        public long GoodsUniqueId { get; set; }

        public string GoodsDevName { get; set; }

        public GachaSimulateCheatResponse() { }
    }
}
