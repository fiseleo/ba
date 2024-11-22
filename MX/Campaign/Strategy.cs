using System.Collections.Generic;
using FlatData;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// using UnityEngine;

namespace MX.Campaign
{
    public class Strategy
    {
        public bool PlayAnimation { get; set; }

        public bool Activated { get; set; }

        public List<int> Values { get; set; }

        public int Index { get; set; }

        [JsonIgnore]
        public bool Movable
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public bool NeedValueType
        {
            get { return default(bool); }
        }

        public Strategy() { }

        public Strategy(Strategy strategy) { }

        public Strategy Clone()
        {
            return null;
        }

        public void InitExcel() { }

        public int GetValueAndIncrementIndex()
        {
            return 0;
        }

        public long EntityId;

        // [JsonConverter(typeof(VectorConverter))]
        // public Vector3 Rotate;

        public long Id;

        public HexLocation Location;

        [JsonIgnore]
        public CampaignStrategyObjectExcel CampaignStrategyExcel;
    }
}
