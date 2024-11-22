using System.Collections.Generic;
using FlatData;
using MX.GameLogic.Parcel;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class FurnitureDB : ConsumableItemBaseDB
    {
        public override ParcelType Type
        {
            get { return ParcelType.Furniture; }
        }

        [JsonIgnore]
        public override IEnumerable<ParcelInfo> ParcelInfos
        {
            get { return null; }
        }

        public FurnitureLocation Location { get; set; }

        public long CafeDBId { get; set; }

        public float PositionX { get; set; }

        public float PositionY { get; set; }

        public float Rotation { get; set; }

        public long ItemDeploySequence { get; set; }

        [JsonIgnore]
        public override bool CanConsume
        {
            get { return false; }
        }

        public override string ToString()
        {
            return null;
        }

        public FurnitureDB Clone()
        {
            return null;
        }

        public static bool Equivalent(FurnitureDB first, FurnitureDB second)
        {
            return default(bool);
        }

        public FurnitureDB() { }
    }
}
