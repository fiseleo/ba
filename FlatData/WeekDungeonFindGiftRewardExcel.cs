// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct WeekDungeonFindGiftRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static WeekDungeonFindGiftRewardExcel GetRootAsWeekDungeonFindGiftRewardExcel(ByteBuffer _bb) { return GetRootAsWeekDungeonFindGiftRewardExcel(_bb, new WeekDungeonFindGiftRewardExcel()); }
  public static WeekDungeonFindGiftRewardExcel GetRootAsWeekDungeonFindGiftRewardExcel(ByteBuffer _bb, WeekDungeonFindGiftRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public WeekDungeonFindGiftRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long StageRewardId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string DevName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDevNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetDevNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetDevNameArray() { return __p.__vector_as_array<byte>(6); }
  public FlatData.ParcelType RewardParcelType(int j) { int o = __p.__offset(8); return o != 0 ? (FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatData.ParcelType)0; }
  public int RewardParcelTypeLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatData.ParcelType> GetRewardParcelTypeBytes() { return __p.__vector_as_span<FlatData.ParcelType>(8, 4); }
#else
  public ArraySegment<byte>? GetRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public FlatData.ParcelType[] GetRewardParcelTypeArray() { int o = __p.__offset(8); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatData.ParcelType[] a = new FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RewardParcelId(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelIdLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelIdBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelIdBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetRewardParcelIdArray() { return __p.__vector_as_array<long>(10); }
  public long RewardParcelAmount(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelAmountLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelAmountBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelAmountBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetRewardParcelAmountArray() { return __p.__vector_as_array<long>(12); }
  public long RewardParcelProbability(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelProbabilityLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelProbabilityBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelProbabilityBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetRewardParcelProbabilityArray() { return __p.__vector_as_array<long>(14); }
  public string DropItemModelPrefabPath(int j) { int o = __p.__offset(16); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int DropItemModelPrefabPathLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatData.WeekDungeonFindGiftRewardExcel> CreateWeekDungeonFindGiftRewardExcel(FlatBufferBuilder builder,
      long StageRewardId = 0,
      StringOffset DevNameOffset = default(StringOffset),
      VectorOffset RewardParcelTypeOffset = default(VectorOffset),
      VectorOffset RewardParcelIdOffset = default(VectorOffset),
      VectorOffset RewardParcelAmountOffset = default(VectorOffset),
      VectorOffset RewardParcelProbabilityOffset = default(VectorOffset),
      VectorOffset DropItemModelPrefabPathOffset = default(VectorOffset)) {
    builder.StartTable(7);
    WeekDungeonFindGiftRewardExcel.AddStageRewardId(builder, StageRewardId);
    WeekDungeonFindGiftRewardExcel.AddDropItemModelPrefabPath(builder, DropItemModelPrefabPathOffset);
    WeekDungeonFindGiftRewardExcel.AddRewardParcelProbability(builder, RewardParcelProbabilityOffset);
    WeekDungeonFindGiftRewardExcel.AddRewardParcelAmount(builder, RewardParcelAmountOffset);
    WeekDungeonFindGiftRewardExcel.AddRewardParcelId(builder, RewardParcelIdOffset);
    WeekDungeonFindGiftRewardExcel.AddRewardParcelType(builder, RewardParcelTypeOffset);
    WeekDungeonFindGiftRewardExcel.AddDevName(builder, DevNameOffset);
    return WeekDungeonFindGiftRewardExcel.EndWeekDungeonFindGiftRewardExcel(builder);
  }

  public static void StartWeekDungeonFindGiftRewardExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddStageRewardId(FlatBufferBuilder builder, long stageRewardId) { builder.AddLong(0, stageRewardId, 0); }
  public static void AddDevName(FlatBufferBuilder builder, StringOffset devNameOffset) { builder.AddOffset(1, devNameOffset.Value, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, VectorOffset rewardParcelTypeOffset) { builder.AddOffset(2, rewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelTypeVector(FlatBufferBuilder builder, FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, VectorOffset rewardParcelIdOffset) { builder.AddOffset(3, rewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelAmount(FlatBufferBuilder builder, VectorOffset rewardParcelAmountOffset) { builder.AddOffset(4, rewardParcelAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelProbability(FlatBufferBuilder builder, VectorOffset rewardParcelProbabilityOffset) { builder.AddOffset(5, rewardParcelProbabilityOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelProbabilityVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelProbabilityVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelProbabilityVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelProbabilityVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelProbabilityVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddDropItemModelPrefabPath(FlatBufferBuilder builder, VectorOffset dropItemModelPrefabPathOffset) { builder.AddOffset(6, dropItemModelPrefabPathOffset.Value, 0); }
  public static VectorOffset CreateDropItemModelPrefabPathVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDropItemModelPrefabPathVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDropItemModelPrefabPathVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDropItemModelPrefabPathVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDropItemModelPrefabPathVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatData.WeekDungeonFindGiftRewardExcel> EndWeekDungeonFindGiftRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.WeekDungeonFindGiftRewardExcel>(o);
  }
  public WeekDungeonFindGiftRewardExcelT UnPack() {
    var _o = new WeekDungeonFindGiftRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(WeekDungeonFindGiftRewardExcelT _o) {
    _o.StageRewardId = this.StageRewardId;
    _o.DevName = this.DevName;
    _o.RewardParcelType = new List<FlatData.ParcelType>();
    for (var _j = 0; _j < this.RewardParcelTypeLength; ++_j) {_o.RewardParcelType.Add(this.RewardParcelType(_j));}
    _o.RewardParcelId = new List<long>();
    for (var _j = 0; _j < this.RewardParcelIdLength; ++_j) {_o.RewardParcelId.Add(this.RewardParcelId(_j));}
    _o.RewardParcelAmount = new List<long>();
    for (var _j = 0; _j < this.RewardParcelAmountLength; ++_j) {_o.RewardParcelAmount.Add(this.RewardParcelAmount(_j));}
    _o.RewardParcelProbability = new List<long>();
    for (var _j = 0; _j < this.RewardParcelProbabilityLength; ++_j) {_o.RewardParcelProbability.Add(this.RewardParcelProbability(_j));}
    _o.DropItemModelPrefabPath = new List<string>();
    for (var _j = 0; _j < this.DropItemModelPrefabPathLength; ++_j) {_o.DropItemModelPrefabPath.Add(this.DropItemModelPrefabPath(_j));}
  }
  public static Offset<FlatData.WeekDungeonFindGiftRewardExcel> Pack(FlatBufferBuilder builder, WeekDungeonFindGiftRewardExcelT _o) {
    if (_o == null) return default(Offset<FlatData.WeekDungeonFindGiftRewardExcel>);
    var _DevName = _o.DevName == null ? default(StringOffset) : builder.CreateString(_o.DevName);
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
    var _RewardParcelAmount = default(VectorOffset);
    if (_o.RewardParcelAmount != null) {
      var __RewardParcelAmount = _o.RewardParcelAmount.ToArray();
      _RewardParcelAmount = CreateRewardParcelAmountVector(builder, __RewardParcelAmount);
    }
    var _RewardParcelProbability = default(VectorOffset);
    if (_o.RewardParcelProbability != null) {
      var __RewardParcelProbability = _o.RewardParcelProbability.ToArray();
      _RewardParcelProbability = CreateRewardParcelProbabilityVector(builder, __RewardParcelProbability);
    }
    var _DropItemModelPrefabPath = default(VectorOffset);
    if (_o.DropItemModelPrefabPath != null) {
      var __DropItemModelPrefabPath = new StringOffset[_o.DropItemModelPrefabPath.Count];
      for (var _j = 0; _j < __DropItemModelPrefabPath.Length; ++_j) { __DropItemModelPrefabPath[_j] = builder.CreateString(_o.DropItemModelPrefabPath[_j]); }
      _DropItemModelPrefabPath = CreateDropItemModelPrefabPathVector(builder, __DropItemModelPrefabPath);
    }
    return CreateWeekDungeonFindGiftRewardExcel(
      builder,
      _o.StageRewardId,
      _DevName,
      _RewardParcelType,
      _RewardParcelId,
      _RewardParcelAmount,
      _RewardParcelProbability,
      _DropItemModelPrefabPath);
  }
}

public class WeekDungeonFindGiftRewardExcelT
{
  [Newtonsoft.Json.JsonProperty("StageRewardId")]
  public long StageRewardId { get; set; }
  [Newtonsoft.Json.JsonProperty("DevName")]
  public string DevName { get; set; }
  [Newtonsoft.Json.JsonProperty("RewardParcelType")]
  public List<FlatData.ParcelType> RewardParcelType { get; set; }
  [Newtonsoft.Json.JsonProperty("RewardParcelId")]
  public List<long> RewardParcelId { get; set; }
  [Newtonsoft.Json.JsonProperty("RewardParcelAmount")]
  public List<long> RewardParcelAmount { get; set; }
  [Newtonsoft.Json.JsonProperty("RewardParcelProbability")]
  public List<long> RewardParcelProbability { get; set; }
  [Newtonsoft.Json.JsonProperty("DropItemModelPrefabPath")]
  public List<string> DropItemModelPrefabPath { get; set; }

  public WeekDungeonFindGiftRewardExcelT() {
    this.StageRewardId = 0;
    this.DevName = null;
    this.RewardParcelType = null;
    this.RewardParcelId = null;
    this.RewardParcelAmount = null;
    this.RewardParcelProbability = null;
    this.DropItemModelPrefabPath = null;
  }
}


static public class WeekDungeonFindGiftRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*StageRewardId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 6 /*DevName*/, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*RewardParcelType*/, 4 /*FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*RewardParcelId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*RewardParcelAmount*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*RewardParcelProbability*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 16 /*DropItemModelPrefabPath*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
