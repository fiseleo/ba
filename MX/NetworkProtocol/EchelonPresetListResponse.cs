using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EchelonPresetListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Echelon_PresetList; }
        }

        public EchelonPresetGroupDB[] PresetGroupDBs { get; set; }

        public EchelonPresetListResponse() { }
    }
}
