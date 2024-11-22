﻿using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EchelonPresetSaveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Echelon_PresetSave; }
        }

        public EchelonPresetDB PresetDB { get; set; }

        public EchelonPresetSaveRequest() { }
    }
}
