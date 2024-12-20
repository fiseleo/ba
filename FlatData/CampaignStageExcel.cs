// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CampaignStageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CampaignStageExcel GetRootAsCampaignStageExcel(ByteBuffer _bb) { return GetRootAsCampaignStageExcel(_bb, new CampaignStageExcel()); }
  public static CampaignStageExcel GetRootAsCampaignStageExcel(ByteBuffer _bb, CampaignStageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CampaignStageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool Deprecated { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string Name { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(8); }
  public string StageNumber { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStageNumberBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetStageNumberBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetStageNumberArray() { return __p.__vector_as_array<byte>(10); }
  public long CleardScenarioId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BattleDuration { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.ParcelType StageEnterCostType { get { int o = __p.__offset(16); return o != 0 ? (FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.ParcelType.None; } }
  public long StageEnterCostId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int StageEnterCostAmount { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int StageEnterEchelonCount { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long StarConditionTacticRankSCount { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StarConditionTurnCount { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnterScenarioGroupId(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int EnterScenarioGroupIdLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetEnterScenarioGroupIdBytes() { return __p.__vector_as_span<long>(28, 8); }
#else
  public ArraySegment<byte>? GetEnterScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public long[] GetEnterScenarioGroupIdArray() { return __p.__vector_as_array<long>(28); }
  public long ClearScenarioGroupId(int j) { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ClearScenarioGroupIdLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetClearScenarioGroupIdBytes() { return __p.__vector_as_span<long>(30, 8); }
#else
  public ArraySegment<byte>? GetClearScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public long[] GetClearScenarioGroupIdArray() { return __p.__vector_as_array<long>(30); }
  public string StrategyMap { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStrategyMapBytes() { return __p.__vector_as_span<byte>(32, 1); }
#else
  public ArraySegment<byte>? GetStrategyMapBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public byte[] GetStrategyMapArray() { return __p.__vector_as_array<byte>(32); }
  public string StrategyMapBG { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStrategyMapBGBytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetStrategyMapBGBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetStrategyMapBGArray() { return __p.__vector_as_array<byte>(34); }
  public long CampaignStageRewardId { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int MaxTurn { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatData.StageTopography StageTopography { get { int o = __p.__offset(40); return o != 0 ? (FlatData.StageTopography)__p.bb.GetInt(o + __p.bb_pos) : FlatData.StageTopography.Street; } }
  public int RecommandLevel { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string BgmId { get { int o = __p.__offset(44); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBgmIdBytes() { return __p.__vector_as_span<byte>(44, 1); }
#else
  public ArraySegment<byte>? GetBgmIdBytes() { return __p.__vector_as_arraysegment(44); }
#endif
  public byte[] GetBgmIdArray() { return __p.__vector_as_array<byte>(44); }
  public FlatData.StrategyEnvironment StrategyEnvironment { get { int o = __p.__offset(46); return o != 0 ? (FlatData.StrategyEnvironment)__p.bb.GetInt(o + __p.bb_pos) : FlatData.StrategyEnvironment.None; } }
  public long GroundId { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int StrategySkipGroundId { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatData.ContentType ContentType { get { int o = __p.__offset(52); return o != 0 ? (FlatData.ContentType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.ContentType.None; } }
  public long BGMId { get { int o = __p.__offset(54); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string FirstClearReportEventName { get { int o = __p.__offset(56); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFirstClearReportEventNameBytes() { return __p.__vector_as_span<byte>(56, 1); }
#else
  public ArraySegment<byte>? GetFirstClearReportEventNameBytes() { return __p.__vector_as_arraysegment(56); }
#endif
  public byte[] GetFirstClearReportEventNameArray() { return __p.__vector_as_array<byte>(56); }
  public long TacticRewardExp { get { int o = __p.__offset(58); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FixedEchelonId { get { int o = __p.__offset(60); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.EchelonExtensionType EchelonExtensionType { get { int o = __p.__offset(62); return o != 0 ? (FlatData.EchelonExtensionType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.EchelonExtensionType.Base; } }

  public static Offset<FlatData.CampaignStageExcel> CreateCampaignStageExcel(FlatBufferBuilder builder,
      long Id = 0,
      bool Deprecated = false,
      StringOffset NameOffset = default(StringOffset),
      StringOffset StageNumberOffset = default(StringOffset),
      long CleardScenarioId = 0,
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
      long CampaignStageRewardId = 0,
      int MaxTurn = 0,
      FlatData.StageTopography StageTopography = FlatData.StageTopography.Street,
      int RecommandLevel = 0,
      StringOffset BgmIdOffset = default(StringOffset),
      FlatData.StrategyEnvironment StrategyEnvironment = FlatData.StrategyEnvironment.None,
      long GroundId = 0,
      int StrategySkipGroundId = 0,
      FlatData.ContentType ContentType = FlatData.ContentType.None,
      long BGMId = 0,
      StringOffset FirstClearReportEventNameOffset = default(StringOffset),
      long TacticRewardExp = 0,
      long FixedEchelonId = 0,
      FlatData.EchelonExtensionType EchelonExtensionType = FlatData.EchelonExtensionType.Base) {
    builder.StartTable(30);
    CampaignStageExcel.AddFixedEchelonId(builder, FixedEchelonId);
    CampaignStageExcel.AddTacticRewardExp(builder, TacticRewardExp);
    CampaignStageExcel.AddBGMId(builder, BGMId);
    CampaignStageExcel.AddGroundId(builder, GroundId);
    CampaignStageExcel.AddCampaignStageRewardId(builder, CampaignStageRewardId);
    CampaignStageExcel.AddStarConditionTurnCount(builder, StarConditionTurnCount);
    CampaignStageExcel.AddStarConditionTacticRankSCount(builder, StarConditionTacticRankSCount);
    CampaignStageExcel.AddStageEnterCostId(builder, StageEnterCostId);
    CampaignStageExcel.AddBattleDuration(builder, BattleDuration);
    CampaignStageExcel.AddCleardScenarioId(builder, CleardScenarioId);
    CampaignStageExcel.AddId(builder, Id);
    CampaignStageExcel.AddEchelonExtensionType(builder, EchelonExtensionType);
    CampaignStageExcel.AddFirstClearReportEventName(builder, FirstClearReportEventNameOffset);
    CampaignStageExcel.AddContentType(builder, ContentType);
    CampaignStageExcel.AddStrategySkipGroundId(builder, StrategySkipGroundId);
    CampaignStageExcel.AddStrategyEnvironment(builder, StrategyEnvironment);
    CampaignStageExcel.AddBgmId(builder, BgmIdOffset);
    CampaignStageExcel.AddRecommandLevel(builder, RecommandLevel);
    CampaignStageExcel.AddStageTopography(builder, StageTopography);
    CampaignStageExcel.AddMaxTurn(builder, MaxTurn);
    CampaignStageExcel.AddStrategyMapBG(builder, StrategyMapBGOffset);
    CampaignStageExcel.AddStrategyMap(builder, StrategyMapOffset);
    CampaignStageExcel.AddClearScenarioGroupId(builder, ClearScenarioGroupIdOffset);
    CampaignStageExcel.AddEnterScenarioGroupId(builder, EnterScenarioGroupIdOffset);
    CampaignStageExcel.AddStageEnterEchelonCount(builder, StageEnterEchelonCount);
    CampaignStageExcel.AddStageEnterCostAmount(builder, StageEnterCostAmount);
    CampaignStageExcel.AddStageEnterCostType(builder, StageEnterCostType);
    CampaignStageExcel.AddStageNumber(builder, StageNumberOffset);
    CampaignStageExcel.AddName(builder, NameOffset);
    CampaignStageExcel.AddDeprecated(builder, Deprecated);
    return CampaignStageExcel.EndCampaignStageExcel(builder);
  }

  public static void StartCampaignStageExcel(FlatBufferBuilder builder) { builder.StartTable(30); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddDeprecated(FlatBufferBuilder builder, bool deprecated) { builder.AddBool(1, deprecated, false); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(2, nameOffset.Value, 0); }
  public static void AddStageNumber(FlatBufferBuilder builder, StringOffset stageNumberOffset) { builder.AddOffset(3, stageNumberOffset.Value, 0); }
  public static void AddCleardScenarioId(FlatBufferBuilder builder, long cleardScenarioId) { builder.AddLong(4, cleardScenarioId, 0); }
  public static void AddBattleDuration(FlatBufferBuilder builder, long battleDuration) { builder.AddLong(5, battleDuration, 0); }
  public static void AddStageEnterCostType(FlatBufferBuilder builder, FlatData.ParcelType stageEnterCostType) { builder.AddInt(6, (int)stageEnterCostType, 0); }
  public static void AddStageEnterCostId(FlatBufferBuilder builder, long stageEnterCostId) { builder.AddLong(7, stageEnterCostId, 0); }
  public static void AddStageEnterCostAmount(FlatBufferBuilder builder, int stageEnterCostAmount) { builder.AddInt(8, stageEnterCostAmount, 0); }
  public static void AddStageEnterEchelonCount(FlatBufferBuilder builder, int stageEnterEchelonCount) { builder.AddInt(9, stageEnterEchelonCount, 0); }
  public static void AddStarConditionTacticRankSCount(FlatBufferBuilder builder, long starConditionTacticRankSCount) { builder.AddLong(10, starConditionTacticRankSCount, 0); }
  public static void AddStarConditionTurnCount(FlatBufferBuilder builder, long starConditionTurnCount) { builder.AddLong(11, starConditionTurnCount, 0); }
  public static void AddEnterScenarioGroupId(FlatBufferBuilder builder, VectorOffset enterScenarioGroupIdOffset) { builder.AddOffset(12, enterScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateEnterScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnterScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEnterScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddClearScenarioGroupId(FlatBufferBuilder builder, VectorOffset clearScenarioGroupIdOffset) { builder.AddOffset(13, clearScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateClearScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateClearScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartClearScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddStrategyMap(FlatBufferBuilder builder, StringOffset strategyMapOffset) { builder.AddOffset(14, strategyMapOffset.Value, 0); }
  public static void AddStrategyMapBG(FlatBufferBuilder builder, StringOffset strategyMapBGOffset) { builder.AddOffset(15, strategyMapBGOffset.Value, 0); }
  public static void AddCampaignStageRewardId(FlatBufferBuilder builder, long campaignStageRewardId) { builder.AddLong(16, campaignStageRewardId, 0); }
  public static void AddMaxTurn(FlatBufferBuilder builder, int maxTurn) { builder.AddInt(17, maxTurn, 0); }
  public static void AddStageTopography(FlatBufferBuilder builder, FlatData.StageTopography stageTopography) { builder.AddInt(18, (int)stageTopography, 0); }
  public static void AddRecommandLevel(FlatBufferBuilder builder, int recommandLevel) { builder.AddInt(19, recommandLevel, 0); }
  public static void AddBgmId(FlatBufferBuilder builder, StringOffset bgmIdOffset) { builder.AddOffset(20, bgmIdOffset.Value, 0); }
  public static void AddStrategyEnvironment(FlatBufferBuilder builder, FlatData.StrategyEnvironment strategyEnvironment) { builder.AddInt(21, (int)strategyEnvironment, 0); }
  public static void AddGroundId(FlatBufferBuilder builder, long groundId) { builder.AddLong(22, groundId, 0); }
  public static void AddStrategySkipGroundId(FlatBufferBuilder builder, int strategySkipGroundId) { builder.AddInt(23, strategySkipGroundId, 0); }
  public static void AddContentType(FlatBufferBuilder builder, FlatData.ContentType contentType) { builder.AddInt(24, (int)contentType, 0); }
  public static void AddBGMId(FlatBufferBuilder builder, long bGMId) { builder.AddLong(25, bGMId, 0); }
  public static void AddFirstClearReportEventName(FlatBufferBuilder builder, StringOffset firstClearReportEventNameOffset) { builder.AddOffset(26, firstClearReportEventNameOffset.Value, 0); }
  public static void AddTacticRewardExp(FlatBufferBuilder builder, long tacticRewardExp) { builder.AddLong(27, tacticRewardExp, 0); }
  public static void AddFixedEchelonId(FlatBufferBuilder builder, long fixedEchelonId) { builder.AddLong(28, fixedEchelonId, 0); }
  public static void AddEchelonExtensionType(FlatBufferBuilder builder, FlatData.EchelonExtensionType echelonExtensionType) { builder.AddInt(29, (int)echelonExtensionType, 0); }
  public static Offset<FlatData.CampaignStageExcel> EndCampaignStageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.CampaignStageExcel>(o);
  }
  public CampaignStageExcelT UnPack() {
    var _o = new CampaignStageExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CampaignStageExcelT _o) {
    _o.Id = this.Id;
    _o.Deprecated = this.Deprecated;
    _o.Name = this.Name;
    _o.StageNumber = this.StageNumber;
    _o.CleardScenarioId = this.CleardScenarioId;
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
    _o.CampaignStageRewardId = this.CampaignStageRewardId;
    _o.MaxTurn = this.MaxTurn;
    _o.StageTopography = this.StageTopography;
    _o.RecommandLevel = this.RecommandLevel;
    _o.BgmId = this.BgmId;
    _o.StrategyEnvironment = this.StrategyEnvironment;
    _o.GroundId = this.GroundId;
    _o.StrategySkipGroundId = this.StrategySkipGroundId;
    _o.ContentType = this.ContentType;
    _o.BGMId = this.BGMId;
    _o.FirstClearReportEventName = this.FirstClearReportEventName;
    _o.TacticRewardExp = this.TacticRewardExp;
    _o.FixedEchelonId = this.FixedEchelonId;
    _o.EchelonExtensionType = this.EchelonExtensionType;
  }
  public static Offset<FlatData.CampaignStageExcel> Pack(FlatBufferBuilder builder, CampaignStageExcelT _o) {
    if (_o == null) return default(Offset<FlatData.CampaignStageExcel>);
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
    var _FirstClearReportEventName = _o.FirstClearReportEventName == null ? default(StringOffset) : builder.CreateString(_o.FirstClearReportEventName);
    return CreateCampaignStageExcel(
      builder,
      _o.Id,
      _o.Deprecated,
      _Name,
      _StageNumber,
      _o.CleardScenarioId,
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
      _o.CampaignStageRewardId,
      _o.MaxTurn,
      _o.StageTopography,
      _o.RecommandLevel,
      _BgmId,
      _o.StrategyEnvironment,
      _o.GroundId,
      _o.StrategySkipGroundId,
      _o.ContentType,
      _o.BGMId,
      _FirstClearReportEventName,
      _o.TacticRewardExp,
      _o.FixedEchelonId,
      _o.EchelonExtensionType);
  }
}

public class CampaignStageExcelT
{
  [Newtonsoft.Json.JsonProperty("Id")]
  public long Id { get; set; }
  [Newtonsoft.Json.JsonProperty("Deprecated")]
  public bool Deprecated { get; set; }
  [Newtonsoft.Json.JsonProperty("Name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("StageNumber")]
  public string StageNumber { get; set; }
  [Newtonsoft.Json.JsonProperty("CleardScenarioId")]
  public long CleardScenarioId { get; set; }
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
  [Newtonsoft.Json.JsonProperty("CampaignStageRewardId")]
  public long CampaignStageRewardId { get; set; }
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
  [Newtonsoft.Json.JsonProperty("GroundId")]
  public long GroundId { get; set; }
  [Newtonsoft.Json.JsonProperty("StrategySkipGroundId")]
  public int StrategySkipGroundId { get; set; }
  [Newtonsoft.Json.JsonProperty("ContentType")]
  public FlatData.ContentType ContentType { get; set; }
  [Newtonsoft.Json.JsonProperty("BGMId")]
  public long BGMId { get; set; }
  [Newtonsoft.Json.JsonProperty("FirstClearReportEventName")]
  public string FirstClearReportEventName { get; set; }
  [Newtonsoft.Json.JsonProperty("TacticRewardExp")]
  public long TacticRewardExp { get; set; }
  [Newtonsoft.Json.JsonProperty("FixedEchelonId")]
  public long FixedEchelonId { get; set; }
  [Newtonsoft.Json.JsonProperty("EchelonExtensionType")]
  public FlatData.EchelonExtensionType EchelonExtensionType { get; set; }

  public CampaignStageExcelT() {
    this.Id = 0;
    this.Deprecated = false;
    this.Name = null;
    this.StageNumber = null;
    this.CleardScenarioId = 0;
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
    this.CampaignStageRewardId = 0;
    this.MaxTurn = 0;
    this.StageTopography = FlatData.StageTopography.Street;
    this.RecommandLevel = 0;
    this.BgmId = null;
    this.StrategyEnvironment = FlatData.StrategyEnvironment.None;
    this.GroundId = 0;
    this.StrategySkipGroundId = 0;
    this.ContentType = FlatData.ContentType.None;
    this.BGMId = 0;
    this.FirstClearReportEventName = null;
    this.TacticRewardExp = 0;
    this.FixedEchelonId = 0;
    this.EchelonExtensionType = FlatData.EchelonExtensionType.Base;
  }
}


static public class CampaignStageExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Deprecated*/, 1 /*bool*/, 1, false)
      && verifier.VerifyString(tablePos, 8 /*Name*/, false)
      && verifier.VerifyString(tablePos, 10 /*StageNumber*/, false)
      && verifier.VerifyField(tablePos, 12 /*CleardScenarioId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*BattleDuration*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*StageEnterCostType*/, 4 /*FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*StageEnterCostId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*StageEnterCostAmount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*StageEnterEchelonCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*StarConditionTacticRankSCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 26 /*StarConditionTurnCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 28 /*EnterScenarioGroupId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 30 /*ClearScenarioGroupId*/, 8 /*long*/, false)
      && verifier.VerifyString(tablePos, 32 /*StrategyMap*/, false)
      && verifier.VerifyString(tablePos, 34 /*StrategyMapBG*/, false)
      && verifier.VerifyField(tablePos, 36 /*CampaignStageRewardId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 38 /*MaxTurn*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 40 /*StageTopography*/, 4 /*FlatData.StageTopography*/, 4, false)
      && verifier.VerifyField(tablePos, 42 /*RecommandLevel*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 44 /*BgmId*/, false)
      && verifier.VerifyField(tablePos, 46 /*StrategyEnvironment*/, 4 /*FlatData.StrategyEnvironment*/, 4, false)
      && verifier.VerifyField(tablePos, 48 /*GroundId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 50 /*StrategySkipGroundId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 52 /*ContentType*/, 4 /*FlatData.ContentType*/, 4, false)
      && verifier.VerifyField(tablePos, 54 /*BGMId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 56 /*FirstClearReportEventName*/, false)
      && verifier.VerifyField(tablePos, 58 /*TacticRewardExp*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 60 /*FixedEchelonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 62 /*EchelonExtensionType*/, 4 /*FlatData.EchelonExtensionType*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
