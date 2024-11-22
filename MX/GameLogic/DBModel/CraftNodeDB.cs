using System.Collections.Generic;
using FlatData;
using MX.Core.Math;
using MX.GameLogic.Parcel;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class CraftNodeDB
    {
        public CraftNodeTier NodeTier { get; set; }

        public long SlotSequence { get; set; }

        public long NodeId { get; set; }

        public long NodeQuality { get; set; }

        public long NodeLevel { get; set; }

        public int NodeRandomSeed { get; set; }

        public int NodeRandomSequence { get; set; }

        public List<long> LeafNodeIds { get; set; }

        public long ResultId { get; set; }

        public CraftNodeResult CraftNodeResult { get; set; }

        [JsonIgnore]
        public ParcelInfo RewardParcelInfo
        {
            get { return null; }
        }

        public void MakeRewardParcelInfo(IPseudoRandomService random) { }

        public CraftNodeDB() { }
    }
}
