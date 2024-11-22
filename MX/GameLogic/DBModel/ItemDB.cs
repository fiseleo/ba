using System.Collections.Generic;
using FlatData;
using MX.GameLogic.Parcel;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class ItemDB : ConsumableItemBaseDB
    {
        public override ParcelType Type
        {
            get { return ParcelType.Item; }
        }

        [JsonIgnore]
        public override IEnumerable<ParcelInfo> ParcelInfos
        {
            get { return null; }
        }

        public bool IsNew { get; set; }

        public bool IsLocked { get; set; }

        [JsonIgnore]
        public override bool CanConsume
        {
            get { return true; }
        }

        public override string ToString()
        {
            return null;
        }

        public ItemDB Clone()
        {
            return null;
        }

        public static bool Equivalent(ItemDB first, ItemDB second)
        {
            return default(bool);
        }

        public ItemDB() { }
    }
}
