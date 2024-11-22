using FlatData;

namespace MX.NetworkProtocol
{
    public class EchelonPresetGroupRenameRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Echelon_PresetGroupRename; }
        }

        public int PresetGroupIndex { get; set; }

        public EchelonExtensionType ExtensionType { get; set; }

        public string PresetGroupLabel { get; set; }

        public EchelonPresetGroupRenameRequest() { }
    }
}
