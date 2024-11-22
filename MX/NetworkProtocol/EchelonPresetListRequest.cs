using FlatData;

namespace MX.NetworkProtocol
{
    public class EchelonPresetListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Echelon_PresetList; }
        }

        public EchelonExtensionType EchelonExtensionType { get; set; }

        public EchelonPresetListRequest() { }
    }
}
