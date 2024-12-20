// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EliminateRaidStageSeasonRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EliminateRaidStageSeasonRewardExcel GetRootAsEliminateRaidStageSeasonRewardExcel(ByteBuffer _bb) { return GetRootAsEliminateRaidStageSeasonRewardExcel(_bb, new EliminateRaidStageSeasonRewardExcel()); }
  public static EliminateRaidStageSeasonRewardExcel GetRootAsEliminateRaidStageSeasonRewardExcel(ByteBuffer _bb, EliminateRaidStageSeasonRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EliminateRaidStageSeasonRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long SeasonRewardId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.ParcelType SeasonRewardParcelType(int j) { int o = __p.__offset(6); return o != 0 ? (FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatData.ParcelType)0; }
  public int SeasonRewardParcelTypeLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatData.ParcelType> GetSeasonRewardParcelTypeBytes() { return __p.__vector_as_span<FlatData.ParcelType>(6, 4); }
#else
  public ArraySegment<byte>? GetSeasonRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public FlatData.ParcelType[] GetSeasonRewardParcelTypeArray() { int o = __p.__offset(6); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatData.ParcelType[] a = new FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long SeasonRewardParcelUniqueId(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int SeasonRewardParcelUniqueIdLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetSeasonRewardParcelUniqueIdBytes() { return __p.__vector_as_span<long>(8, 8); }
#else
  public ArraySegment<byte>? GetSeasonRewardParcelUniqueIdBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public long[] GetSeasonRewardParcelUniqueIdArray() { return __p.__vector_as_array<long>(8); }
  public string SeasonRewardParcelUniqueName(int j) { int o = __p.__offset(10); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int SeasonRewardParcelUniqueNameLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
  public long SeasonRewardAmount(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int SeasonRewardAmountLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetSeasonRewardAmountBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetSeasonRewardAmountBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetSeasonRewardAmountArray() { return __p.__vector_as_array<long>(12); }

  public static Offset<FlatData.EliminateRaidStageSeasonRewardExcel> CreateEliminateRaidStageSeasonRewardExcel(FlatBufferBuilder builder,
      long SeasonRewardId = 0,
      VectorOffset SeasonRewardParcelTypeOffset = default(VectorOffset),
      VectorOffset SeasonRewardParcelUniqueIdOffset = default(VectorOffset),
      VectorOffset SeasonRewardParcelUniqueNameOffset = default(VectorOffset),
      VectorOffset SeasonRewardAmountOffset = default(VectorOffset)) {
    builder.StartTable(5);
    EliminateRaidStageSeasonRewardExcel.AddSeasonRewardId(builder, SeasonRewardId);
    EliminateRaidStageSeasonRewardExcel.AddSeasonRewardAmount(builder, SeasonRewardAmountOffset);
    EliminateRaidStageSeasonRewardExcel.AddSeasonRewardParcelUniqueName(builder, SeasonRewardParcelUniqueNameOffset);
    EliminateRaidStageSeasonRewardExcel.AddSeasonRewardParcelUniqueId(builder, SeasonRewardParcelUniqueIdOffset);
    EliminateRaidStageSeasonRewardExcel.AddSeasonRewardParcelType(builder, SeasonRewardParcelTypeOffset);
    return EliminateRaidStageSeasonRewardExcel.EndEliminateRaidStageSeasonRewardExcel(builder);
  }

  public static void StartEliminateRaidStageSeasonRewardExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddSeasonRewardId(FlatBufferBuilder builder, long seasonRewardId) { builder.AddLong(0, seasonRewardId, 0); }
  public static void AddSeasonRewardParcelType(FlatBufferBuilder builder, VectorOffset seasonRewardParcelTypeOffset) { builder.AddOffset(1, seasonRewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateSeasonRewardParcelTypeVector(FlatBufferBuilder builder, FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSeasonRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSeasonRewardParcelUniqueId(FlatBufferBuilder builder, VectorOffset seasonRewardParcelUniqueIdOffset) { builder.AddOffset(2, seasonRewardParcelUniqueIdOffset.Value, 0); }
  public static VectorOffset CreateSeasonRewardParcelUniqueIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardParcelUniqueIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardParcelUniqueIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardParcelUniqueIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSeasonRewardParcelUniqueIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddSeasonRewardParcelUniqueName(FlatBufferBuilder builder, VectorOffset seasonRewardParcelUniqueNameOffset) { builder.AddOffset(3, seasonRewardParcelUniqueNameOffset.Value, 0); }
  public static VectorOffset CreateSeasonRewardParcelUniqueNameVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardParcelUniqueNameVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardParcelUniqueNameVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardParcelUniqueNameVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSeasonRewardParcelUniqueNameVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSeasonRewardAmount(FlatBufferBuilder builder, VectorOffset seasonRewardAmountOffset) { builder.AddOffset(4, seasonRewardAmountOffset.Value, 0); }
  public static VectorOffset CreateSeasonRewardAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSeasonRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSeasonRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatData.EliminateRaidStageSeasonRewardExcel> EndEliminateRaidStageSeasonRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.EliminateRaidStageSeasonRewardExcel>(o);
  }
  public EliminateRaidStageSeasonRewardExcelT UnPack() {
    var _o = new EliminateRaidStageSeasonRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EliminateRaidStageSeasonRewardExcelT _o) {
    _o.SeasonRewardId = this.SeasonRewardId;
    _o.SeasonRewardParcelType = new List<FlatData.ParcelType>();
    for (var _j = 0; _j < this.SeasonRewardParcelTypeLength; ++_j) {_o.SeasonRewardParcelType.Add(this.SeasonRewardParcelType(_j));}
    _o.SeasonRewardParcelUniqueId = new List<long>();
    for (var _j = 0; _j < this.SeasonRewardParcelUniqueIdLength; ++_j) {_o.SeasonRewardParcelUniqueId.Add(this.SeasonRewardParcelUniqueId(_j));}
    _o.SeasonRewardParcelUniqueName = new List<string>();
    for (var _j = 0; _j < this.SeasonRewardParcelUniqueNameLength; ++_j) {_o.SeasonRewardParcelUniqueName.Add(this.SeasonRewardParcelUniqueName(_j));}
    _o.SeasonRewardAmount = new List<long>();
    for (var _j = 0; _j < this.SeasonRewardAmountLength; ++_j) {_o.SeasonRewardAmount.Add(this.SeasonRewardAmount(_j));}
  }
  public static Offset<FlatData.EliminateRaidStageSeasonRewardExcel> Pack(FlatBufferBuilder builder, EliminateRaidStageSeasonRewardExcelT _o) {
    if (_o == null) return default(Offset<FlatData.EliminateRaidStageSeasonRewardExcel>);
    var _SeasonRewardParcelType = default(VectorOffset);
    if (_o.SeasonRewardParcelType != null) {
      var __SeasonRewardParcelType = _o.SeasonRewardParcelType.ToArray();
      _SeasonRewardParcelType = CreateSeasonRewardParcelTypeVector(builder, __SeasonRewardParcelType);
    }
    var _SeasonRewardParcelUniqueId = default(VectorOffset);
    if (_o.SeasonRewardParcelUniqueId != null) {
      var __SeasonRewardParcelUniqueId = _o.SeasonRewardParcelUniqueId.ToArray();
      _SeasonRewardParcelUniqueId = CreateSeasonRewardParcelUniqueIdVector(builder, __SeasonRewardParcelUniqueId);
    }
    var _SeasonRewardParcelUniqueName = default(VectorOffset);
    if (_o.SeasonRewardParcelUniqueName != null) {
      var __SeasonRewardParcelUniqueName = new StringOffset[_o.SeasonRewardParcelUniqueName.Count];
      for (var _j = 0; _j < __SeasonRewardParcelUniqueName.Length; ++_j) { __SeasonRewardParcelUniqueName[_j] = builder.CreateString(_o.SeasonRewardParcelUniqueName[_j]); }
      _SeasonRewardParcelUniqueName = CreateSeasonRewardParcelUniqueNameVector(builder, __SeasonRewardParcelUniqueName);
    }
    var _SeasonRewardAmount = default(VectorOffset);
    if (_o.SeasonRewardAmount != null) {
      var __SeasonRewardAmount = _o.SeasonRewardAmount.ToArray();
      _SeasonRewardAmount = CreateSeasonRewardAmountVector(builder, __SeasonRewardAmount);
    }
    return CreateEliminateRaidStageSeasonRewardExcel(
      builder,
      _o.SeasonRewardId,
      _SeasonRewardParcelType,
      _SeasonRewardParcelUniqueId,
      _SeasonRewardParcelUniqueName,
      _SeasonRewardAmount);
  }
}

public class EliminateRaidStageSeasonRewardExcelT
{
  [Newtonsoft.Json.JsonProperty("SeasonRewardId")]
  public long SeasonRewardId { get; set; }
  [Newtonsoft.Json.JsonProperty("SeasonRewardParcelType")]
  public List<FlatData.ParcelType> SeasonRewardParcelType { get; set; }
  [Newtonsoft.Json.JsonProperty("SeasonRewardParcelUniqueId")]
  public List<long> SeasonRewardParcelUniqueId { get; set; }
  [Newtonsoft.Json.JsonProperty("SeasonRewardParcelUniqueName")]
  public List<string> SeasonRewardParcelUniqueName { get; set; }
  [Newtonsoft.Json.JsonProperty("SeasonRewardAmount")]
  public List<long> SeasonRewardAmount { get; set; }

  public EliminateRaidStageSeasonRewardExcelT() {
    this.SeasonRewardId = 0;
    this.SeasonRewardParcelType = null;
    this.SeasonRewardParcelUniqueId = null;
    this.SeasonRewardParcelUniqueName = null;
    this.SeasonRewardAmount = null;
  }
}


static public class EliminateRaidStageSeasonRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*SeasonRewardId*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 6 /*SeasonRewardParcelType*/, 4 /*FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*SeasonRewardParcelUniqueId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 10 /*SeasonRewardParcelUniqueName*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*SeasonRewardAmount*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
