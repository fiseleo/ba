using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EchelonPresetGroupRenameResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Echelon_PresetGroupRename; }
        }

        public EchelonPresetGroupDB PresetGroupDB { get; set; }

        public EchelonPresetGroupRenameResponse() { }
    }
}
