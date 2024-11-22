using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EchelonPresetSaveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Echelon_PresetSave; }
        }

        public EchelonPresetDB PresetDB { get; set; }

        public EchelonPresetSaveResponse() { }
    }
}
