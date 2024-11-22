// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentBuffGroupExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentBuffGroupExcel GetRootAsEventContentBuffGroupExcel(ByteBuffer _bb) { return GetRootAsEventContentBuffGroupExcel(_bb, new EventContentBuffGroupExcel()); }
  public static EventContentBuffGroupExcel GetRootAsEventContentBuffGroupExcel(ByteBuffer _bb, EventContentBuffGroupExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentBuffGroupExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BuffContentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BuffGroupId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string BuffGroupNameLocalizeCodeId { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBuffGroupNameLocalizeCodeIdBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetBuffGroupNameLocalizeCodeIdBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetBuffGroupNameLocalizeCodeIdArray() { return __p.__vector_as_array<byte>(10); }
  public long EventContentBuffId1 { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string BuffNameLocalizeCodeId1 { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBuffNameLocalizeCodeId1Bytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetBuffNameLocalizeCodeId1Bytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetBuffNameLocalizeCodeId1Array() { return __p.__vector_as_array<byte>(14); }
  public string BuffDescriptionIconPath1 { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBuffDescriptionIconPath1Bytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetBuffDescriptionIconPath1Bytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetBuffDescriptionIconPath1Array() { return __p.__vector_as_array<byte>(16); }
  public long EventContentBuffId2 { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string BuffNameLocalizeCodeId2 { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBuffNameLocalizeCodeId2Bytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetBuffNameLocalizeCodeId2Bytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetBuffNameLocalizeCodeId2Array() { return __p.__vector_as_array<byte>(20); }
  public string BuffDescriptionIconPath2 { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBuffDescriptionIconPath2Bytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetBuffDescriptionIconPath2Bytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetBuffDescriptionIconPath2Array() { return __p.__vector_as_array<byte>(22); }
  public long EventContentDebuffId { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string DebuffNameLocalizeCodeId { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDebuffNameLocalizeCodeIdBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetDebuffNameLocalizeCodeIdBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetDebuffNameLocalizeCodeIdArray() { return __p.__vector_as_array<byte>(26); }
  public string DeBuffDescriptionIconPath { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDeBuffDescriptionIconPathBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetDeBuffDescriptionIconPathBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetDeBuffDescriptionIconPathArray() { return __p.__vector_as_array<byte>(28); }
  public long BuffGroupProb { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatData.EventContentBuffGroupExcel> CreateEventContentBuffGroupExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long BuffContentId = 0,
      long BuffGroupId = 0,
      StringOffset BuffGroupNameLocalizeCodeIdOffset = default(StringOffset),
      long EventContentBuffId1 = 0,
      StringOffset BuffNameLocalizeCodeId1Offset = default(StringOffset),
      StringOffset BuffDescriptionIconPath1Offset = default(StringOffset),
      long EventContentBuffId2 = 0,
      StringOffset BuffNameLocalizeCodeId2Offset = default(StringOffset),
      StringOffset BuffDescriptionIconPath2Offset = default(StringOffset),
      long EventContentDebuffId = 0,
      StringOffset DebuffNameLocalizeCodeIdOffset = default(StringOffset),
      StringOffset DeBuffDescriptionIconPathOffset = default(StringOffset),
      long BuffGroupProb = 0) {
    builder.StartTable(14);
    EventContentBuffGroupExcel.AddBuffGroupProb(builder, BuffGroupProb);
    EventContentBuffGroupExcel.AddEventContentDebuffId(builder, EventContentDebuffId);
    EventContentBuffGroupExcel.AddEventContentBuffId2(builder, EventContentBuffId2);
    EventContentBuffGroupExcel.AddEventContentBuffId1(builder, EventContentBuffId1);
    EventContentBuffGroupExcel.AddBuffGroupId(builder, BuffGroupId);
    EventContentBuffGroupExcel.AddBuffContentId(builder, BuffContentId);
    EventContentBuffGroupExcel.AddEventContentId(builder, EventContentId);
    EventContentBuffGroupExcel.AddDeBuffDescriptionIconPath(builder, DeBuffDescriptionIconPathOffset);
    EventContentBuffGroupExcel.AddDebuffNameLocalizeCodeId(builder, DebuffNameLocalizeCodeIdOffset);
    EventContentBuffGroupExcel.AddBuffDescriptionIconPath2(builder, BuffDescriptionIconPath2Offset);
    EventContentBuffGroupExcel.AddBuffNameLocalizeCodeId2(builder, BuffNameLocalizeCodeId2Offset);
    EventContentBuffGroupExcel.AddBuffDescriptionIconPath1(builder, BuffDescriptionIconPath1Offset);
    EventContentBuffGroupExcel.AddBuffNameLocalizeCodeId1(builder, BuffNameLocalizeCodeId1Offset);
    EventContentBuffGroupExcel.AddBuffGroupNameLocalizeCodeId(builder, BuffGroupNameLocalizeCodeIdOffset);
    return EventContentBuffGroupExcel.EndEventContentBuffGroupExcel(builder);
  }

  public static void StartEventContentBuffGroupExcel(FlatBufferBuilder builder) { builder.StartTable(14); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddBuffContentId(FlatBufferBuilder builder, long buffContentId) { builder.AddLong(1, buffContentId, 0); }
  public static void AddBuffGroupId(FlatBufferBuilder builder, long buffGroupId) { builder.AddLong(2, buffGroupId, 0); }
  public static void AddBuffGroupNameLocalizeCodeId(FlatBufferBuilder builder, StringOffset buffGroupNameLocalizeCodeIdOffset) { builder.AddOffset(3, buffGroupNameLocalizeCodeIdOffset.Value, 0); }
  public static void AddEventContentBuffId1(FlatBufferBuilder builder, long eventContentBuffId1) { builder.AddLong(4, eventContentBuffId1, 0); }
  public static void AddBuffNameLocalizeCodeId1(FlatBufferBuilder builder, StringOffset buffNameLocalizeCodeId1Offset) { builder.AddOffset(5, buffNameLocalizeCodeId1Offset.Value, 0); }
  public static void AddBuffDescriptionIconPath1(FlatBufferBuilder builder, StringOffset buffDescriptionIconPath1Offset) { builder.AddOffset(6, buffDescriptionIconPath1Offset.Value, 0); }
  public static void AddEventContentBuffId2(FlatBufferBuilder builder, long eventContentBuffId2) { builder.AddLong(7, eventContentBuffId2, 0); }
  public static void AddBuffNameLocalizeCodeId2(FlatBufferBuilder builder, StringOffset buffNameLocalizeCodeId2Offset) { builder.AddOffset(8, buffNameLocalizeCodeId2Offset.Value, 0); }
  public static void AddBuffDescriptionIconPath2(FlatBufferBuilder builder, StringOffset buffDescriptionIconPath2Offset) { builder.AddOffset(9, buffDescriptionIconPath2Offset.Value, 0); }
  public static void AddEventContentDebuffId(FlatBufferBuilder builder, long eventContentDebuffId) { builder.AddLong(10, eventContentDebuffId, 0); }
  public static void AddDebuffNameLocalizeCodeId(FlatBufferBuilder builder, StringOffset debuffNameLocalizeCodeIdOffset) { builder.AddOffset(11, debuffNameLocalizeCodeIdOffset.Value, 0); }
  public static void AddDeBuffDescriptionIconPath(FlatBufferBuilder builder, StringOffset deBuffDescriptionIconPathOffset) { builder.AddOffset(12, deBuffDescriptionIconPathOffset.Value, 0); }
  public static void AddBuffGroupProb(FlatBufferBuilder builder, long buffGroupProb) { builder.AddLong(13, buffGroupProb, 0); }
  public static Offset<FlatData.EventContentBuffGroupExcel> EndEventContentBuffGroupExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.EventContentBuffGroupExcel>(o);
  }
  public EventContentBuffGroupExcelT UnPack() {
    var _o = new EventContentBuffGroupExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentBuffGroupExcelT _o) {
    _o.EventContentId = this.EventContentId;
    _o.BuffContentId = this.BuffContentId;
    _o.BuffGroupId = this.BuffGroupId;
    _o.BuffGroupNameLocalizeCodeId = this.BuffGroupNameLocalizeCodeId;
    _o.EventContentBuffId1 = this.EventContentBuffId1;
    _o.BuffNameLocalizeCodeId1 = this.BuffNameLocalizeCodeId1;
    _o.BuffDescriptionIconPath1 = this.BuffDescriptionIconPath1;
    _o.EventContentBuffId2 = this.EventContentBuffId2;
    _o.BuffNameLocalizeCodeId2 = this.BuffNameLocalizeCodeId2;
    _o.BuffDescriptionIconPath2 = this.BuffDescriptionIconPath2;
    _o.EventContentDebuffId = this.EventContentDebuffId;
    _o.DebuffNameLocalizeCodeId = this.DebuffNameLocalizeCodeId;
    _o.DeBuffDescriptionIconPath = this.DeBuffDescriptionIconPath;
    _o.BuffGroupProb = this.BuffGroupProb;
  }
  public static Offset<FlatData.EventContentBuffGroupExcel> Pack(FlatBufferBuilder builder, EventContentBuffGroupExcelT _o) {
    if (_o == null) return default(Offset<FlatData.EventContentBuffGroupExcel>);
    var _BuffGroupNameLocalizeCodeId = _o.BuffGroupNameLocalizeCodeId == null ? default(StringOffset) : builder.CreateString(_o.BuffGroupNameLocalizeCodeId);
    var _BuffNameLocalizeCodeId1 = _o.BuffNameLocalizeCodeId1 == null ? default(StringOffset) : builder.CreateString(_o.BuffNameLocalizeCodeId1);
    var _BuffDescriptionIconPath1 = _o.BuffDescriptionIconPath1 == null ? default(StringOffset) : builder.CreateString(_o.BuffDescriptionIconPath1);
    var _BuffNameLocalizeCodeId2 = _o.BuffNameLocalizeCodeId2 == null ? default(StringOffset) : builder.CreateString(_o.BuffNameLocalizeCodeId2);
    var _BuffDescriptionIconPath2 = _o.BuffDescriptionIconPath2 == null ? default(StringOffset) : builder.CreateString(_o.BuffDescriptionIconPath2);
    var _DebuffNameLocalizeCodeId = _o.DebuffNameLocalizeCodeId == null ? default(StringOffset) : builder.CreateString(_o.DebuffNameLocalizeCodeId);
    var _DeBuffDescriptionIconPath = _o.DeBuffDescriptionIconPath == null ? default(StringOffset) : builder.CreateString(_o.DeBuffDescriptionIconPath);
    return CreateEventContentBuffGroupExcel(
      builder,
      _o.EventContentId,
      _o.BuffContentId,
      _o.BuffGroupId,
      _BuffGroupNameLocalizeCodeId,
      _o.EventContentBuffId1,
      _BuffNameLocalizeCodeId1,
      _BuffDescriptionIconPath1,
      _o.EventContentBuffId2,
      _BuffNameLocalizeCodeId2,
      _BuffDescriptionIconPath2,
      _o.EventContentDebuffId,
      _DebuffNameLocalizeCodeId,
      _DeBuffDescriptionIconPath,
      _o.BuffGroupProb);
  }
}

public class EventContentBuffGroupExcelT
{
  [Newtonsoft.Json.JsonProperty("EventContentId")]
  public long EventContentId { get; set; }
  [Newtonsoft.Json.JsonProperty("BuffContentId")]
  public long BuffContentId { get; set; }
  [Newtonsoft.Json.JsonProperty("BuffGroupId")]
  public long BuffGroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("BuffGroupNameLocalizeCodeId")]
  public string BuffGroupNameLocalizeCodeId { get; set; }
  [Newtonsoft.Json.JsonProperty("EventContentBuffId1")]
  public long EventContentBuffId1 { get; set; }
  [Newtonsoft.Json.JsonProperty("BuffNameLocalizeCodeId1")]
  public string BuffNameLocalizeCodeId1 { get; set; }
  [Newtonsoft.Json.JsonProperty("BuffDescriptionIconPath1")]
  public string BuffDescriptionIconPath1 { get; set; }
  [Newtonsoft.Json.JsonProperty("EventContentBuffId2")]
  public long EventContentBuffId2 { get; set; }
  [Newtonsoft.Json.JsonProperty("BuffNameLocalizeCodeId2")]
  public string BuffNameLocalizeCodeId2 { get; set; }
  [Newtonsoft.Json.JsonProperty("BuffDescriptionIconPath2")]
  public string BuffDescriptionIconPath2 { get; set; }
  [Newtonsoft.Json.JsonProperty("EventContentDebuffId")]
  public long EventContentDebuffId { get; set; }
  [Newtonsoft.Json.JsonProperty("DebuffNameLocalizeCodeId")]
  public string DebuffNameLocalizeCodeId { get; set; }
  [Newtonsoft.Json.JsonProperty("DeBuffDescriptionIconPath")]
  public string DeBuffDescriptionIconPath { get; set; }
  [Newtonsoft.Json.JsonProperty("BuffGroupProb")]
  public long BuffGroupProb { get; set; }

  public EventContentBuffGroupExcelT() {
    this.EventContentId = 0;
    this.BuffContentId = 0;
    this.BuffGroupId = 0;
    this.BuffGroupNameLocalizeCodeId = null;
    this.EventContentBuffId1 = 0;
    this.BuffNameLocalizeCodeId1 = null;
    this.BuffDescriptionIconPath1 = null;
    this.EventContentBuffId2 = 0;
    this.BuffNameLocalizeCodeId2 = null;
    this.BuffDescriptionIconPath2 = null;
    this.EventContentDebuffId = 0;
    this.DebuffNameLocalizeCodeId = null;
    this.DeBuffDescriptionIconPath = null;
    this.BuffGroupProb = 0;
  }
}


static public class EventContentBuffGroupExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*BuffContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*BuffGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 10 /*BuffGroupNameLocalizeCodeId*/, false)
      && verifier.VerifyField(tablePos, 12 /*EventContentBuffId1*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 14 /*BuffNameLocalizeCodeId1*/, false)
      && verifier.VerifyString(tablePos, 16 /*BuffDescriptionIconPath1*/, false)
      && verifier.VerifyField(tablePos, 18 /*EventContentBuffId2*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 20 /*BuffNameLocalizeCodeId2*/, false)
      && verifier.VerifyString(tablePos, 22 /*BuffDescriptionIconPath2*/, false)
      && verifier.VerifyField(tablePos, 24 /*EventContentDebuffId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 26 /*DebuffNameLocalizeCodeId*/, false)
      && verifier.VerifyString(tablePos, 28 /*DeBuffDescriptionIconPath*/, false)
      && verifier.VerifyField(tablePos, 30 /*BuffGroupProb*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
