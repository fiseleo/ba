// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RecipeExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static RecipeExcel GetRootAsRecipeExcel(ByteBuffer _bb) { return GetRootAsRecipeExcel(_bb, new RecipeExcel()); }
  public static RecipeExcel GetRootAsRecipeExcel(ByteBuffer _bb, RecipeExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RecipeExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.RecipeType RecipeType { get { int o = __p.__offset(6); return o != 0 ? (FlatData.RecipeType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.RecipeType.None; } }
  public long RecipeIngredientId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RecipeSelectionGroupId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.ParcelType ParcelType(int j) { int o = __p.__offset(12); return o != 0 ? (FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatData.ParcelType)0; }
  public int ParcelTypeLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatData.ParcelType> GetParcelTypeBytes() { return __p.__vector_as_span<FlatData.ParcelType>(12, 4); }
#else
  public ArraySegment<byte>? GetParcelTypeBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public FlatData.ParcelType[] GetParcelTypeArray() { int o = __p.__offset(12); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatData.ParcelType[] a = new FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long ParcelId(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ParcelIdLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetParcelIdBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetParcelIdBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetParcelIdArray() { return __p.__vector_as_array<long>(14); }
  public long ResultAmountMin(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ResultAmountMinLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetResultAmountMinBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetResultAmountMinBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetResultAmountMinArray() { return __p.__vector_as_array<long>(16); }
  public long ResultAmountMax(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ResultAmountMaxLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetResultAmountMaxBytes() { return __p.__vector_as_span<long>(18, 8); }
#else
  public ArraySegment<byte>? GetResultAmountMaxBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public long[] GetResultAmountMaxArray() { return __p.__vector_as_array<long>(18); }

  public static Offset<FlatData.RecipeExcel> CreateRecipeExcel(FlatBufferBuilder builder,
      long Id = 0,
      FlatData.RecipeType RecipeType = FlatData.RecipeType.None,
      long RecipeIngredientId = 0,
      long RecipeSelectionGroupId = 0,
      VectorOffset ParcelTypeOffset = default(VectorOffset),
      VectorOffset ParcelIdOffset = default(VectorOffset),
      VectorOffset ResultAmountMinOffset = default(VectorOffset),
      VectorOffset ResultAmountMaxOffset = default(VectorOffset)) {
    builder.StartTable(8);
    RecipeExcel.AddRecipeSelectionGroupId(builder, RecipeSelectionGroupId);
    RecipeExcel.AddRecipeIngredientId(builder, RecipeIngredientId);
    RecipeExcel.AddId(builder, Id);
    RecipeExcel.AddResultAmountMax(builder, ResultAmountMaxOffset);
    RecipeExcel.AddResultAmountMin(builder, ResultAmountMinOffset);
    RecipeExcel.AddParcelId(builder, ParcelIdOffset);
    RecipeExcel.AddParcelType(builder, ParcelTypeOffset);
    RecipeExcel.AddRecipeType(builder, RecipeType);
    return RecipeExcel.EndRecipeExcel(builder);
  }

  public static void StartRecipeExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddRecipeType(FlatBufferBuilder builder, FlatData.RecipeType recipeType) { builder.AddInt(1, (int)recipeType, 0); }
  public static void AddRecipeIngredientId(FlatBufferBuilder builder, long recipeIngredientId) { builder.AddLong(2, recipeIngredientId, 0); }
  public static void AddRecipeSelectionGroupId(FlatBufferBuilder builder, long recipeSelectionGroupId) { builder.AddLong(3, recipeSelectionGroupId, 0); }
  public static void AddParcelType(FlatBufferBuilder builder, VectorOffset parcelTypeOffset) { builder.AddOffset(4, parcelTypeOffset.Value, 0); }
  public static VectorOffset CreateParcelTypeVector(FlatBufferBuilder builder, FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateParcelTypeVectorBlock(FlatBufferBuilder builder, FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddParcelId(FlatBufferBuilder builder, VectorOffset parcelIdOffset) { builder.AddOffset(5, parcelIdOffset.Value, 0); }
  public static VectorOffset CreateParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddResultAmountMin(FlatBufferBuilder builder, VectorOffset resultAmountMinOffset) { builder.AddOffset(6, resultAmountMinOffset.Value, 0); }
  public static VectorOffset CreateResultAmountMinVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateResultAmountMinVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateResultAmountMinVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateResultAmountMinVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartResultAmountMinVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddResultAmountMax(FlatBufferBuilder builder, VectorOffset resultAmountMaxOffset) { builder.AddOffset(7, resultAmountMaxOffset.Value, 0); }
  public static VectorOffset CreateResultAmountMaxVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateResultAmountMaxVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateResultAmountMaxVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateResultAmountMaxVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartResultAmountMaxVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatData.RecipeExcel> EndRecipeExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.RecipeExcel>(o);
  }
  public RecipeExcelT UnPack() {
    var _o = new RecipeExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RecipeExcelT _o) {
    _o.Id = this.Id;
    _o.RecipeType = this.RecipeType;
    _o.RecipeIngredientId = this.RecipeIngredientId;
    _o.RecipeSelectionGroupId = this.RecipeSelectionGroupId;
    _o.ParcelType = new List<FlatData.ParcelType>();
    for (var _j = 0; _j < this.ParcelTypeLength; ++_j) {_o.ParcelType.Add(this.ParcelType(_j));}
    _o.ParcelId = new List<long>();
    for (var _j = 0; _j < this.ParcelIdLength; ++_j) {_o.ParcelId.Add(this.ParcelId(_j));}
    _o.ResultAmountMin = new List<long>();
    for (var _j = 0; _j < this.ResultAmountMinLength; ++_j) {_o.ResultAmountMin.Add(this.ResultAmountMin(_j));}
    _o.ResultAmountMax = new List<long>();
    for (var _j = 0; _j < this.ResultAmountMaxLength; ++_j) {_o.ResultAmountMax.Add(this.ResultAmountMax(_j));}
  }
  public static Offset<FlatData.RecipeExcel> Pack(FlatBufferBuilder builder, RecipeExcelT _o) {
    if (_o == null) return default(Offset<FlatData.RecipeExcel>);
    var _ParcelType = default(VectorOffset);
    if (_o.ParcelType != null) {
      var __ParcelType = _o.ParcelType.ToArray();
      _ParcelType = CreateParcelTypeVector(builder, __ParcelType);
    }
    var _ParcelId = default(VectorOffset);
    if (_o.ParcelId != null) {
      var __ParcelId = _o.ParcelId.ToArray();
      _ParcelId = CreateParcelIdVector(builder, __ParcelId);
    }
    var _ResultAmountMin = default(VectorOffset);
    if (_o.ResultAmountMin != null) {
      var __ResultAmountMin = _o.ResultAmountMin.ToArray();
      _ResultAmountMin = CreateResultAmountMinVector(builder, __ResultAmountMin);
    }
    var _ResultAmountMax = default(VectorOffset);
    if (_o.ResultAmountMax != null) {
      var __ResultAmountMax = _o.ResultAmountMax.ToArray();
      _ResultAmountMax = CreateResultAmountMaxVector(builder, __ResultAmountMax);
    }
    return CreateRecipeExcel(
      builder,
      _o.Id,
      _o.RecipeType,
      _o.RecipeIngredientId,
      _o.RecipeSelectionGroupId,
      _ParcelType,
      _ParcelId,
      _ResultAmountMin,
      _ResultAmountMax);
  }
}

public class RecipeExcelT
{
  [Newtonsoft.Json.JsonProperty("Id")]
  public long Id { get; set; }
  [Newtonsoft.Json.JsonProperty("RecipeType")]
  public FlatData.RecipeType RecipeType { get; set; }
  [Newtonsoft.Json.JsonProperty("RecipeIngredientId")]
  public long RecipeIngredientId { get; set; }
  [Newtonsoft.Json.JsonProperty("RecipeSelectionGroupId")]
  public long RecipeSelectionGroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("ParcelType")]
  public List<FlatData.ParcelType> ParcelType { get; set; }
  [Newtonsoft.Json.JsonProperty("ParcelId")]
  public List<long> ParcelId { get; set; }
  [Newtonsoft.Json.JsonProperty("ResultAmountMin")]
  public List<long> ResultAmountMin { get; set; }
  [Newtonsoft.Json.JsonProperty("ResultAmountMax")]
  public List<long> ResultAmountMax { get; set; }

  public RecipeExcelT() {
    this.Id = 0;
    this.RecipeType = FlatData.RecipeType.None;
    this.RecipeIngredientId = 0;
    this.RecipeSelectionGroupId = 0;
    this.ParcelType = null;
    this.ParcelId = null;
    this.ResultAmountMin = null;
    this.ResultAmountMax = null;
  }
}


static public class RecipeExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*RecipeType*/, 4 /*FlatData.RecipeType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*RecipeIngredientId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*RecipeSelectionGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*ParcelType*/, 4 /*FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*ParcelId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*ResultAmountMin*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 18 /*ResultAmountMax*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
