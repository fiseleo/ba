using System.Collections.Generic;
using System.ComponentModel;
using FlatData;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class EchelonPresetGroupDB
    {
        [DefaultValue(-1)]
        public int GroupIndex { get; set; } = -1;

        [DefaultValue(EchelonExtensionType.Base)]
        public EchelonExtensionType ExtensionType { get; set; }

        public string GroupLabel { get; set; }

        public Dictionary<int, EchelonPresetDB> PresetDBs { get; set; }

        public EchelonPresetGroupDB Clone()
        {
            return null;
        }

        [JsonConstructor]
        protected EchelonPresetGroupDB() { }

        public EchelonPresetGroupDB(int groupIndex, EchelonExtensionType extensionType) { }

        public EchelonPresetDB this[int index]
        {
            get { return null; }
            set { }
        }
    }
}
