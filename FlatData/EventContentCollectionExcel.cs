// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentCollectionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentCollectionExcel GetRootAsEventContentCollectionExcel(ByteBuffer _bb) { return GetRootAsEventContentCollectionExcel(_bb, new EventContentCollectionExcel()); }
  public static EventContentCollectionExcel GetRootAsEventContentCollectionExcel(ByteBuffer _bb, EventContentCollectionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentCollectionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventContentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GroupId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.EventCollectionUnlockType UnlockConditionType { get { int o = __p.__offset(10); return o != 0 ? (FlatData.EventCollectionUnlockType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.EventCollectionUnlockType.None; } }
  public long UnlockConditionParameter(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int UnlockConditionParameterLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetUnlockConditionParameterBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetUnlockConditionParameterBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetUnlockConditionParameterArray() { return __p.__vector_as_array<long>(12); }
  public FlatData.MultipleConditionCheckType MultipleConditionCheckType { get { int o = __p.__offset(14); return o != 0 ? (FlatData.MultipleConditionCheckType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.MultipleConditionCheckType.And; } }
  public long UnlockConditionCount { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsObject { get { int o = __p.__offset(18); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsHorizon { get { int o = __p.__offset(20); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string EmblemResource { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEmblemResourceBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetEmblemResourceBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetEmblemResourceArray() { return __p.__vector_as_array<byte>(22); }
  public string ThumbResource { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetThumbResourceBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetThumbResourceBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetThumbResourceArray() { return __p.__vector_as_array<byte>(24); }
  public string FullResource { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetFullResourceBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetFullResourceBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetFullResourceArray() { return __p.__vector_as_array<byte>(26); }
  public uint LocalizeEtcId { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string SubNameLocalizeCodeId { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSubNameLocalizeCodeIdBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetSubNameLocalizeCodeIdBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetSubNameLocalizeCodeIdArray() { return __p.__vector_as_array<byte>(30); }

  public static Offset<FlatData.EventContentCollectionExcel> CreateEventContentCollectionExcel(FlatBufferBuilder builder,
      long Id = 0,
      long EventContentId = 0,
      long GroupId = 0,
      FlatData.EventCollectionUnlockType UnlockConditionType = FlatData.EventCollectionUnlockType.None,
      VectorOffset UnlockConditionParameterOffset = default(VectorOffset),
      FlatData.MultipleConditionCheckType MultipleConditionCheckType = FlatData.MultipleConditionCheckType.And,
      long UnlockConditionCount = 0,
      bool IsObject = false,
      bool IsHorizon = false,
      StringOffset EmblemResourceOffset = default(StringOffset),
      StringOffset ThumbResourceOffset = default(StringOffset),
      StringOffset FullResourceOffset = default(StringOffset),
      uint LocalizeEtcId = 0,
      StringOffset SubNameLocalizeCodeIdOffset = default(StringOffset)) {
    builder.StartTable(14);
    EventContentCollectionExcel.AddUnlockConditionCount(builder, UnlockConditionCount);
    EventContentCollectionExcel.AddGroupId(builder, GroupId);
    EventContentCollectionExcel.AddEventContentId(builder, EventContentId);
    EventContentCollectionExcel.AddId(builder, Id);
    EventContentCollectionExcel.AddSubNameLocalizeCodeId(builder, SubNameLocalizeCodeIdOffset);
    EventContentCollectionExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    EventContentCollectionExcel.AddFullResource(builder, FullResourceOffset);
    EventContentCollectionExcel.AddThumbResource(builder, ThumbResourceOffset);
    EventContentCollectionExcel.AddEmblemResource(builder, EmblemResourceOffset);
    EventContentCollectionExcel.AddMultipleConditionCheckType(builder, MultipleConditionCheckType);
    EventContentCollectionExcel.AddUnlockConditionParameter(builder, UnlockConditionParameterOffset);
    EventContentCollectionExcel.AddUnlockConditionType(builder, UnlockConditionType);
    EventContentCollectionExcel.AddIsHorizon(builder, IsHorizon);
    EventContentCollectionExcel.AddIsObject(builder, IsObject);
    return EventContentCollectionExcel.EndEventContentCollectionExcel(builder);
  }

  public static void StartEventContentCollectionExcel(FlatBufferBuilder builder) { builder.StartTable(14); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(1, eventContentId, 0); }
  public static void AddGroupId(FlatBufferBuilder builder, long groupId) { builder.AddLong(2, groupId, 0); }
  public static void AddUnlockConditionType(FlatBufferBuilder builder, FlatData.EventCollectionUnlockType unlockConditionType) { builder.AddInt(3, (int)unlockConditionType, 0); }
  public static void AddUnlockConditionParameter(FlatBufferBuilder builder, VectorOffset unlockConditionParameterOffset) { builder.AddOffset(4, unlockConditionParameterOffset.Value, 0); }
  public static VectorOffset CreateUnlockConditionParameterVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateUnlockConditionParameterVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnlockConditionParameterVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateUnlockConditionParameterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartUnlockConditionParameterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddMultipleConditionCheckType(FlatBufferBuilder builder, FlatData.MultipleConditionCheckType multipleConditionCheckType) { builder.AddInt(5, (int)multipleConditionCheckType, 0); }
  public static void AddUnlockConditionCount(FlatBufferBuilder builder, long unlockConditionCount) { builder.AddLong(6, unlockConditionCount, 0); }
  public static void AddIsObject(FlatBufferBuilder builder, bool isObject) { builder.AddBool(7, isObject, false); }
  public static void AddIsHorizon(FlatBufferBuilder builder, bool isHorizon) { builder.AddBool(8, isHorizon, false); }
  public static void AddEmblemResource(FlatBufferBuilder builder, StringOffset emblemResourceOffset) { builder.AddOffset(9, emblemResourceOffset.Value, 0); }
  public static void AddThumbResource(FlatBufferBuilder builder, StringOffset thumbResourceOffset) { builder.AddOffset(10, thumbResourceOffset.Value, 0); }
  public static void AddFullResource(FlatBufferBuilder builder, StringOffset fullResourceOffset) { builder.AddOffset(11, fullResourceOffset.Value, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(12, localizeEtcId, 0); }
  public static void AddSubNameLocalizeCodeId(FlatBufferBuilder builder, StringOffset subNameLocalizeCodeIdOffset) { builder.AddOffset(13, subNameLocalizeCodeIdOffset.Value, 0); }
  public static Offset<FlatData.EventContentCollectionExcel> EndEventContentCollectionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.EventContentCollectionExcel>(o);
  }
  public EventContentCollectionExcelT UnPack() {
    var _o = new EventContentCollectionExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentCollectionExcelT _o) {
    _o.Id = this.Id;
    _o.EventContentId = this.EventContentId;
    _o.GroupId = this.GroupId;
    _o.UnlockConditionType = this.UnlockConditionType;
    _o.UnlockConditionParameter = new List<long>();
    for (var _j = 0; _j < this.UnlockConditionParameterLength; ++_j) {_o.UnlockConditionParameter.Add(this.UnlockConditionParameter(_j));}
    _o.MultipleConditionCheckType = this.MultipleConditionCheckType;
    _o.UnlockConditionCount = this.UnlockConditionCount;
    _o.IsObject = this.IsObject;
    _o.IsHorizon = this.IsHorizon;
    _o.EmblemResource = this.EmblemResource;
    _o.ThumbResource = this.ThumbResource;
    _o.FullResource = this.FullResource;
    _o.LocalizeEtcId = this.LocalizeEtcId;
    _o.SubNameLocalizeCodeId = this.SubNameLocalizeCodeId;
  }
  public static Offset<FlatData.EventContentCollectionExcel> Pack(FlatBufferBuilder builder, EventContentCollectionExcelT _o) {
    if (_o == null) return default(Offset<FlatData.EventContentCollectionExcel>);
    var _UnlockConditionParameter = default(VectorOffset);
    if (_o.UnlockConditionParameter != null) {
      var __UnlockConditionParameter = _o.UnlockConditionParameter.ToArray();
      _UnlockConditionParameter = CreateUnlockConditionParameterVector(builder, __UnlockConditionParameter);
    }
    var _EmblemResource = _o.EmblemResource == null ? default(StringOffset) : builder.CreateString(_o.EmblemResource);
    var _ThumbResource = _o.ThumbResource == null ? default(StringOffset) : builder.CreateString(_o.ThumbResource);
    var _FullResource = _o.FullResource == null ? default(StringOffset) : builder.CreateString(_o.FullResource);
    var _SubNameLocalizeCodeId = _o.SubNameLocalizeCodeId == null ? default(StringOffset) : builder.CreateString(_o.SubNameLocalizeCodeId);
    return CreateEventContentCollectionExcel(
      builder,
      _o.Id,
      _o.EventContentId,
      _o.GroupId,
      _o.UnlockConditionType,
      _UnlockConditionParameter,
      _o.MultipleConditionCheckType,
      _o.UnlockConditionCount,
      _o.IsObject,
      _o.IsHorizon,
      _EmblemResource,
      _ThumbResource,
      _FullResource,
      _o.LocalizeEtcId,
      _SubNameLocalizeCodeId);
  }
}

public class EventContentCollectionExcelT
{
  [Newtonsoft.Json.JsonProperty("Id")]
  public long Id { get; set; }
  [Newtonsoft.Json.JsonProperty("EventContentId")]
  public long EventContentId { get; set; }
  [Newtonsoft.Json.JsonProperty("GroupId")]
  public long GroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("UnlockConditionType")]
  public FlatData.EventCollectionUnlockType UnlockConditionType { get; set; }
  [Newtonsoft.Json.JsonProperty("UnlockConditionParameter")]
  public List<long> UnlockConditionParameter { get; set; }
  [Newtonsoft.Json.JsonProperty("MultipleConditionCheckType")]
  public FlatData.MultipleConditionCheckType MultipleConditionCheckType { get; set; }
  [Newtonsoft.Json.JsonProperty("UnlockConditionCount")]
  public long UnlockConditionCount { get; set; }
  [Newtonsoft.Json.JsonProperty("IsObject")]
  public bool IsObject { get; set; }
  [Newtonsoft.Json.JsonProperty("IsHorizon")]
  public bool IsHorizon { get; set; }
  [Newtonsoft.Json.JsonProperty("EmblemResource")]
  public string EmblemResource { get; set; }
  [Newtonsoft.Json.JsonProperty("ThumbResource")]
  public string ThumbResource { get; set; }
  [Newtonsoft.Json.JsonProperty("FullResource")]
  public string FullResource { get; set; }
  [Newtonsoft.Json.JsonProperty("LocalizeEtcId")]
  public uint LocalizeEtcId { get; set; }
  [Newtonsoft.Json.JsonProperty("SubNameLocalizeCodeId")]
  public string SubNameLocalizeCodeId { get; set; }

  public EventContentCollectionExcelT() {
    this.Id = 0;
    this.EventContentId = 0;
    this.GroupId = 0;
    this.UnlockConditionType = FlatData.EventCollectionUnlockType.None;
    this.UnlockConditionParameter = null;
    this.MultipleConditionCheckType = FlatData.MultipleConditionCheckType.And;
    this.UnlockConditionCount = 0;
    this.IsObject = false;
    this.IsHorizon = false;
    this.EmblemResource = null;
    this.ThumbResource = null;
    this.FullResource = null;
    this.LocalizeEtcId = 0;
    this.SubNameLocalizeCodeId = null;
  }
}


static public class EventContentCollectionExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*GroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*UnlockConditionType*/, 4 /*FlatData.EventCollectionUnlockType*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*UnlockConditionParameter*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 14 /*MultipleConditionCheckType*/, 4 /*FlatData.MultipleConditionCheckType*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*UnlockConditionCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*IsObject*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 20 /*IsHorizon*/, 1 /*bool*/, 1, false)
      && verifier.VerifyString(tablePos, 22 /*EmblemResource*/, false)
      && verifier.VerifyString(tablePos, 24 /*ThumbResource*/, false)
      && verifier.VerifyString(tablePos, 26 /*FullResource*/, false)
      && verifier.VerifyField(tablePos, 28 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 30 /*SubNameLocalizeCodeId*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
