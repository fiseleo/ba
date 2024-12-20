// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConstEventCommonExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ConstEventCommonExcel GetRootAsConstEventCommonExcel(ByteBuffer _bb) { return GetRootAsConstEventCommonExcel(_bb, new ConstEventCommonExcel()); }
  public static ConstEventCommonExcel GetRootAsConstEventCommonExcel(ByteBuffer _bb, ConstEventCommonExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConstEventCommonExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int EventContentHardStageCount { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long EventStrategyPlayTimeLimitInSeconds { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SubEventChangeLimitSeconds { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool SubEventInstantClear { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long CardShopProbWeightCount { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.Rarity CardShopProbWeightRarity { get { int o = __p.__offset(14); return o != 0 ? (FlatData.Rarity)__p.bb.GetInt(o + __p.bb_pos) : FlatData.Rarity.N; } }
  public string MeetupScenarioReplayResource { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMeetupScenarioReplayResourceBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetMeetupScenarioReplayResourceBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetMeetupScenarioReplayResourceArray() { return __p.__vector_as_array<byte>(16); }
  public string MeetupScenarioReplayTitleLocalize { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMeetupScenarioReplayTitleLocalizeBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetMeetupScenarioReplayTitleLocalizeBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetMeetupScenarioReplayTitleLocalizeArray() { return __p.__vector_as_array<byte>(18); }
  public long SpecialOperactionCollectionGroupId { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int TreasureNormalVariationAmount { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TreasureLoopVariationAmount { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TreasureLimitVariationLoopCount { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TreasureLimitVariationClearLoopCount { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatData.ConstEventCommonExcel> CreateConstEventCommonExcel(FlatBufferBuilder builder,
      int EventContentHardStageCount = 0,
      long EventStrategyPlayTimeLimitInSeconds = 0,
      long SubEventChangeLimitSeconds = 0,
      bool SubEventInstantClear = false,
      long CardShopProbWeightCount = 0,
      FlatData.Rarity CardShopProbWeightRarity = FlatData.Rarity.N,
      StringOffset MeetupScenarioReplayResourceOffset = default(StringOffset),
      StringOffset MeetupScenarioReplayTitleLocalizeOffset = default(StringOffset),
      long SpecialOperactionCollectionGroupId = 0,
      int TreasureNormalVariationAmount = 0,
      int TreasureLoopVariationAmount = 0,
      int TreasureLimitVariationLoopCount = 0,
      int TreasureLimitVariationClearLoopCount = 0) {
    builder.StartTable(13);
    ConstEventCommonExcel.AddSpecialOperactionCollectionGroupId(builder, SpecialOperactionCollectionGroupId);
    ConstEventCommonExcel.AddCardShopProbWeightCount(builder, CardShopProbWeightCount);
    ConstEventCommonExcel.AddSubEventChangeLimitSeconds(builder, SubEventChangeLimitSeconds);
    ConstEventCommonExcel.AddEventStrategyPlayTimeLimitInSeconds(builder, EventStrategyPlayTimeLimitInSeconds);
    ConstEventCommonExcel.AddTreasureLimitVariationClearLoopCount(builder, TreasureLimitVariationClearLoopCount);
    ConstEventCommonExcel.AddTreasureLimitVariationLoopCount(builder, TreasureLimitVariationLoopCount);
    ConstEventCommonExcel.AddTreasureLoopVariationAmount(builder, TreasureLoopVariationAmount);
    ConstEventCommonExcel.AddTreasureNormalVariationAmount(builder, TreasureNormalVariationAmount);
    ConstEventCommonExcel.AddMeetupScenarioReplayTitleLocalize(builder, MeetupScenarioReplayTitleLocalizeOffset);
    ConstEventCommonExcel.AddMeetupScenarioReplayResource(builder, MeetupScenarioReplayResourceOffset);
    ConstEventCommonExcel.AddCardShopProbWeightRarity(builder, CardShopProbWeightRarity);
    ConstEventCommonExcel.AddEventContentHardStageCount(builder, EventContentHardStageCount);
    ConstEventCommonExcel.AddSubEventInstantClear(builder, SubEventInstantClear);
    return ConstEventCommonExcel.EndConstEventCommonExcel(builder);
  }

  public static void StartConstEventCommonExcel(FlatBufferBuilder builder) { builder.StartTable(13); }
  public static void AddEventContentHardStageCount(FlatBufferBuilder builder, int eventContentHardStageCount) { builder.AddInt(0, eventContentHardStageCount, 0); }
  public static void AddEventStrategyPlayTimeLimitInSeconds(FlatBufferBuilder builder, long eventStrategyPlayTimeLimitInSeconds) { builder.AddLong(1, eventStrategyPlayTimeLimitInSeconds, 0); }
  public static void AddSubEventChangeLimitSeconds(FlatBufferBuilder builder, long subEventChangeLimitSeconds) { builder.AddLong(2, subEventChangeLimitSeconds, 0); }
  public static void AddSubEventInstantClear(FlatBufferBuilder builder, bool subEventInstantClear) { builder.AddBool(3, subEventInstantClear, false); }
  public static void AddCardShopProbWeightCount(FlatBufferBuilder builder, long cardShopProbWeightCount) { builder.AddLong(4, cardShopProbWeightCount, 0); }
  public static void AddCardShopProbWeightRarity(FlatBufferBuilder builder, FlatData.Rarity cardShopProbWeightRarity) { builder.AddInt(5, (int)cardShopProbWeightRarity, 0); }
  public static void AddMeetupScenarioReplayResource(FlatBufferBuilder builder, StringOffset meetupScenarioReplayResourceOffset) { builder.AddOffset(6, meetupScenarioReplayResourceOffset.Value, 0); }
  public static void AddMeetupScenarioReplayTitleLocalize(FlatBufferBuilder builder, StringOffset meetupScenarioReplayTitleLocalizeOffset) { builder.AddOffset(7, meetupScenarioReplayTitleLocalizeOffset.Value, 0); }
  public static void AddSpecialOperactionCollectionGroupId(FlatBufferBuilder builder, long specialOperactionCollectionGroupId) { builder.AddLong(8, specialOperactionCollectionGroupId, 0); }
  public static void AddTreasureNormalVariationAmount(FlatBufferBuilder builder, int treasureNormalVariationAmount) { builder.AddInt(9, treasureNormalVariationAmount, 0); }
  public static void AddTreasureLoopVariationAmount(FlatBufferBuilder builder, int treasureLoopVariationAmount) { builder.AddInt(10, treasureLoopVariationAmount, 0); }
  public static void AddTreasureLimitVariationLoopCount(FlatBufferBuilder builder, int treasureLimitVariationLoopCount) { builder.AddInt(11, treasureLimitVariationLoopCount, 0); }
  public static void AddTreasureLimitVariationClearLoopCount(FlatBufferBuilder builder, int treasureLimitVariationClearLoopCount) { builder.AddInt(12, treasureLimitVariationClearLoopCount, 0); }
  public static Offset<FlatData.ConstEventCommonExcel> EndConstEventCommonExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.ConstEventCommonExcel>(o);
  }
  public ConstEventCommonExcelT UnPack() {
    var _o = new ConstEventCommonExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ConstEventCommonExcelT _o) {
    _o.EventContentHardStageCount = this.EventContentHardStageCount;
    _o.EventStrategyPlayTimeLimitInSeconds = this.EventStrategyPlayTimeLimitInSeconds;
    _o.SubEventChangeLimitSeconds = this.SubEventChangeLimitSeconds;
    _o.SubEventInstantClear = this.SubEventInstantClear;
    _o.CardShopProbWeightCount = this.CardShopProbWeightCount;
    _o.CardShopProbWeightRarity = this.CardShopProbWeightRarity;
    _o.MeetupScenarioReplayResource = this.MeetupScenarioReplayResource;
    _o.MeetupScenarioReplayTitleLocalize = this.MeetupScenarioReplayTitleLocalize;
    _o.SpecialOperactionCollectionGroupId = this.SpecialOperactionCollectionGroupId;
    _o.TreasureNormalVariationAmount = this.TreasureNormalVariationAmount;
    _o.TreasureLoopVariationAmount = this.TreasureLoopVariationAmount;
    _o.TreasureLimitVariationLoopCount = this.TreasureLimitVariationLoopCount;
    _o.TreasureLimitVariationClearLoopCount = this.TreasureLimitVariationClearLoopCount;
  }
  public static Offset<FlatData.ConstEventCommonExcel> Pack(FlatBufferBuilder builder, ConstEventCommonExcelT _o) {
    if (_o == null) return default(Offset<FlatData.ConstEventCommonExcel>);
    var _MeetupScenarioReplayResource = _o.MeetupScenarioReplayResource == null ? default(StringOffset) : builder.CreateString(_o.MeetupScenarioReplayResource);
    var _MeetupScenarioReplayTitleLocalize = _o.MeetupScenarioReplayTitleLocalize == null ? default(StringOffset) : builder.CreateString(_o.MeetupScenarioReplayTitleLocalize);
    return CreateConstEventCommonExcel(
      builder,
      _o.EventContentHardStageCount,
      _o.EventStrategyPlayTimeLimitInSeconds,
      _o.SubEventChangeLimitSeconds,
      _o.SubEventInstantClear,
      _o.CardShopProbWeightCount,
      _o.CardShopProbWeightRarity,
      _MeetupScenarioReplayResource,
      _MeetupScenarioReplayTitleLocalize,
      _o.SpecialOperactionCollectionGroupId,
      _o.TreasureNormalVariationAmount,
      _o.TreasureLoopVariationAmount,
      _o.TreasureLimitVariationLoopCount,
      _o.TreasureLimitVariationClearLoopCount);
  }
}

public class ConstEventCommonExcelT
{
  [Newtonsoft.Json.JsonProperty("EventContentHardStageCount")]
  public int EventContentHardStageCount { get; set; }
  [Newtonsoft.Json.JsonProperty("EventStrategyPlayTimeLimitInSeconds")]
  public long EventStrategyPlayTimeLimitInSeconds { get; set; }
  [Newtonsoft.Json.JsonProperty("SubEventChangeLimitSeconds")]
  public long SubEventChangeLimitSeconds { get; set; }
  [Newtonsoft.Json.JsonProperty("SubEventInstantClear")]
  public bool SubEventInstantClear { get; set; }
  [Newtonsoft.Json.JsonProperty("CardShopProbWeightCount")]
  public long CardShopProbWeightCount { get; set; }
  [Newtonsoft.Json.JsonProperty("CardShopProbWeightRarity")]
  public FlatData.Rarity CardShopProbWeightRarity { get; set; }
  [Newtonsoft.Json.JsonProperty("MeetupScenarioReplayResource")]
  public string MeetupScenarioReplayResource { get; set; }
  [Newtonsoft.Json.JsonProperty("MeetupScenarioReplayTitleLocalize")]
  public string MeetupScenarioReplayTitleLocalize { get; set; }
  [Newtonsoft.Json.JsonProperty("SpecialOperactionCollectionGroupId")]
  public long SpecialOperactionCollectionGroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("TreasureNormalVariationAmount")]
  public int TreasureNormalVariationAmount { get; set; }
  [Newtonsoft.Json.JsonProperty("TreasureLoopVariationAmount")]
  public int TreasureLoopVariationAmount { get; set; }
  [Newtonsoft.Json.JsonProperty("TreasureLimitVariationLoopCount")]
  public int TreasureLimitVariationLoopCount { get; set; }
  [Newtonsoft.Json.JsonProperty("TreasureLimitVariationClearLoopCount")]
  public int TreasureLimitVariationClearLoopCount { get; set; }

  public ConstEventCommonExcelT() {
    this.EventContentHardStageCount = 0;
    this.EventStrategyPlayTimeLimitInSeconds = 0;
    this.SubEventChangeLimitSeconds = 0;
    this.SubEventInstantClear = false;
    this.CardShopProbWeightCount = 0;
    this.CardShopProbWeightRarity = FlatData.Rarity.N;
    this.MeetupScenarioReplayResource = null;
    this.MeetupScenarioReplayTitleLocalize = null;
    this.SpecialOperactionCollectionGroupId = 0;
    this.TreasureNormalVariationAmount = 0;
    this.TreasureLoopVariationAmount = 0;
    this.TreasureLimitVariationLoopCount = 0;
    this.TreasureLimitVariationClearLoopCount = 0;
  }
}


static public class ConstEventCommonExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentHardStageCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*EventStrategyPlayTimeLimitInSeconds*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*SubEventChangeLimitSeconds*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*SubEventInstantClear*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 12 /*CardShopProbWeightCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*CardShopProbWeightRarity*/, 4 /*FlatData.Rarity*/, 4, false)
      && verifier.VerifyString(tablePos, 16 /*MeetupScenarioReplayResource*/, false)
      && verifier.VerifyString(tablePos, 18 /*MeetupScenarioReplayTitleLocalize*/, false)
      && verifier.VerifyField(tablePos, 20 /*SpecialOperactionCollectionGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 22 /*TreasureNormalVariationAmount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*TreasureLoopVariationAmount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*TreasureLimitVariationLoopCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 28 /*TreasureLimitVariationClearLoopCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
