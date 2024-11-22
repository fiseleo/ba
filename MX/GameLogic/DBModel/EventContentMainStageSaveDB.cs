using System.Collections.Generic;
using FlatData;
using MX.Data;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class EventContentMainStageSaveDB : CampaignMainStageSaveDB
    {
        public override ContentType ContentType
        {
            get { return ContentType.None; }
        }

        public Dictionary<long, long> SelectedBuffDict { get; private set; } = [];

        public bool ShouldSerializeSelectedBuffDict()
        {
            return SelectedBuffDict.Count > 0;
        }

        [JsonIgnore]
        public bool IsBuffSelectPopupOpen
        {
            get { return default(bool); }
        }

        public long CurrentAppearedBuffGroupId { get; set; }

        public EventContentMainStageSaveDB() { }

        public EventContentMainStageSaveDB(CampaignMainStageSaveDB other) { }

        public EventContentMainStageSaveDB(EventContentMainStageSaveDB other) { }

        public override CampaignMainStageSaveDB Clone()
        {
            return null;
        }

        public override CampaignStageInfo GetStageInfo()
        {
            return null;
        }

        public bool TrySelectBuff(long buffId)
        {
            return default(bool);
        }

        public bool TrySetCurrentAppearedBuffGroupId(long newBuffGroupId)
        {
            return default(bool);
        }
    }
}
