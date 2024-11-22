using System.Collections.Generic;
using MX.GameLogic.Parcel;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class CraftInfoDB
    {
        public long SlotSequence { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime CraftSlotOpenDate { get; set; }

        public List<CraftNodeDB> Nodes { get; set; }

        [JsonIgnore]
        public IEnumerable<long> ResultIds
        {
            get { return null; }
        }

        [JsonIgnore]
        public IEnumerable<ParcelInfo> RewardParcelInfos
        {
            get { return null; }
        }

        public CraftState GetState(DateTime nowTime)
        {
            return CraftState.None;
        }

        public int GetCraftDuration()
        {
            return 0;
        }

        public string SerializeRewardParcelInfos()
        {
            return null;
        }

        public CraftInfoDB() { }
    }
}
