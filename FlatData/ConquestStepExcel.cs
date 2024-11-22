// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConquestStepExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ConquestStepExcel GetRootAsConquestStepExcel(ByteBuffer _bb) { return GetRootAsConquestStepExcel(_bb, new ConquestStepExcel()); }
  public static ConquestStepExcel GetRootAsConquestStepExcel(ByteBuffer _bb, ConquestStepExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestStepExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.StageDifficulty MapDifficulty { get { int o = __p.__offset(6); return o != 0 ? (FlatData.StageDifficulty)__p.bb.GetInt(o + __p.bb_pos) : FlatData.StageDifficulty.None; } }
  public int Step { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string StepGoalLocalize { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStepGoalLocalizeBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetStepGoalLocalizeBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetStepGoalLocalizeArray() { return __p.__vector_as_array<byte>(10); }
  public long StepEnterScenarioGroupId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.ParcelType StepEnterItemType { get { int o = __p.__offset(14); return o != 0 ? (FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.ParcelType.None; } }
  public long StepEnterItemUniqueId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StepEnterItemAmount { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long UnexpectedEventUnitId(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int UnexpectedEventUnitIdLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetUnexpectedEventUnitIdBytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetUnexpectedEventUnitIdBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetUnexpectedEventUnitIdArray() { return __p.__vector_as_array<long>(20); }
  public string UnexpectedEventPrefab { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUnexpectedEventPrefabBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetUnexpectedEventPrefabBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetUnexpectedEventPrefabArray() { return __p.__vector_as_array<byte>(22); }
  public long TreasureBoxObjectId { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int TreasureBoxCountPerStepOpen { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatData.ConquestStepExcel> CreateConquestStepExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      FlatData.StageDifficulty MapDifficulty = FlatData.StageDifficulty.None,
      int Step = 0,
      StringOffset StepGoalLocalizeOffset = default(StringOffset),
      long StepEnterScenarioGroupId = 0,
      FlatData.ParcelType StepEnterItemType = FlatData.ParcelType.None,
      long StepEnterItemUniqueId = 0,
      long StepEnterItemAmount = 0,
      VectorOffset UnexpectedEventUnitIdOffset = default(VectorOffset),
      StringOffset UnexpectedEventPrefabOffset = default(StringOffset),
      long TreasureBoxObjectId = 0,
      int TreasureBoxCountPerStepOpen = 0) {
    builder.StartTable(12);
    ConquestStepExcel.AddTreasureBoxObjectId(builder, TreasureBoxObjectId);
    ConquestStepExcel.AddStepEnterItemAmount(builder, StepEnterItemAmount);
    ConquestStepExcel.AddStepEnterItemUniqueId(builder, StepEnterItemUniqueId);
    ConquestStepExcel.AddStepEnterScenarioGroupId(builder, StepEnterScenarioGroupId);
    ConquestStepExcel.AddEventContentId(builder, EventContentId);
    ConquestStepExcel.AddTreasureBoxCountPerStepOpen(builder, TreasureBoxCountPerStepOpen);
    ConquestStepExcel.AddUnexpectedEventPrefab(builder, UnexpectedEventPrefabOffset);
    ConquestStepExcel.AddUnexpectedEventUnitId(builder, UnexpectedEventUnitIdOffset);
    ConquestStepExcel.AddStepEnterItemType(builder, StepEnterItemType);
    ConquestStepExcel.AddStepGoalLocalize(builder, StepGoalLocalizeOffset);
    ConquestStepExcel.AddStep(builder, Step);
    ConquestStepExcel.AddMapDifficulty(builder, MapDifficulty);
    return ConquestStepExcel.EndConquestStepExcel(builder);
  }

  public static void StartConquestStepExcel(FlatBufferBuilder builder) { builder.StartTable(12); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddMapDifficulty(FlatBufferBuilder builder, FlatData.StageDifficulty mapDifficulty) { builder.AddInt(1, (int)mapDifficulty, 0); }
  public static void AddStep(FlatBufferBuilder builder, int step) { builder.AddInt(2, step, 0); }
  public static void AddStepGoalLocalize(FlatBufferBuilder builder, StringOffset stepGoalLocalizeOffset) { builder.AddOffset(3, stepGoalLocalizeOffset.Value, 0); }
  public static void AddStepEnterScenarioGroupId(FlatBufferBuilder builder, long stepEnterScenarioGroupId) { builder.AddLong(4, stepEnterScenarioGroupId, 0); }
  public static void AddStepEnterItemType(FlatBufferBuilder builder, FlatData.ParcelType stepEnterItemType) { builder.AddInt(5, (int)stepEnterItemType, 0); }
  public static void AddStepEnterItemUniqueId(FlatBufferBuilder builder, long stepEnterItemUniqueId) { builder.AddLong(6, stepEnterItemUniqueId, 0); }
  public static void AddStepEnterItemAmount(FlatBufferBuilder builder, long stepEnterItemAmount) { builder.AddLong(7, stepEnterItemAmount, 0); }
  public static void AddUnexpectedEventUnitId(FlatBufferBuilder builder, VectorOffset unexpectedEventUnitIdOffset) { builder.AddOffset(8, unexpectedEventUnitIdOffset.Value, 0); }
  public static VectorOffset CreateUnexpectedEventUnitIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateUnexpectedEventUnitIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnexpectedEventUnitIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnexpectedEventUnitIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartUnexpectedEventUnitIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddUnexpectedEventPrefab(FlatBufferBuilder builder, StringOffset unexpectedEventPrefabOffset) { builder.AddOffset(9, unexpectedEventPrefabOffset.Value, 0); }
  public static void AddTreasureBoxObjectId(FlatBufferBuilder builder, long treasureBoxObjectId) { builder.AddLong(10, treasureBoxObjectId, 0); }
  public static void AddTreasureBoxCountPerStepOpen(FlatBufferBuilder builder, int treasureBoxCountPerStepOpen) { builder.AddInt(11, treasureBoxCountPerStepOpen, 0); }
  public static Offset<FlatData.ConquestStepExcel> EndConquestStepExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.ConquestStepExcel>(o);
  }
  public ConquestStepExcelT UnPack() {
    var _o = new ConquestStepExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ConquestStepExcelT _o) {
    _o.EventContentId = this.EventContentId;
    _o.MapDifficulty = this.MapDifficulty;
    _o.Step = this.Step;
    _o.StepGoalLocalize = this.StepGoalLocalize;
    _o.StepEnterScenarioGroupId = this.StepEnterScenarioGroupId;
    _o.StepEnterItemType = this.StepEnterItemType;
    _o.StepEnterItemUniqueId = this.StepEnterItemUniqueId;
    _o.StepEnterItemAmount = this.StepEnterItemAmount;
    _o.UnexpectedEventUnitId = new List<long>();
    for (var _j = 0; _j < this.UnexpectedEventUnitIdLength; ++_j) {_o.UnexpectedEventUnitId.Add(this.UnexpectedEventUnitId(_j));}
    _o.UnexpectedEventPrefab = this.UnexpectedEventPrefab;
    _o.TreasureBoxObjectId = this.TreasureBoxObjectId;
    _o.TreasureBoxCountPerStepOpen = this.TreasureBoxCountPerStepOpen;
  }
  public static Offset<FlatData.ConquestStepExcel> Pack(FlatBufferBuilder builder, ConquestStepExcelT _o) {
    if (_o == null) return default(Offset<FlatData.ConquestStepExcel>);
    var _StepGoalLocalize = _o.StepGoalLocalize == null ? default(StringOffset) : builder.CreateString(_o.StepGoalLocalize);
    var _UnexpectedEventUnitId = default(VectorOffset);
    if (_o.UnexpectedEventUnitId != null) {
      var __UnexpectedEventUnitId = _o.UnexpectedEventUnitId.ToArray();
      _UnexpectedEventUnitId = CreateUnexpectedEventUnitIdVector(builder, __UnexpectedEventUnitId);
    }
    var _UnexpectedEventPrefab = _o.UnexpectedEventPrefab == null ? default(StringOffset) : builder.CreateString(_o.UnexpectedEventPrefab);
    return CreateConquestStepExcel(
      builder,
      _o.EventContentId,
      _o.MapDifficulty,
      _o.Step,
      _StepGoalLocalize,
      _o.StepEnterScenarioGroupId,
      _o.StepEnterItemType,
      _o.StepEnterItemUniqueId,
      _o.StepEnterItemAmount,
      _UnexpectedEventUnitId,
      _UnexpectedEventPrefab,
      _o.TreasureBoxObjectId,
      _o.TreasureBoxCountPerStepOpen);
  }
}

public class ConquestStepExcelT
{
  [Newtonsoft.Json.JsonProperty("EventContentId")]
  public long EventContentId { get; set; }
  [Newtonsoft.Json.JsonProperty("MapDifficulty")]
  public FlatData.StageDifficulty MapDifficulty { get; set; }
  [Newtonsoft.Json.JsonProperty("Step")]
  public int Step { get; set; }
  [Newtonsoft.Json.JsonProperty("StepGoalLocalize")]
  public string StepGoalLocalize { get; set; }
  [Newtonsoft.Json.JsonProperty("StepEnterScenarioGroupId")]
  public long StepEnterScenarioGroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("StepEnterItemType")]
  public FlatData.ParcelType StepEnterItemType { get; set; }
  [Newtonsoft.Json.JsonProperty("StepEnterItemUniqueId")]
  public long StepEnterItemUniqueId { get; set; }
  [Newtonsoft.Json.JsonProperty("StepEnterItemAmount")]
  public long StepEnterItemAmount { get; set; }
  [Newtonsoft.Json.JsonProperty("UnexpectedEventUnitId")]
  public List<long> UnexpectedEventUnitId { get; set; }
  [Newtonsoft.Json.JsonProperty("UnexpectedEventPrefab")]
  public string UnexpectedEventPrefab { get; set; }
  [Newtonsoft.Json.JsonProperty("TreasureBoxObjectId")]
  public long TreasureBoxObjectId { get; set; }
  [Newtonsoft.Json.JsonProperty("TreasureBoxCountPerStepOpen")]
  public int TreasureBoxCountPerStepOpen { get; set; }

  public ConquestStepExcelT() {
    this.EventContentId = 0;
    this.MapDifficulty = FlatData.StageDifficulty.None;
    this.Step = 0;
    this.StepGoalLocalize = null;
    this.StepEnterScenarioGroupId = 0;
    this.StepEnterItemType = FlatData.ParcelType.None;
    this.StepEnterItemUniqueId = 0;
    this.StepEnterItemAmount = 0;
    this.UnexpectedEventUnitId = null;
    this.UnexpectedEventPrefab = null;
    this.TreasureBoxObjectId = 0;
    this.TreasureBoxCountPerStepOpen = 0;
  }
}


static public class ConquestStepExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*MapDifficulty*/, 4 /*FlatData.StageDifficulty*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Step*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*StepGoalLocalize*/, false)
      && verifier.VerifyField(tablePos, 12 /*StepEnterScenarioGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*StepEnterItemType*/, 4 /*FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*StepEnterItemUniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*StepEnterItemAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 20 /*UnexpectedEventUnitId*/, 8 /*long*/, false)
      && verifier.VerifyString(tablePos, 22 /*UnexpectedEventPrefab*/, false)
      && verifier.VerifyField(tablePos, 24 /*TreasureBoxObjectId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 26 /*TreasureBoxCountPerStepOpen*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}