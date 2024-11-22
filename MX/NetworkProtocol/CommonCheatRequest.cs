using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class CommonCheatRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Common_Cheat; }
        }

        public string Cheat { get; set; }

        public List<CheatCharacterCustomPreset> CharacterCustomPreset { get; set; }

        public CommonCheatRequest() { }
    }
}
