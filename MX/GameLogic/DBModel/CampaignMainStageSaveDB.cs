using System.Collections.Generic;
using FlatData;
using MX.Campaign;
// using MX.Campaign.HexaTileMapEvent;
using MX.Data;
using MX.GameLogic.Parcel;
using MX.NetworkProtocol;

namespace MX.GameLogic.DBModel
{
    public class CampaignMainStageSaveDB : ContentSaveDB
    {
        public override ContentType ContentType
        {
            get { return ContentType.CampaignMainStage; }
        }

        public CampaignState CampaignState { get; set; }

        public int CurrentTurn { get; set; }

        public int EnemyClearCount { get; set; }

        public int LastEnemyEntityId { get; set; }

        public int GetNextEnemyEntityId()
        {
            return 0;
        }

        public int TacticRankSCount { get; set; }

        public Dictionary<long, HexaUnit> EnemyInfos { get; set; }

        public bool ShouldSerializeEnemyInfos()
        {
            return default(bool);
        }

        public Dictionary<long, HexaUnit> EchelonInfos { get; set; }

        public bool ShouldSerializeEchelonInfos()
        {
            return default(bool);
        }

        public Dictionary<long, List<long>> WithdrawInfos { get; set; }

        public bool ShouldSerializeWithdrawInfos()
        {
            return default(bool);
        }

        public Dictionary<long, Strategy> StrategyObjects { get; set; }

        public bool ShouldSerializeStrategyObjects()
        {
            return default(bool);
        }

        public Dictionary<long, List<ParcelInfo>> StrategyObjectRewards { get; set; }

        public bool ShouldSerializeStrategyObjectRewards()
        {
            return default(bool);
        }

        public List<long> StrategyObjectHistory { get; set; }

        public bool ShouldSerializeStrategyObjectHistory()
        {
            return default(bool);
        }

        public Dictionary<long, List<long>> ActivatedHexaEventsAndConditions { get; set; }

        public bool ShouldSerializeActivatedHexaEventsAndConditions()
        {
            return default(bool);
        }

        public Dictionary<long, List<long>> HexaEventDelayedExecutions { get; set; }

        public bool ShouldSerializeHexaEventDelayActivations()
        {
            return default(bool);
        }

        public Dictionary<int, HexaTileState> TileMapStates { get; set; }

        public bool ShouldSerializeTileMapStates()
        {
            return default(bool);
        }

        // public List<HexaDisplayInfo> DisplayInfos { get; set; }

        public bool ShouldSerializeDisplayInfos()
        {
            return default(bool);
        }

        public List<HexaUnit> DeployedEchelonInfos { get; set; }

        public bool ShouldSerializeDeployedEchelonInfos()
        {
            return default(bool);
        }

        public CampaignMainStageSaveDB() { }

        public CampaignMainStageSaveDB(CampaignMainStageSaveDB other) { }

        public virtual CampaignMainStageSaveDB Clone()
        {
            return null;
        }

        protected void DeepCopy(CampaignMainStageSaveDB copy) { }

        public bool IsDeployedEchelon(long echelonEntityId)
        {
            return default(bool);
        }

        public bool IsFixedEchelon(long echelonEntityId)
        {
            return default(bool);
        }

        public bool IsDeployedCharacter(long characterServerId)
        {
            return default(bool);
        }

        public List<long> GetDeployedServerIdList()
        {
            return null;
        }

        public bool HasWithdrawRecord(long characterServerId)
        {
            return default(bool);
        }

        public bool HasWithdrawRecord(IEnumerable<long> characterServerIds)
        {
            return default(bool);
        }

        public HexaUnit FindHexaUnit(long entityId)
        {
            return null;
        }

        public HexaUnit FindHexaUnit(HexLocation location)
        {
            return null;
        }

        public HexaUnit FindHexaUnitFromAlly(long entityId)
        {
            return null;
        }

        public HexaUnit FindHexaUnitFromEnemy(long entityId)
        {
            return null;
        }

        public void RemoveUnit(long entityId) { }

        public Strategy FindStrategyObject(long entityId)
        {
            return null;
        }

        public Strategy FindStrategyObject(HexLocation location)
        {
            return null;
        }

        public bool IsCampaignEnd()
        {
            return default(bool);
        }

        public virtual CampaignStageInfo GetStageInfo()
        {
            return null;
        }
    }
}
