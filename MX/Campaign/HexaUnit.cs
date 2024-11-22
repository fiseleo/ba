using System.Collections.Generic;
using FlatData;
using MX.GameLogic.Parcel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// using UnityEngine;

namespace MX.Campaign
{
    public class HexaUnit
    {
        [JsonIgnore]
        public List<string> BuffGroupIds
        {
            get { return null; }
        }

        public SkillCardHand SkillCardHand { get; set; }

        public bool PlayAnimation { get; set; }

        [JsonIgnore]
        public Dictionary<TacticEntityType, List<long>> RewardItems
        {
            get { return null; }
        }

        public List<ParcelInfo> GetRewardParcelInfos()
        {
            return null;
        }

        public HexaUnit() { }

        public HexaUnit(HexaUnit unit) { }

        public void InitExcel() { }

        // public void BuildMovementMap(HexaTileMap mapData) { }

        // public void BuildMovementMapWithoutRange(HexaTileMap mapData) { }

        // public void Move(HexaTileMap mapData, HexLocation dest) { }

        public void RefreshHexaUnitProperty(int currentTurn) { }

        public void ClearMovement() { }

        public HexaUnit Clone()
        {
            return null;
        }

        public long EntityId;

        public Dictionary<long, long> HpInfos;

        public Dictionary<long, long> DyingInfos;

        public Dictionary<long, int> BuffInfos;

        public int ActionCountMax;

        public int ActionCount;

        public int Mobility;

        public int StrategySightRange;

        public long Id;

        // [JsonConverter(typeof(VectorConverter))]
        // public Vector3 Rotate;

        public HexLocation Location;

        public HexLocation AIDestination;

        public bool IsActionComplete;

        public bool IsPlayer;

        public bool IsFixedEchelon;

        public int MovementOrder;

        public Dictionary<
            TacticEntityType,
            List<ParcelInfo>
        > RewardParcelInfosWithDropTacticEntityType;

        [JsonIgnore]
        public CampaignUnitExcel CampaignUnitExcel;

        [JsonIgnore]
        [NonSerialized]
        public List<HexaTile> MovableTiles;

        [JsonIgnore]
        [NonSerialized]
        public List<List<HexaTile>> MovementMap;
    }
}
