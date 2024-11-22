using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CharacterGearListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.CharacterGear_List; }
        }

        public List<GearDB> GearDBs { get; set; }

        public CharacterGearListResponse() { }
    }
}
