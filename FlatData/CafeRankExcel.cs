// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CafeRankExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CafeRankExcel GetRootAsCafeRankExcel(ByteBuffer _bb) { return GetRootAsCafeRankExcel(_bb, new CafeRankExcel()); }
  public static CafeRankExcel GetRootAsCafeRankExcel(ByteBuffer _bb, CafeRankExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CafeRankExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long CafeId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Rank { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RecipeId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ComfortMax { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long TagCountMax { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int CharacterVisitMin { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CharacterVisitMax { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CafeVisitWeightBase { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CafeVisitWeightTagBonusStep(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int CafeVisitWeightTagBonusStepLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetCafeVisitWeightTagBonusStepBytes() { return __p.__vector_as_span<int>(20, 4); }
#else
  public ArraySegment<byte>? GetCafeVisitWeightTagBonusStepBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public int[] GetCafeVisitWeightTagBonusStepArray() { return __p.__vector_as_array<int>(20); }
  public int CafeVisitWeightTagBonus(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int CafeVisitWeightTagBonusLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetCafeVisitWeightTagBonusBytes() { return __p.__vector_as_span<int>(22, 4); }
#else
  public ArraySegment<byte>? GetCafeVisitWeightTagBonusBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public int[] GetCafeVisitWeightTagBonusArray() { return __p.__vector_as_array<int>(22); }

  public static Offset<FlatData.CafeRankExcel> CreateCafeRankExcel(FlatBufferBuilder builder,
      long CafeId = 0,
      long Rank = 0,
      long RecipeId = 0,
      long ComfortMax = 0,
      long TagCountMax = 0,
      int CharacterVisitMin = 0,
      int CharacterVisitMax = 0,
      int CafeVisitWeightBase = 0,
      VectorOffset CafeVisitWeightTagBonusStepOffset = default(VectorOffset),
      VectorOffset CafeVisitWeightTagBonusOffset = default(VectorOffset)) {
    builder.StartTable(10);
    CafeRankExcel.AddTagCountMax(builder, TagCountMax);
    CafeRankExcel.AddComfortMax(builder, ComfortMax);
    CafeRankExcel.AddRecipeId(builder, RecipeId);
    CafeRankExcel.AddRank(builder, Rank);
    CafeRankExcel.AddCafeId(builder, CafeId);
    CafeRankExcel.AddCafeVisitWeightTagBonus(builder, CafeVisitWeightTagBonusOffset);
    CafeRankExcel.AddCafeVisitWeightTagBonusStep(builder, CafeVisitWeightTagBonusStepOffset);
    CafeRankExcel.AddCafeVisitWeightBase(builder, CafeVisitWeightBase);
    CafeRankExcel.AddCharacterVisitMax(builder, CharacterVisitMax);
    CafeRankExcel.AddCharacterVisitMin(builder, CharacterVisitMin);
    return CafeRankExcel.EndCafeRankExcel(builder);
  }

  public static void StartCafeRankExcel(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddCafeId(FlatBufferBuilder builder, long cafeId) { builder.AddLong(0, cafeId, 0); }
  public static void AddRank(FlatBufferBuilder builder, long rank) { builder.AddLong(1, rank, 0); }
  public static void AddRecipeId(FlatBufferBuilder builder, long recipeId) { builder.AddLong(2, recipeId, 0); }
  public static void AddComfortMax(FlatBufferBuilder builder, long comfortMax) { builder.AddLong(3, comfortMax, 0); }
  public static void AddTagCountMax(FlatBufferBuilder builder, long tagCountMax) { builder.AddLong(4, tagCountMax, 0); }
  public static void AddCharacterVisitMin(FlatBufferBuilder builder, int characterVisitMin) { builder.AddInt(5, characterVisitMin, 0); }
  public static void AddCharacterVisitMax(FlatBufferBuilder builder, int characterVisitMax) { builder.AddInt(6, characterVisitMax, 0); }
  public static void AddCafeVisitWeightBase(FlatBufferBuilder builder, int cafeVisitWeightBase) { builder.AddInt(7, cafeVisitWeightBase, 0); }
  public static void AddCafeVisitWeightTagBonusStep(FlatBufferBuilder builder, VectorOffset cafeVisitWeightTagBonusStepOffset) { builder.AddOffset(8, cafeVisitWeightTagBonusStepOffset.Value, 0); }
  public static VectorOffset CreateCafeVisitWeightTagBonusStepVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCafeVisitWeightTagBonusStepVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCafeVisitWeightTagBonusStepVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCafeVisitWeightTagBonusStepVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCafeVisitWeightTagBonusStepVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCafeVisitWeightTagBonus(FlatBufferBuilder builder, VectorOffset cafeVisitWeightTagBonusOffset) { builder.AddOffset(9, cafeVisitWeightTagBonusOffset.Value, 0); }
  public static VectorOffset CreateCafeVisitWeightTagBonusVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCafeVisitWeightTagBonusVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCafeVisitWeightTagBonusVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCafeVisitWeightTagBonusVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCafeVisitWeightTagBonusVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatData.CafeRankExcel> EndCafeRankExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.CafeRankExcel>(o);
  }
  public CafeRankExcelT UnPack() {
    var _o = new CafeRankExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CafeRankExcelT _o) {
    _o.CafeId = this.CafeId;
    _o.Rank = this.Rank;
    _o.RecipeId = this.RecipeId;
    _o.ComfortMax = this.ComfortMax;
    _o.TagCountMax = this.TagCountMax;
    _o.CharacterVisitMin = this.CharacterVisitMin;
    _o.CharacterVisitMax = this.CharacterVisitMax;
    _o.CafeVisitWeightBase = this.CafeVisitWeightBase;
    _o.CafeVisitWeightTagBonusStep = new List<int>();
    for (var _j = 0; _j < this.CafeVisitWeightTagBonusStepLength; ++_j) {_o.CafeVisitWeightTagBonusStep.Add(this.CafeVisitWeightTagBonusStep(_j));}
    _o.CafeVisitWeightTagBonus = new List<int>();
    for (var _j = 0; _j < this.CafeVisitWeightTagBonusLength; ++_j) {_o.CafeVisitWeightTagBonus.Add(this.CafeVisitWeightTagBonus(_j));}
  }
  public static Offset<FlatData.CafeRankExcel> Pack(FlatBufferBuilder builder, CafeRankExcelT _o) {
    if (_o == null) return default(Offset<FlatData.CafeRankExcel>);
    var _CafeVisitWeightTagBonusStep = default(VectorOffset);
    if (_o.CafeVisitWeightTagBonusStep != null) {
      var __CafeVisitWeightTagBonusStep = _o.CafeVisitWeightTagBonusStep.ToArray();
      _CafeVisitWeightTagBonusStep = CreateCafeVisitWeightTagBonusStepVector(builder, __CafeVisitWeightTagBonusStep);
    }
    var _CafeVisitWeightTagBonus = default(VectorOffset);
    if (_o.CafeVisitWeightTagBonus != null) {
      var __CafeVisitWeightTagBonus = _o.CafeVisitWeightTagBonus.ToArray();
      _CafeVisitWeightTagBonus = CreateCafeVisitWeightTagBonusVector(builder, __CafeVisitWeightTagBonus);
    }
    return CreateCafeRankExcel(
      builder,
      _o.CafeId,
      _o.Rank,
      _o.RecipeId,
      _o.ComfortMax,
      _o.TagCountMax,
      _o.CharacterVisitMin,
      _o.CharacterVisitMax,
      _o.CafeVisitWeightBase,
      _CafeVisitWeightTagBonusStep,
      _CafeVisitWeightTagBonus);
  }
}

public class CafeRankExcelT
{
  [Newtonsoft.Json.JsonProperty("CafeId")]
  public long CafeId { get; set; }
  [Newtonsoft.Json.JsonProperty("Rank")]
  public long Rank { get; set; }
  [Newtonsoft.Json.JsonProperty("RecipeId")]
  public long RecipeId { get; set; }
  [Newtonsoft.Json.JsonProperty("ComfortMax")]
  public long ComfortMax { get; set; }
  [Newtonsoft.Json.JsonProperty("TagCountMax")]
  public long TagCountMax { get; set; }
  [Newtonsoft.Json.JsonProperty("CharacterVisitMin")]
  public int CharacterVisitMin { get; set; }
  [Newtonsoft.Json.JsonProperty("CharacterVisitMax")]
  public int CharacterVisitMax { get; set; }
  [Newtonsoft.Json.JsonProperty("CafeVisitWeightBase")]
  public int CafeVisitWeightBase { get; set; }
  [Newtonsoft.Json.JsonProperty("CafeVisitWeightTagBonusStep")]
  public List<int> CafeVisitWeightTagBonusStep { get; set; }
  [Newtonsoft.Json.JsonProperty("CafeVisitWeightTagBonus")]
  public List<int> CafeVisitWeightTagBonus { get; set; }

  public CafeRankExcelT() {
    this.CafeId = 0;
    this.Rank = 0;
    this.RecipeId = 0;
    this.ComfortMax = 0;
    this.TagCountMax = 0;
    this.CharacterVisitMin = 0;
    this.CharacterVisitMax = 0;
    this.CafeVisitWeightBase = 0;
    this.CafeVisitWeightTagBonusStep = null;
    this.CafeVisitWeightTagBonus = null;
  }
}


static public class CafeRankExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*CafeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Rank*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*RecipeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*ComfortMax*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*TagCountMax*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*CharacterVisitMin*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*CharacterVisitMax*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*CafeVisitWeightBase*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 20 /*CafeVisitWeightTagBonusStep*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfData(tablePos, 22 /*CafeVisitWeightTagBonus*/, 4 /*int*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}