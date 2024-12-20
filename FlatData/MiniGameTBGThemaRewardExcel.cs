// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MiniGameTBGThemaRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MiniGameTBGThemaRewardExcel GetRootAsMiniGameTBGThemaRewardExcel(ByteBuffer _bb) { return GetRootAsMiniGameTBGThemaRewardExcel(_bb, new MiniGameTBGThemaRewardExcel()); }
  public static MiniGameTBGThemaRewardExcel GetRootAsMiniGameTBGThemaRewardExcel(ByteBuffer _bb, MiniGameTBGThemaRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MiniGameTBGThemaRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int ThemaRound { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ThemaUniqueId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool IsLoop { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public FlatData.MiniGameTBGThemaRewardType MiniGameTBGThemaRewardType { get { int o = __p.__offset(12); return o != 0 ? (FlatData.MiniGameTBGThemaRewardType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.MiniGameTBGThemaRewardType.TreasureReward; } }
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
  public int RewardParcelAmount(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int RewardParcelAmountLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetRewardParcelAmountBytes() { return __p.__vector_as_span<int>(18, 4); }
#else
  public ArraySegment<byte>? GetRewardParcelAmountBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public int[] GetRewardParcelAmountArray() { return __p.__vector_as_array<int>(18); }

  public static Offset<FlatData.MiniGameTBGThemaRewardExcel> CreateMiniGameTBGThemaRewardExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      int ThemaRound = 0,
      int ThemaUniqueId = 0,
      bool IsLoop = false,
      FlatData.MiniGameTBGThemaRewardType MiniGameTBGThemaRewardType = FlatData.MiniGameTBGThemaRewardType.TreasureReward,
      VectorOffset RewardParcelTypeOffset = default(VectorOffset),
      VectorOffset RewardParcelIdOffset = default(VectorOffset),
      VectorOffset RewardParcelAmountOffset = default(VectorOffset)) {
    builder.StartTable(8);
    MiniGameTBGThemaRewardExcel.AddEventContentId(builder, EventContentId);
    MiniGameTBGThemaRewardExcel.AddRewardParcelAmount(builder, RewardParcelAmountOffset);
    MiniGameTBGThemaRewardExcel.AddRewardParcelId(builder, RewardParcelIdOffset);
    MiniGameTBGThemaRewardExcel.AddRewardParcelType(builder, RewardParcelTypeOffset);
    MiniGameTBGThemaRewardExcel.AddMiniGameTBGThemaRewardType(builder, MiniGameTBGThemaRewardType);
    MiniGameTBGThemaRewardExcel.AddThemaUniqueId(builder, ThemaUniqueId);
    MiniGameTBGThemaRewardExcel.AddThemaRound(builder, ThemaRound);
    MiniGameTBGThemaRewardExcel.AddIsLoop(builder, IsLoop);
    return MiniGameTBGThemaRewardExcel.EndMiniGameTBGThemaRewardExcel(builder);
  }

  public static void StartMiniGameTBGThemaRewardExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddThemaRound(FlatBufferBuilder builder, int themaRound) { builder.AddInt(1, themaRound, 0); }
  public static void AddThemaUniqueId(FlatBufferBuilder builder, int themaUniqueId) { builder.AddInt(2, themaUniqueId, 0); }
  public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop) { builder.AddBool(3, isLoop, false); }
  public static void AddMiniGameTBGThemaRewardType(FlatBufferBuilder builder, FlatData.MiniGameTBGThemaRewardType miniGameTBGThemaRewardType) { builder.AddInt(4, (int)miniGameTBGThemaRewardType, 0); }
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
  public static void AddRewardParcelAmount(FlatBufferBuilder builder, VectorOffset rewardParcelAmountOffset) { builder.AddOffset(7, rewardParcelAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelAmountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatData.MiniGameTBGThemaRewardExcel> EndMiniGameTBGThemaRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.MiniGameTBGThemaRewardExcel>(o);
  }
  public MiniGameTBGThemaRewardExcelT UnPack() {
    var _o = new MiniGameTBGThemaRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MiniGameTBGThemaRewardExcelT _o) {
    _o.EventContentId = this.EventContentId;
    _o.ThemaRound = this.ThemaRound;
    _o.ThemaUniqueId = this.ThemaUniqueId;
    _o.IsLoop = this.IsLoop;
    _o.MiniGameTBGThemaRewardType = this.MiniGameTBGThemaRewardType;
    _o.RewardParcelType = new List<FlatData.ParcelType>();
    for (var _j = 0; _j < this.RewardParcelTypeLength; ++_j) {_o.RewardParcelType.Add(this.RewardParcelType(_j));}
    _o.RewardParcelId = new List<long>();
    for (var _j = 0; _j < this.RewardParcelIdLength; ++_j) {_o.RewardParcelId.Add(this.RewardParcelId(_j));}
    _o.RewardParcelAmount = new List<int>();
    for (var _j = 0; _j < this.RewardParcelAmountLength; ++_j) {_o.RewardParcelAmount.Add(this.RewardParcelAmount(_j));}
  }
  public static Offset<FlatData.MiniGameTBGThemaRewardExcel> Pack(FlatBufferBuilder builder, MiniGameTBGThemaRewardExcelT _o) {
    if (_o == null) return default(Offset<FlatData.MiniGameTBGThemaRewardExcel>);
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
    return CreateMiniGameTBGThemaRewardExcel(
      builder,
      _o.EventContentId,
      _o.ThemaRound,
      _o.ThemaUniqueId,
      _o.IsLoop,
      _o.MiniGameTBGThemaRewardType,
      _RewardParcelType,
      _RewardParcelId,
      _RewardParcelAmount);
  }
}

public class MiniGameTBGThemaRewardExcelT
{
  [Newtonsoft.Json.JsonProperty("EventContentId")]
  public long EventContentId { get; set; }
  [Newtonsoft.Json.JsonProperty("ThemaRound")]
  public int ThemaRound { get; set; }
  [Newtonsoft.Json.JsonProperty("ThemaUniqueId")]
  public int ThemaUniqueId { get; set; }
  [Newtonsoft.Json.JsonProperty("IsLoop")]
  public bool IsLoop { get; set; }
  [Newtonsoft.Json.JsonProperty("MiniGameTBGThemaRewardType")]
  public FlatData.MiniGameTBGThemaRewardType MiniGameTBGThemaRewardType { get; set; }
  [Newtonsoft.Json.JsonProperty("RewardParcelType")]
  public List<FlatData.ParcelType> RewardParcelType { get; set; }
  [Newtonsoft.Json.JsonProperty("RewardParcelId")]
  public List<long> RewardParcelId { get; set; }
  [Newtonsoft.Json.JsonProperty("RewardParcelAmount")]
  public List<int> RewardParcelAmount { get; set; }

  public MiniGameTBGThemaRewardExcelT() {
    this.EventContentId = 0;
    this.ThemaRound = 0;
    this.ThemaUniqueId = 0;
    this.IsLoop = false;
    this.MiniGameTBGThemaRewardType = FlatData.MiniGameTBGThemaRewardType.TreasureReward;
    this.RewardParcelType = null;
    this.RewardParcelId = null;
    this.RewardParcelAmount = null;
  }
}


static public class MiniGameTBGThemaRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*ThemaRound*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*ThemaUniqueId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*IsLoop*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 12 /*MiniGameTBGThemaRewardType*/, 4 /*FlatData.MiniGameTBGThemaRewardType*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*RewardParcelType*/, 4 /*FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*RewardParcelId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 18 /*RewardParcelAmount*/, 4 /*int*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
