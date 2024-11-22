// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentCardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentCardExcel GetRootAsEventContentCardExcel(ByteBuffer _bb) { return GetRootAsEventContentCardExcel(_bb, new EventContentCardExcel()); }
  public static EventContentCardExcel GetRootAsEventContentCardExcel(ByteBuffer _bb, EventContentCardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentCardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int CardGroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long EventContentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string IconPath { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconPathBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetIconPathBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetIconPathArray() { return __p.__vector_as_array<byte>(10); }
  public string BackIconPath { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBackIconPathBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetBackIconPathBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetBackIconPathArray() { return __p.__vector_as_array<byte>(12); }
  public FlatData.ParcelType RewardParcelType(int j) { int o = __p.__offset(14); return o != 0 ? (FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatData.ParcelType)0; }
  public int RewardParcelTypeLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatData.ParcelType> GetRewardParcelTypeBytes() { return __p.__vector_as_span<FlatData.ParcelType>(14, 4); }
#else
  public ArraySegment<byte>? GetRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public FlatData.ParcelType[] GetRewardParcelTypeArray() { int o = __p.__offset(14); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatData.ParcelType[] a = new FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RewardParcelId(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelIdLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelIdBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelIdBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetRewardParcelIdArray() { return __p.__vector_as_array<long>(16); }

  public static Offset<FlatData.EventContentCardExcel> CreateEventContentCardExcel(FlatBufferBuilder builder,
      int CardGroupId = 0,
      long EventContentId = 0,
      uint LocalizeEtcId = 0,
      StringOffset IconPathOffset = default(StringOffset),
      StringOffset BackIconPathOffset = default(StringOffset),
      VectorOffset RewardParcelTypeOffset = default(VectorOffset),
      VectorOffset RewardParcelIdOffset = default(VectorOffset)) {
    builder.StartTable(7);
    EventContentCardExcel.AddEventContentId(builder, EventContentId);
    EventContentCardExcel.AddRewardParcelId(builder, RewardParcelIdOffset);
    EventContentCardExcel.AddRewardParcelType(builder, RewardParcelTypeOffset);
    EventContentCardExcel.AddBackIconPath(builder, BackIconPathOffset);
    EventContentCardExcel.AddIconPath(builder, IconPathOffset);
    EventContentCardExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    EventContentCardExcel.AddCardGroupId(builder, CardGroupId);
    return EventContentCardExcel.EndEventContentCardExcel(builder);
  }

  public static void StartEventContentCardExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddCardGroupId(FlatBufferBuilder builder, int cardGroupId) { builder.AddInt(0, cardGroupId, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(1, eventContentId, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(2, localizeEtcId, 0); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset iconPathOffset) { builder.AddOffset(3, iconPathOffset.Value, 0); }
  public static void AddBackIconPath(FlatBufferBuilder builder, StringOffset backIconPathOffset) { builder.AddOffset(4, backIconPathOffset.Value, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, VectorOffset rewardParcelTypeOffset) { builder.AddOffset(5, rewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelTypeVector(FlatBufferBuilder builder, FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, VectorOffset rewardParcelIdOffset) { builder.AddOffset(6, rewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatData.EventContentCardExcel> EndEventContentCardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.EventContentCardExcel>(o);
  }
  public EventContentCardExcelT UnPack() {
    var _o = new EventContentCardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentCardExcelT _o) {
    _o.CardGroupId = this.CardGroupId;
    _o.EventContentId = this.EventContentId;
    _o.LocalizeEtcId = this.LocalizeEtcId;
    _o.IconPath = this.IconPath;
    _o.BackIconPath = this.BackIconPath;
    _o.RewardParcelType = new List<FlatData.ParcelType>();
    for (var _j = 0; _j < this.RewardParcelTypeLength; ++_j) {_o.RewardParcelType.Add(this.RewardParcelType(_j));}
    _o.RewardParcelId = new List<long>();
    for (var _j = 0; _j < this.RewardParcelIdLength; ++_j) {_o.RewardParcelId.Add(this.RewardParcelId(_j));}
  }
  public static Offset<FlatData.EventContentCardExcel> Pack(FlatBufferBuilder builder, EventContentCardExcelT _o) {
    if (_o == null) return default(Offset<FlatData.EventContentCardExcel>);
    var _IconPath = _o.IconPath == null ? default(StringOffset) : builder.CreateString(_o.IconPath);
    var _BackIconPath = _o.BackIconPath == null ? default(StringOffset) : builder.CreateString(_o.BackIconPath);
    var _RewardParcelType = default(VectorOffset);
    if (_o.RewardParcelType != null) {
      var __RewardParcelType = _o.RewardParcelType.ToArray();
      _RewardParcelType = CreateRewardParcelTypeVector(builder, __RewardParcelType);
    }
    var _RewardParcelId = default(VectorOffset);
    if (_o.RewardParcelId != null) {
      var __RewardParcelId = _o.RewardParcelId.ToArray();
      _RewardParcelId = CreateRewardParcelIdVector(builder, __RewardParcelId);
    }
    return CreateEventContentCardExcel(
      builder,
      _o.CardGroupId,
      _o.EventContentId,
      _o.LocalizeEtcId,
      _IconPath,
      _BackIconPath,
      _RewardParcelType,
      _RewardParcelId);
  }
}

public class EventContentCardExcelT
{
  [Newtonsoft.Json.JsonProperty("CardGroupId")]
  public int CardGroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("EventContentId")]
  public long EventContentId { get; set; }
  [Newtonsoft.Json.JsonProperty("LocalizeEtcId")]
  public uint LocalizeEtcId { get; set; }
  [Newtonsoft.Json.JsonProperty("IconPath")]
  public string IconPath { get; set; }
  [Newtonsoft.Json.JsonProperty("BackIconPath")]
  public string BackIconPath { get; set; }
  [Newtonsoft.Json.JsonProperty("RewardParcelType")]
  public List<FlatData.ParcelType> RewardParcelType { get; set; }
  [Newtonsoft.Json.JsonProperty("RewardParcelId")]
  public List<long> RewardParcelId { get; set; }

  public EventContentCardExcelT() {
    this.CardGroupId = 0;
    this.EventContentId = 0;
    this.LocalizeEtcId = 0;
    this.IconPath = null;
    this.BackIconPath = null;
    this.RewardParcelType = null;
    this.RewardParcelId = null;
  }
}


static public class EventContentCardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*CardGroupId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*IconPath*/, false)
      && verifier.VerifyString(tablePos, 12 /*BackIconPath*/, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*RewardParcelType*/, 4 /*FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*RewardParcelId*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
