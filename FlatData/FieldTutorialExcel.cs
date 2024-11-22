// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FieldTutorialExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FieldTutorialExcel GetRootAsFieldTutorialExcel(ByteBuffer _bb) { return GetRootAsFieldTutorialExcel(_bb, new FieldTutorialExcel()); }
  public static FieldTutorialExcel GetRootAsFieldTutorialExcel(ByteBuffer _bb, FieldTutorialExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FieldTutorialExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long SeasonId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.FieldTutorialType TutorialType(int j) { int o = __p.__offset(6); return o != 0 ? (FlatData.FieldTutorialType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatData.FieldTutorialType)0; }
  public int TutorialTypeLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatData.FieldTutorialType> GetTutorialTypeBytes() { return __p.__vector_as_span<FlatData.FieldTutorialType>(6, 4); }
#else
  public ArraySegment<byte>? GetTutorialTypeBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public FlatData.FieldTutorialType[] GetTutorialTypeArray() { int o = __p.__offset(6); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatData.FieldTutorialType[] a = new FlatData.FieldTutorialType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatData.FieldTutorialType)__p.bb.GetInt(p + i * 4); } return a; }
  public FlatData.FieldConditionType ConditionType(int j) { int o = __p.__offset(8); return o != 0 ? (FlatData.FieldConditionType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatData.FieldConditionType)0; }
  public int ConditionTypeLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatData.FieldConditionType> GetConditionTypeBytes() { return __p.__vector_as_span<FlatData.FieldConditionType>(8, 4); }
#else
  public ArraySegment<byte>? GetConditionTypeBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public FlatData.FieldConditionType[] GetConditionTypeArray() { int o = __p.__offset(8); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatData.FieldConditionType[] a = new FlatData.FieldConditionType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatData.FieldConditionType)__p.bb.GetInt(p + i * 4); } return a; }
  public long ConditionId(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ConditionIdLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetConditionIdBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetConditionIdBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetConditionIdArray() { return __p.__vector_as_array<long>(10); }

  public static Offset<FlatData.FieldTutorialExcel> CreateFieldTutorialExcel(FlatBufferBuilder builder,
      long SeasonId = 0,
      VectorOffset TutorialTypeOffset = default(VectorOffset),
      VectorOffset ConditionTypeOffset = default(VectorOffset),
      VectorOffset ConditionIdOffset = default(VectorOffset)) {
    builder.StartTable(4);
    FieldTutorialExcel.AddSeasonId(builder, SeasonId);
    FieldTutorialExcel.AddConditionId(builder, ConditionIdOffset);
    FieldTutorialExcel.AddConditionType(builder, ConditionTypeOffset);
    FieldTutorialExcel.AddTutorialType(builder, TutorialTypeOffset);
    return FieldTutorialExcel.EndFieldTutorialExcel(builder);
  }

  public static void StartFieldTutorialExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddSeasonId(FlatBufferBuilder builder, long seasonId) { builder.AddLong(0, seasonId, 0); }
  public static void AddTutorialType(FlatBufferBuilder builder, VectorOffset tutorialTypeOffset) { builder.AddOffset(1, tutorialTypeOffset.Value, 0); }
  public static VectorOffset CreateTutorialTypeVector(FlatBufferBuilder builder, FlatData.FieldTutorialType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateTutorialTypeVectorBlock(FlatBufferBuilder builder, FlatData.FieldTutorialType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTutorialTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatData.FieldTutorialType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTutorialTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatData.FieldTutorialType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTutorialTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddConditionType(FlatBufferBuilder builder, VectorOffset conditionTypeOffset) { builder.AddOffset(2, conditionTypeOffset.Value, 0); }
  public static VectorOffset CreateConditionTypeVector(FlatBufferBuilder builder, FlatData.FieldConditionType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConditionTypeVectorBlock(FlatBufferBuilder builder, FlatData.FieldConditionType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatData.FieldConditionType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatData.FieldConditionType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConditionTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddConditionId(FlatBufferBuilder builder, VectorOffset conditionIdOffset) { builder.AddOffset(3, conditionIdOffset.Value, 0); }
  public static VectorOffset CreateConditionIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConditionIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConditionIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConditionIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatData.FieldTutorialExcel> EndFieldTutorialExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.FieldTutorialExcel>(o);
  }
  public FieldTutorialExcelT UnPack() {
    var _o = new FieldTutorialExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FieldTutorialExcelT _o) {
    _o.SeasonId = this.SeasonId;
    _o.TutorialType = new List<FlatData.FieldTutorialType>();
    for (var _j = 0; _j < this.TutorialTypeLength; ++_j) {_o.TutorialType.Add(this.TutorialType(_j));}
    _o.ConditionType = new List<FlatData.FieldConditionType>();
    for (var _j = 0; _j < this.ConditionTypeLength; ++_j) {_o.ConditionType.Add(this.ConditionType(_j));}
    _o.ConditionId = new List<long>();
    for (var _j = 0; _j < this.ConditionIdLength; ++_j) {_o.ConditionId.Add(this.ConditionId(_j));}
  }
  public static Offset<FlatData.FieldTutorialExcel> Pack(FlatBufferBuilder builder, FieldTutorialExcelT _o) {
    if (_o == null) return default(Offset<FlatData.FieldTutorialExcel>);
    var _TutorialType = default(VectorOffset);
    if (_o.TutorialType != null) {
      var __TutorialType = _o.TutorialType.ToArray();
      _TutorialType = CreateTutorialTypeVector(builder, __TutorialType);
    }
    var _ConditionType = default(VectorOffset);
    if (_o.ConditionType != null) {
      var __ConditionType = _o.ConditionType.ToArray();
      _ConditionType = CreateConditionTypeVector(builder, __ConditionType);
    }
    var _ConditionId = default(VectorOffset);
    if (_o.ConditionId != null) {
      var __ConditionId = _o.ConditionId.ToArray();
      _ConditionId = CreateConditionIdVector(builder, __ConditionId);
    }
    return CreateFieldTutorialExcel(
      builder,
      _o.SeasonId,
      _TutorialType,
      _ConditionType,
      _ConditionId);
  }
}

public class FieldTutorialExcelT
{
  [Newtonsoft.Json.JsonProperty("SeasonId")]
  public long SeasonId { get; set; }
  [Newtonsoft.Json.JsonProperty("TutorialType")]
  public List<FlatData.FieldTutorialType> TutorialType { get; set; }
  [Newtonsoft.Json.JsonProperty("ConditionType")]
  public List<FlatData.FieldConditionType> ConditionType { get; set; }
  [Newtonsoft.Json.JsonProperty("ConditionId")]
  public List<long> ConditionId { get; set; }

  public FieldTutorialExcelT() {
    this.SeasonId = 0;
    this.TutorialType = null;
    this.ConditionType = null;
    this.ConditionId = null;
  }
}


static public class FieldTutorialExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*SeasonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 6 /*TutorialType*/, 4 /*FlatData.FieldTutorialType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*ConditionType*/, 4 /*FlatData.FieldConditionType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*ConditionId*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}