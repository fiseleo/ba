// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct LimitedStageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static LimitedStageExcel GetRootAsLimitedStageExcel(ByteBuffer _bb) { return GetRootAsLimitedStageExcel(_bb, new LimitedStageExcel()); }
  public static LimitedStageExcel GetRootAsLimitedStageExcel(ByteBuffer _bb, LimitedStageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LimitedStageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public long SeasonId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.StageDifficulty StageDifficulty { get { int o = __p.__offset(10); return o != 0 ? (FlatData.StageDifficulty)__p.bb.GetInt(o + __p.bb_pos) : FlatData.StageDifficulty.None; } }
  public string StageNumber { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStageNumberBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetStageNumberBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetStageNumberArray() { return __p.__vector_as_array<byte>(12); }
  public int StageDisplay { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long PrevStageId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OpenDate { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OpenEventPoint { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BattleDuration { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.ParcelType StageEnterCostType { get { int o = __p.__offset(24); return o != 0 ? (FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.ParcelType.None; } }
  public long StageEnterCostId { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int StageEnterCostAmount { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int StageEnterEchelonCount { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long StarConditionTacticRankSCount { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StarConditionTurnCount { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnterScenarioGroupId(int j) { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int EnterScenarioGroupIdLength { get { int o = __p.__offset(36); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetEnterScenarioGroupIdBytes() { return __p.__vector_as_span<long>(36, 8); }
#else
  public ArraySegment<byte>? GetEnterScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public long[] GetEnterScenarioGroupIdArray() { return __p.__vector_as_array<long>(36); }
  public long ClearScenarioGroupId(int j) { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ClearScenarioGroupIdLength { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetClearScenarioGroupIdBytes() { return __p.__vector_as_span<long>(38, 8); }
#else
  public ArraySegment<byte>? GetClearScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public long[] GetClearScenarioGroupIdArray() { return __p.__vector_as_array<long>(38); }
  public string StrategyMap { get { int o = __p.__offset(40); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStrategyMapBytes() { return __p.__vector_as_span<byte>(40, 1); }
#else
  public ArraySegment<byte>? GetStrategyMapBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public byte[] GetStrategyMapArray() { return __p.__vector_as_array<byte>(40); }
  public string StrategyMapBG { get { int o = __p.__offset(42); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStrategyMapBGBytes() { return __p.__vector_as_span<byte>(42, 1); }
#else
  public ArraySegment<byte>? GetStrategyMapBGBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public byte[] GetStrategyMapBGArray() { return __p.__vector_as_array<byte>(42); }
  public long StageRewardId { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int MaxTurn { get { int o = __p.__offset(46); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatData.StageTopography StageTopography { get { int o = __p.__offset(48); return o != 0 ? (FlatData.StageTopography)__p.bb.GetInt(o + __p.bb_pos) : FlatData.StageTopography.Street; } }
  public int RecommandLevel { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string BgmId { get { int o = __p.__offset(52); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBgmIdBytes() { return __p.__vector_as_span<byte>(52, 1); }
#else
  public ArraySegment<byte>? GetBgmIdBytes() { return __p.__vector_as_arraysegment(52); }
#endif
  public byte[] GetBgmIdArray() { return __p.__vector_as_array<byte>(52); }
  public FlatData.StrategyEnvironment StrategyEnvironment { get { int o = __p.__offset(54); return o != 0 ? (FlatData.StrategyEnvironment)__p.bb.GetInt(o + __p.bb_pos) : FlatData.StrategyEnvironment.None; } }
  public long GroundID { get { int o = __p.__offset(56); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.ContentType ContentType { get { int o = __p.__offset(58); return o != 0 ? (FlatData.ContentType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.ContentType.None; } }
  public long BGMId { get { int o = __p.__offset(60); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool InstantClear { get { int o = __p.__offset(62); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long BuffContentId { get { int o = __p.__offset(64); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool ChallengeDisplay { get { int o = __p.__offset(66); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatData.LimitedStageExcel> CreateLimitedStageExcel(FlatBufferBuilder builder,
      long Id = 0,
      StringOffset NameOffset = default(StringOffset),
      long SeasonId = 0,
      FlatData.StageDifficulty StageDifficulty = FlatData.StageDifficulty.None,
      StringOffset StageNumberOffset = default(StringOffset),
      int StageDisplay = 0,
      long PrevStageId = 0,
      long OpenDate = 0,
      long OpenEventPoint = 0,
      long BattleDuration = 0,
      FlatData.ParcelType StageEnterCostType = FlatData.ParcelType.None,
      long StageEnterCostId = 0,
      int StageEnterCostAmount = 0,
      int StageEnterEchelonCount = 0,
      long StarConditionTacticRankSCount = 0,
      long StarConditionTurnCount = 0,
      VectorOffset EnterScenarioGroupIdOffset = default(VectorOffset),
      VectorOffset ClearScenarioGroupIdOffset = default(VectorOffset),
      StringOffset StrategyMapOffset = default(StringOffset),
      StringOffset StrategyMapBGOffset = default(StringOffset),
      long StageRewardId = 0,
      int MaxTurn = 0,
      FlatData.StageTopography StageTopography = FlatData.StageTopography.Street,
      int RecommandLevel = 0,
      StringOffset BgmIdOffset = default(StringOffset),
      FlatData.StrategyEnvironment StrategyEnvironment = FlatData.StrategyEnvironment.None,
      long GroundID = 0,
      FlatData.ContentType ContentType = FlatData.ContentType.None,
      long BGMId = 0,
      bool InstantClear = false,
      long BuffContentId = 0,
      bool ChallengeDisplay = false) {
    builder.StartTable(32);
    LimitedStageExcel.AddBuffContentId(builder, BuffContentId);
    LimitedStageExcel.AddBGMId(builder, BGMId);
    LimitedStageExcel.AddGroundID(builder, GroundID);
    LimitedStageExcel.AddStageRewardId(builder, StageRewardId);
    LimitedStageExcel.AddStarConditionTurnCount(builder, StarConditionTurnCount);
    LimitedStageExcel.AddStarConditionTacticRankSCount(builder, StarConditionTacticRankSCount);
    LimitedStageExcel.AddStageEnterCostId(builder, StageEnterCostId);
    LimitedStageExcel.AddBattleDuration(builder, BattleDuration);
    LimitedStageExcel.AddOpenEventPoint(builder, OpenEventPoint);
    LimitedStageExcel.AddOpenDate(builder, OpenDate);
    LimitedStageExcel.AddPrevStageId(builder, PrevStageId);
    LimitedStageExcel.AddSeasonId(builder, SeasonId);
    LimitedStageExcel.AddId(builder, Id);
    LimitedStageExcel.AddContentType(builder, ContentType);
    LimitedStageExcel.AddStrategyEnvironment(builder, StrategyEnvironment);
    LimitedStageExcel.AddBgmId(builder, BgmIdOffset);
    LimitedStageExcel.AddRecommandLevel(builder, RecommandLevel);
    LimitedStageExcel.AddStageTopography(builder, StageTopography);
    LimitedStageExcel.AddMaxTurn(builder, MaxTurn);
    LimitedStageExcel.AddStrategyMapBG(builder, StrategyMapBGOffset);
    LimitedStageExcel.AddStrategyMap(builder, StrategyMapOffset);
    LimitedStageExcel.AddClearScenarioGroupId(builder, ClearScenarioGroupIdOffset);
    LimitedStageExcel.AddEnterScenarioGroupId(builder, EnterScenarioGroupIdOffset);
    LimitedStageExcel.AddStageEnterEchelonCount(builder, StageEnterEchelonCount);
    LimitedStageExcel.AddStageEnterCostAmount(builder, StageEnterCostAmount);
    LimitedStageExcel.AddStageEnterCostType(builder, StageEnterCostType);
    LimitedStageExcel.AddStageDisplay(builder, StageDisplay);
    LimitedStageExcel.AddStageNumber(builder, StageNumberOffset);
    LimitedStageExcel.AddStageDifficulty(builder, StageDifficulty);
    LimitedStageExcel.AddName(builder, NameOffset);
    LimitedStageExcel.AddChallengeDisplay(builder, ChallengeDisplay);
    LimitedStageExcel.AddInstantClear(builder, InstantClear);
    return LimitedStageExcel.EndLimitedStageExcel(builder);
  }

  public static void StartLimitedStageExcel(FlatBufferBuilder builder) { builder.StartTable(32); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddSeasonId(FlatBufferBuilder builder, long seasonId) { builder.AddLong(2, seasonId, 0); }
  public static void AddStageDifficulty(FlatBufferBuilder builder, FlatData.StageDifficulty stageDifficulty) { builder.AddInt(3, (int)stageDifficulty, 0); }
  public static void AddStageNumber(FlatBufferBuilder builder, StringOffset stageNumberOffset) { builder.AddOffset(4, stageNumberOffset.Value, 0); }
  public static void AddStageDisplay(FlatBufferBuilder builder, int stageDisplay) { builder.AddInt(5, stageDisplay, 0); }
  public static void AddPrevStageId(FlatBufferBuilder builder, long prevStageId) { builder.AddLong(6, prevStageId, 0); }
  public static void AddOpenDate(FlatBufferBuilder builder, long openDate) { builder.AddLong(7, openDate, 0); }
  public static void AddOpenEventPoint(FlatBufferBuilder builder, long openEventPoint) { builder.AddLong(8, openEventPoint, 0); }
  public static void AddBattleDuration(FlatBufferBuilder builder, long battleDuration) { builder.AddLong(9, battleDuration, 0); }
  public static void AddStageEnterCostType(FlatBufferBuilder builder, FlatData.ParcelType stageEnterCostType) { builder.AddInt(10, (int)stageEnterCostType, 0); }
  public static void AddStageEnterCostId(FlatBufferBuilder builder, long stageEnterCostId) { builder.AddLong(11, stageEnterCostId, 0); }
  public static void AddStageEnterCostAmount(FlatBufferBuilder builder, int stageEnterCostAmount) { builder.AddInt(12, stageEnterCostAmount, 0); }
  public static void AddStageEnterEchelonCount(FlatBufferBuilder builder, int stageEnterEchelonCount) { builder.AddInt(13, stageEnterEchelonCount, 0); }
  public static void AddStarConditionTacticRankSCount(FlatBufferBuilder builder, long starConditionTacticRankSCount) { builder.AddLong(14, starConditionTacticRankSCount, 0); }
  public static void AddStarConditionTurnCount(FlatBufferBuilder builder, long starConditionTurnCount) { builder.AddLong(15, starConditionTurnCount, 0); }
  public static void AddEnterScenarioGroupId(FlatBufferBuilder builder, VectorOffset enterScenarioGroupIdOffset) { builder.AddOffset(16, enterScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateEnterScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEnterScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddClearScenarioGroupId(FlatBufferBuilder builder, VectorOffset clearScenarioGroupIdOffset) { builder.AddOffset(17, clearScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateClearScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartClearScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddStrategyMap(FlatBufferBuilder builder, StringOffset strategyMapOffset) { builder.AddOffset(18, strategyMapOffset.Value, 0); }
  public static void AddStrategyMapBG(FlatBufferBuilder builder, StringOffset strategyMapBGOffset) { builder.AddOffset(19, strategyMapBGOffset.Value, 0); }
  public static void AddStageRewardId(FlatBufferBuilder builder, long stageRewardId) { builder.AddLong(20, stageRewardId, 0); }
  public static void AddMaxTurn(FlatBufferBuilder builder, int maxTurn) { builder.AddInt(21, maxTurn, 0); }
  public static void AddStageTopography(FlatBufferBuilder builder, FlatData.StageTopography stageTopography) { builder.AddInt(22, (int)stageTopography, 0); }
  public static void AddRecommandLevel(FlatBufferBuilder builder, int recommandLevel) { builder.AddInt(23, recommandLevel, 0); }
  public static void AddBgmId(FlatBufferBuilder builder, StringOffset bgmIdOffset) { builder.AddOffset(24, bgmIdOffset.Value, 0); }
  public static void AddStrategyEnvironment(FlatBufferBuilder builder, FlatData.StrategyEnvironment strategyEnvironment) { builder.AddInt(25, (int)strategyEnvironment, 0); }
  public static void AddGroundID(FlatBufferBuilder builder, long groundID) { builder.AddLong(26, groundID, 0); }
  public static void AddContentType(FlatBufferBuilder builder, FlatData.ContentType contentType) { builder.AddInt(27, (int)contentType, 0); }
  public static void AddBGMId(FlatBufferBuilder builder, long bGMId) { builder.AddLong(28, bGMId, 0); }
  public static void AddInstantClear(FlatBufferBuilder builder, bool instantClear) { builder.AddBool(29, instantClear, false); }
  public static void AddBuffContentId(FlatBufferBuilder builder, long buffContentId) { builder.AddLong(30, buffContentId, 0); }
  public static void AddChallengeDisplay(FlatBufferBuilder builder, bool challengeDisplay) { builder.AddBool(31, challengeDisplay, false); }
  public static Offset<FlatData.LimitedStageExcel> EndLimitedStageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.LimitedStageExcel>(o);
  }
  public LimitedStageExcelT UnPack() {
    var _o = new LimitedStageExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(LimitedStageExcelT _o) {
    _o.Id = this.Id;
    _o.Name = this.Name;
    _o.SeasonId = this.SeasonId;
    _o.StageDifficulty = this.StageDifficulty;
    _o.StageNumber = this.StageNumber;
    _o.StageDisplay = this.StageDisplay;
    _o.PrevStageId = this.PrevStageId;
    _o.OpenDate = this.OpenDate;
    _o.OpenEventPoint = this.OpenEventPoint;
    _o.BattleDuration = this.BattleDuration;
    _o.StageEnterCostType = this.StageEnterCostType;
    _o.StageEnterCostId = this.StageEnterCostId;
    _o.StageEnterCostAmount = this.StageEnterCostAmount;
    _o.StageEnterEchelonCount = this.StageEnterEchelonCount;
    _o.StarConditionTacticRankSCount = this.StarConditionTacticRankSCount;
    _o.StarConditionTurnCount = this.StarConditionTurnCount;
    _o.EnterScenarioGroupId = new List<long>();
    for (var _j = 0; _j < this.EnterScenarioGroupIdLength; ++_j) {_o.EnterScenarioGroupId.Add(this.EnterScenarioGroupId(_j));}
    _o.ClearScenarioGroupId = new List<long>();
    for (var _j = 0; _j < this.ClearScenarioGroupIdLength; ++_j) {_o.ClearScenarioGroupId.Add(this.ClearScenarioGroupId(_j));}
    _o.StrategyMap = this.StrategyMap;
    _o.StrategyMapBG = this.StrategyMapBG;
    _o.StageRewardId = this.StageRewardId;
    _o.MaxTurn = this.MaxTurn;
    _o.StageTopography = this.StageTopography;
    _o.RecommandLevel = this.RecommandLevel;
    _o.BgmId = this.BgmId;
    _o.StrategyEnvironment = this.StrategyEnvironment;
    _o.GroundID = this.GroundID;
    _o.ContentType = this.ContentType;
    _o.BGMId = this.BGMId;
    _o.InstantClear = this.InstantClear;
    _o.BuffContentId = this.BuffContentId;
    _o.ChallengeDisplay = this.ChallengeDisplay;
  }
  public static Offset<FlatData.LimitedStageExcel> Pack(FlatBufferBuilder builder, LimitedStageExcelT _o) {
    if (_o == null) return default(Offset<FlatData.LimitedStageExcel>);
    var _Name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _StageNumber = _o.StageNumber == null ? default(StringOffset) : builder.CreateString(_o.StageNumber);
    var _EnterScenarioGroupId = default(VectorOffset);
    if (_o.EnterScenarioGroupId != null) {
      var __EnterScenarioGroupId = _o.EnterScenarioGroupId.ToArray();
      _EnterScenarioGroupId = CreateEnterScenarioGroupIdVector(builder, __EnterScenarioGroupId);
    }
    var _ClearScenarioGroupId = default(VectorOffset);
    if (_o.ClearScenarioGroupId != null) {
      var __ClearScenarioGroupId = _o.ClearScenarioGroupId.ToArray();
      _ClearScenarioGroupId = CreateClearScenarioGroupIdVector(builder, __ClearScenarioGroupId);
    }
    var _StrategyMap = _o.StrategyMap == null ? default(StringOffset) : builder.CreateString(_o.StrategyMap);
    var _StrategyMapBG = _o.StrategyMapBG == null ? default(StringOffset) : builder.CreateString(_o.StrategyMapBG);
    var _BgmId = _o.BgmId == null ? default(StringOffset) : builder.CreateString(_o.BgmId);
    return CreateLimitedStageExcel(
      builder,
      _o.Id,
      _Name,
      _o.SeasonId,
      _o.StageDifficulty,
      _StageNumber,
      _o.StageDisplay,
      _o.PrevStageId,
      _o.OpenDate,
      _o.OpenEventPoint,
      _o.BattleDuration,
      _o.StageEnterCostType,
      _o.StageEnterCostId,
      _o.StageEnterCostAmount,
      _o.StageEnterEchelonCount,
      _o.StarConditionTacticRankSCount,
      _o.StarConditionTurnCount,
      _EnterScenarioGroupId,
      _ClearScenarioGroupId,
      _StrategyMap,
      _StrategyMapBG,
      _o.StageRewardId,
      _o.MaxTurn,
      _o.StageTopography,
      _o.RecommandLevel,
      _BgmId,
      _o.StrategyEnvironment,
      _o.GroundID,
      _o.ContentType,
      _o.BGMId,
      _o.InstantClear,
      _o.BuffContentId,
      _o.ChallengeDisplay);
  }
}

public class LimitedStageExcelT
{
  [Newtonsoft.Json.JsonProperty("Id")]
  public long Id { get; set; }
  [Newtonsoft.Json.JsonProperty("Name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("SeasonId")]
  public long SeasonId { get; set; }
  [Newtonsoft.Json.JsonProperty("StageDifficulty")]
  public FlatData.StageDifficulty StageDifficulty { get; set; }
  [Newtonsoft.Json.JsonProperty("StageNumber")]
  public string StageNumber { get; set; }
  [Newtonsoft.Json.JsonProperty("StageDisplay")]
  public int StageDisplay { get; set; }
  [Newtonsoft.Json.JsonProperty("PrevStageId")]
  public long PrevStageId { get; set; }
  [Newtonsoft.Json.JsonProperty("OpenDate")]
  public long OpenDate { get; set; }
  [Newtonsoft.Json.JsonProperty("OpenEventPoint")]
  public long OpenEventPoint { get; set; }
  [Newtonsoft.Json.JsonProperty("BattleDuration")]
  public long BattleDuration { get; set; }
  [Newtonsoft.Json.JsonProperty("StageEnterCostType")]
  public FlatData.ParcelType StageEnterCostType { get; set; }
  [Newtonsoft.Json.JsonProperty("StageEnterCostId")]
  public long StageEnterCostId { get; set; }
  [Newtonsoft.Json.JsonProperty("StageEnterCostAmount")]
  public int StageEnterCostAmount { get; set; }
  [Newtonsoft.Json.JsonProperty("StageEnterEchelonCount")]
  public int StageEnterEchelonCount { get; set; }
  [Newtonsoft.Json.JsonProperty("StarConditionTacticRankSCount")]
  public long StarConditionTacticRankSCount { get; set; }
  [Newtonsoft.Json.JsonProperty("StarConditionTurnCount")]
  public long StarConditionTurnCount { get; set; }
  [Newtonsoft.Json.JsonProperty("EnterScenarioGroupId")]
  public List<long> EnterScenarioGroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("ClearScenarioGroupId")]
  public List<long> ClearScenarioGroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("StrategyMap")]
  public string StrategyMap { get; set; }
  [Newtonsoft.Json.JsonProperty("StrategyMapBG")]
  public string StrategyMapBG { get; set; }
  [Newtonsoft.Json.JsonProperty("StageRewardId")]
  public long StageRewardId { get; set; }
  [Newtonsoft.Json.JsonProperty("MaxTurn")]
  public int MaxTurn { get; set; }
  [Newtonsoft.Json.JsonProperty("StageTopography")]
  public FlatData.StageTopography StageTopography { get; set; }
  [Newtonsoft.Json.JsonProperty("RecommandLevel")]
  public int RecommandLevel { get; set; }
  [Newtonsoft.Json.JsonProperty("BgmId")]
  public string BgmId { get; set; }
  [Newtonsoft.Json.JsonProperty("StrategyEnvironment")]
  public FlatData.StrategyEnvironment StrategyEnvironment { get; set; }
  [Newtonsoft.Json.JsonProperty("GroundID")]
  public long GroundID { get; set; }
  [Newtonsoft.Json.JsonProperty("ContentType")]
  public FlatData.ContentType ContentType { get; set; }
  [Newtonsoft.Json.JsonProperty("BGMId")]
  public long BGMId { get; set; }
  [Newtonsoft.Json.JsonProperty("InstantClear")]
  public bool InstantClear { get; set; }
  [Newtonsoft.Json.JsonProperty("BuffContentId")]
  public long BuffContentId { get; set; }
  [Newtonsoft.Json.JsonProperty("ChallengeDisplay")]
  public bool ChallengeDisplay { get; set; }

  public LimitedStageExcelT() {
    this.Id = 0;
    this.Name = null;
    this.SeasonId = 0;
    this.StageDifficulty = FlatData.StageDifficulty.None;
    this.StageNumber = null;
    this.StageDisplay = 0;
    this.PrevStageId = 0;
    this.OpenDate = 0;
    this.OpenEventPoint = 0;
    this.BattleDuration = 0;
    this.StageEnterCostType = FlatData.ParcelType.None;
    this.StageEnterCostId = 0;
    this.StageEnterCostAmount = 0;
    this.StageEnterEchelonCount = 0;
    this.StarConditionTacticRankSCount = 0;
    this.StarConditionTurnCount = 0;
    this.EnterScenarioGroupId = null;
    this.ClearScenarioGroupId = null;
    this.StrategyMap = null;
    this.StrategyMapBG = null;
    this.StageRewardId = 0;
    this.MaxTurn = 0;
    this.StageTopography = FlatData.StageTopography.Street;
    this.RecommandLevel = 0;
    this.BgmId = null;
    this.StrategyEnvironment = FlatData.StrategyEnvironment.None;
    this.GroundID = 0;
    this.ContentType = FlatData.ContentType.None;
    this.BGMId = 0;
    this.InstantClear = false;
    this.BuffContentId = 0;
    this.ChallengeDisplay = false;
  }
}


static public class LimitedStageExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 6 /*Name*/, false)
      && verifier.VerifyField(tablePos, 8 /*SeasonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*StageDifficulty*/, 4 /*FlatData.StageDifficulty*/, 4, false)
      && verifier.VerifyString(tablePos, 12 /*StageNumber*/, false)
      && verifier.VerifyField(tablePos, 14 /*StageDisplay*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*PrevStageId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*OpenDate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*OpenEventPoint*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 22 /*BattleDuration*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 24 /*StageEnterCostType*/, 4 /*FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*StageEnterCostId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 28 /*StageEnterCostAmount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 30 /*StageEnterEchelonCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 32 /*StarConditionTacticRankSCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 34 /*StarConditionTurnCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 36 /*EnterScenarioGroupId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 38 /*ClearScenarioGroupId*/, 8 /*long*/, false)
      && verifier.VerifyString(tablePos, 40 /*StrategyMap*/, false)
      && verifier.VerifyString(tablePos, 42 /*StrategyMapBG*/, false)
      && verifier.VerifyField(tablePos, 44 /*StageRewardId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 46 /*MaxTurn*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 48 /*StageTopography*/, 4 /*FlatData.StageTopography*/, 4, false)
      && verifier.VerifyField(tablePos, 50 /*RecommandLevel*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 52 /*BgmId*/, false)
      && verifier.VerifyField(tablePos, 54 /*StrategyEnvironment*/, 4 /*FlatData.StrategyEnvironment*/, 4, false)
      && verifier.VerifyField(tablePos, 56 /*GroundID*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 58 /*ContentType*/, 4 /*FlatData.ContentType*/, 4, false)
      && verifier.VerifyField(tablePos, 60 /*BGMId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 62 /*InstantClear*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 64 /*BuffContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 66 /*ChallengeDisplay*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
