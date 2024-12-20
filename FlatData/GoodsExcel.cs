// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GoodsExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static GoodsExcel GetRootAsGoodsExcel(ByteBuffer _bb) { return GetRootAsGoodsExcel(_bb, new GoodsExcel()); }
  public static GoodsExcel GetRootAsGoodsExcel(ByteBuffer _bb, GoodsExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GoodsExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int Type { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatData.Rarity Rarity { get { int o = __p.__offset(8); return o != 0 ? (FlatData.Rarity)__p.bb.GetInt(o + __p.bb_pos) : FlatData.Rarity.N; } }
  public string IconPath { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconPathBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetIconPathBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetIconPathArray() { return __p.__vector_as_array<byte>(10); }
  public FlatData.ParcelType ConsumeParcelType(int j) { int o = __p.__offset(12); return o != 0 ? (FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatData.ParcelType)0; }
  public int ConsumeParcelTypeLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatData.ParcelType> GetConsumeParcelTypeBytes() { return __p.__vector_as_span<FlatData.ParcelType>(12, 4); }
#else
  public ArraySegment<byte>? GetConsumeParcelTypeBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public FlatData.ParcelType[] GetConsumeParcelTypeArray() { int o = __p.__offset(12); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatData.ParcelType[] a = new FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long ConsumeParcelId(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ConsumeParcelIdLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetConsumeParcelIdBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetConsumeParcelIdBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetConsumeParcelIdArray() { return __p.__vector_as_array<long>(14); }
  public long ConsumeParcelAmount(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ConsumeParcelAmountLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetConsumeParcelAmountBytes() { return __p.__vector_as_span<long>(16, 8); }
#else
  public ArraySegment<byte>? GetConsumeParcelAmountBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public long[] GetConsumeParcelAmountArray() { return __p.__vector_as_array<long>(16); }
  public FlatData.ConsumeCondition ConsumeCondition(int j) { int o = __p.__offset(18); return o != 0 ? (FlatData.ConsumeCondition)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatData.ConsumeCondition)0; }
  public int ConsumeConditionLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatData.ConsumeCondition> GetConsumeConditionBytes() { return __p.__vector_as_span<FlatData.ConsumeCondition>(18, 4); }
#else
  public ArraySegment<byte>? GetConsumeConditionBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public FlatData.ConsumeCondition[] GetConsumeConditionArray() { int o = __p.__offset(18); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatData.ConsumeCondition[] a = new FlatData.ConsumeCondition[l]; for (int i = 0; i < l; i++) { a[i] = (FlatData.ConsumeCondition)__p.bb.GetInt(p + i * 4); } return a; }
  public FlatData.GachaTicketType ConsumeGachaTicketType { get { int o = __p.__offset(20); return o != 0 ? (FlatData.GachaTicketType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.GachaTicketType.None; } }
  public long ConsumeGachaTicketTypeAmount { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ProductIdAOS { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ProductIdiOS { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ConsumeExtraStep(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ConsumeExtraStepLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetConsumeExtraStepBytes() { return __p.__vector_as_span<long>(28, 8); }
#else
  public ArraySegment<byte>? GetConsumeExtraStepBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public long[] GetConsumeExtraStepArray() { return __p.__vector_as_array<long>(28); }
  public long ConsumeExtraAmount(int j) { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ConsumeExtraAmountLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetConsumeExtraAmountBytes() { return __p.__vector_as_span<long>(30, 8); }
#else
  public ArraySegment<byte>? GetConsumeExtraAmountBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public long[] GetConsumeExtraAmountArray() { return __p.__vector_as_array<long>(30); }
  public int State { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatData.ParcelType ParcelType(int j) { int o = __p.__offset(34); return o != 0 ? (FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatData.ParcelType)0; }
  public int ParcelTypeLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatData.ParcelType> GetParcelTypeBytes() { return __p.__vector_as_span<FlatData.ParcelType>(34, 4); }
#else
  public ArraySegment<byte>? GetParcelTypeBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public FlatData.ParcelType[] GetParcelTypeArray() { int o = __p.__offset(34); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatData.ParcelType[] a = new FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long ParcelId(int j) { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ParcelIdLength { get { int o = __p.__offset(36); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetParcelIdBytes() { return __p.__vector_as_span<long>(36, 8); }
#else
  public ArraySegment<byte>? GetParcelIdBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public long[] GetParcelIdArray() { return __p.__vector_as_array<long>(36); }
  public long ParcelAmount(int j) { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ParcelAmountLength { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetParcelAmountBytes() { return __p.__vector_as_span<long>(38, 8); }
#else
  public ArraySegment<byte>? GetParcelAmountBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public long[] GetParcelAmountArray() { return __p.__vector_as_array<long>(38); }

  public static Offset<FlatData.GoodsExcel> CreateGoodsExcel(FlatBufferBuilder builder,
      long Id = 0,
      int Type = 0,
      FlatData.Rarity Rarity = FlatData.Rarity.N,
      StringOffset IconPathOffset = default(StringOffset),
      VectorOffset ConsumeParcelTypeOffset = default(VectorOffset),
      VectorOffset ConsumeParcelIdOffset = default(VectorOffset),
      VectorOffset ConsumeParcelAmountOffset = default(VectorOffset),
      VectorOffset ConsumeConditionOffset = default(VectorOffset),
      FlatData.GachaTicketType ConsumeGachaTicketType = FlatData.GachaTicketType.None,
      long ConsumeGachaTicketTypeAmount = 0,
      long ProductIdAOS = 0,
      long ProductIdiOS = 0,
      VectorOffset ConsumeExtraStepOffset = default(VectorOffset),
      VectorOffset ConsumeExtraAmountOffset = default(VectorOffset),
      int State = 0,
      VectorOffset ParcelTypeOffset = default(VectorOffset),
      VectorOffset ParcelIdOffset = default(VectorOffset),
      VectorOffset ParcelAmountOffset = default(VectorOffset)) {
    builder.StartTable(18);
    GoodsExcel.AddProductIdiOS(builder, ProductIdiOS);
    GoodsExcel.AddProductIdAOS(builder, ProductIdAOS);
    GoodsExcel.AddConsumeGachaTicketTypeAmount(builder, ConsumeGachaTicketTypeAmount);
    GoodsExcel.AddId(builder, Id);
    GoodsExcel.AddParcelAmount(builder, ParcelAmountOffset);
    GoodsExcel.AddParcelId(builder, ParcelIdOffset);
    GoodsExcel.AddParcelType(builder, ParcelTypeOffset);
    GoodsExcel.AddState(builder, State);
    GoodsExcel.AddConsumeExtraAmount(builder, ConsumeExtraAmountOffset);
    GoodsExcel.AddConsumeExtraStep(builder, ConsumeExtraStepOffset);
    GoodsExcel.AddConsumeGachaTicketType(builder, ConsumeGachaTicketType);
    GoodsExcel.AddConsumeCondition(builder, ConsumeConditionOffset);
    GoodsExcel.AddConsumeParcelAmount(builder, ConsumeParcelAmountOffset);
    GoodsExcel.AddConsumeParcelId(builder, ConsumeParcelIdOffset);
    GoodsExcel.AddConsumeParcelType(builder, ConsumeParcelTypeOffset);
    GoodsExcel.AddIconPath(builder, IconPathOffset);
    GoodsExcel.AddRarity(builder, Rarity);
    GoodsExcel.AddType(builder, Type);
    return GoodsExcel.EndGoodsExcel(builder);
  }

  public static void StartGoodsExcel(FlatBufferBuilder builder) { builder.StartTable(18); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddType(FlatBufferBuilder builder, int type) { builder.AddInt(1, type, 0); }
  public static void AddRarity(FlatBufferBuilder builder, FlatData.Rarity rarity) { builder.AddInt(2, (int)rarity, 0); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset iconPathOffset) { builder.AddOffset(3, iconPathOffset.Value, 0); }
  public static void AddConsumeParcelType(FlatBufferBuilder builder, VectorOffset consumeParcelTypeOffset) { builder.AddOffset(4, consumeParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateConsumeParcelTypeVector(FlatBufferBuilder builder, FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConsumeParcelTypeVectorBlock(FlatBufferBuilder builder, FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConsumeParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddConsumeParcelId(FlatBufferBuilder builder, VectorOffset consumeParcelIdOffset) { builder.AddOffset(5, consumeParcelIdOffset.Value, 0); }
  public static VectorOffset CreateConsumeParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConsumeParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConsumeParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddConsumeParcelAmount(FlatBufferBuilder builder, VectorOffset consumeParcelAmountOffset) { builder.AddOffset(6, consumeParcelAmountOffset.Value, 0); }
  public static VectorOffset CreateConsumeParcelAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConsumeParcelAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeParcelAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeParcelAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConsumeParcelAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddConsumeCondition(FlatBufferBuilder builder, VectorOffset consumeConditionOffset) { builder.AddOffset(7, consumeConditionOffset.Value, 0); }
  public static VectorOffset CreateConsumeConditionVector(FlatBufferBuilder builder, FlatData.ConsumeCondition[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConsumeConditionVectorBlock(FlatBufferBuilder builder, FlatData.ConsumeCondition[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeConditionVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatData.ConsumeCondition> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeConditionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatData.ConsumeCondition>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConsumeConditionVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddConsumeGachaTicketType(FlatBufferBuilder builder, FlatData.GachaTicketType consumeGachaTicketType) { builder.AddInt(8, (int)consumeGachaTicketType, 0); }
  public static void AddConsumeGachaTicketTypeAmount(FlatBufferBuilder builder, long consumeGachaTicketTypeAmount) { builder.AddLong(9, consumeGachaTicketTypeAmount, 0); }
  public static void AddProductIdAOS(FlatBufferBuilder builder, long productIdAOS) { builder.AddLong(10, productIdAOS, 0); }
  public static void AddProductIdiOS(FlatBufferBuilder builder, long productIdiOS) { builder.AddLong(11, productIdiOS, 0); }
  public static void AddConsumeExtraStep(FlatBufferBuilder builder, VectorOffset consumeExtraStepOffset) { builder.AddOffset(12, consumeExtraStepOffset.Value, 0); }
  public static VectorOffset CreateConsumeExtraStepVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConsumeExtraStepVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeExtraStepVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeExtraStepVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConsumeExtraStepVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddConsumeExtraAmount(FlatBufferBuilder builder, VectorOffset consumeExtraAmountOffset) { builder.AddOffset(13, consumeExtraAmountOffset.Value, 0); }
  public static VectorOffset CreateConsumeExtraAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateConsumeExtraAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeExtraAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateConsumeExtraAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartConsumeExtraAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddState(FlatBufferBuilder builder, int state) { builder.AddInt(14, state, 0); }
  public static void AddParcelType(FlatBufferBuilder builder, VectorOffset parcelTypeOffset) { builder.AddOffset(15, parcelTypeOffset.Value, 0); }
  public static VectorOffset CreateParcelTypeVector(FlatBufferBuilder builder, FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateParcelTypeVectorBlock(FlatBufferBuilder builder, FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddParcelId(FlatBufferBuilder builder, VectorOffset parcelIdOffset) { builder.AddOffset(16, parcelIdOffset.Value, 0); }
  public static VectorOffset CreateParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddParcelAmount(FlatBufferBuilder builder, VectorOffset parcelAmountOffset) { builder.AddOffset(17, parcelAmountOffset.Value, 0); }
  public static VectorOffset CreateParcelAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateParcelAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateParcelAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartParcelAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatData.GoodsExcel> EndGoodsExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.GoodsExcel>(o);
  }
  public GoodsExcelT UnPack() {
    var _o = new GoodsExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(GoodsExcelT _o) {
    _o.Id = this.Id;
    _o.Type = this.Type;
    _o.Rarity = this.Rarity;
    _o.IconPath = this.IconPath;
    _o.ConsumeParcelType = new List<FlatData.ParcelType>();
    for (var _j = 0; _j < this.ConsumeParcelTypeLength; ++_j) {_o.ConsumeParcelType.Add(this.ConsumeParcelType(_j));}
    _o.ConsumeParcelId = new List<long>();
    for (var _j = 0; _j < this.ConsumeParcelIdLength; ++_j) {_o.ConsumeParcelId.Add(this.ConsumeParcelId(_j));}
    _o.ConsumeParcelAmount = new List<long>();
    for (var _j = 0; _j < this.ConsumeParcelAmountLength; ++_j) {_o.ConsumeParcelAmount.Add(this.ConsumeParcelAmount(_j));}
    _o.ConsumeCondition = new List<FlatData.ConsumeCondition>();
    for (var _j = 0; _j < this.ConsumeConditionLength; ++_j) {_o.ConsumeCondition.Add(this.ConsumeCondition(_j));}
    _o.ConsumeGachaTicketType = this.ConsumeGachaTicketType;
    _o.ConsumeGachaTicketTypeAmount = this.ConsumeGachaTicketTypeAmount;
    _o.ProductIdAOS = this.ProductIdAOS;
    _o.ProductIdiOS = this.ProductIdiOS;
    _o.ConsumeExtraStep = new List<long>();
    for (var _j = 0; _j < this.ConsumeExtraStepLength; ++_j) {_o.ConsumeExtraStep.Add(this.ConsumeExtraStep(_j));}
    _o.ConsumeExtraAmount = new List<long>();
    for (var _j = 0; _j < this.ConsumeExtraAmountLength; ++_j) {_o.ConsumeExtraAmount.Add(this.ConsumeExtraAmount(_j));}
    _o.State = this.State;
    _o.ParcelType = new List<FlatData.ParcelType>();
    for (var _j = 0; _j < this.ParcelTypeLength; ++_j) {_o.ParcelType.Add(this.ParcelType(_j));}
    _o.ParcelId = new List<long>();
    for (var _j = 0; _j < this.ParcelIdLength; ++_j) {_o.ParcelId.Add(this.ParcelId(_j));}
    _o.ParcelAmount = new List<long>();
    for (var _j = 0; _j < this.ParcelAmountLength; ++_j) {_o.ParcelAmount.Add(this.ParcelAmount(_j));}
  }
  public static Offset<FlatData.GoodsExcel> Pack(FlatBufferBuilder builder, GoodsExcelT _o) {
    if (_o == null) return default(Offset<FlatData.GoodsExcel>);
    var _IconPath = _o.IconPath == null ? default(StringOffset) : builder.CreateString(_o.IconPath);
    var _ConsumeParcelType = default(VectorOffset);
    if (_o.ConsumeParcelType != null) {
      var __ConsumeParcelType = _o.ConsumeParcelType.ToArray();
      _ConsumeParcelType = CreateConsumeParcelTypeVector(builder, __ConsumeParcelType);
    }
    var _ConsumeParcelId = default(VectorOffset);
    if (_o.ConsumeParcelId != null) {
      var __ConsumeParcelId = _o.ConsumeParcelId.ToArray();
      _ConsumeParcelId = CreateConsumeParcelIdVector(builder, __ConsumeParcelId);
    }
    var _ConsumeParcelAmount = default(VectorOffset);
    if (_o.ConsumeParcelAmount != null) {
      var __ConsumeParcelAmount = _o.ConsumeParcelAmount.ToArray();
      _ConsumeParcelAmount = CreateConsumeParcelAmountVector(builder, __ConsumeParcelAmount);
    }
    var _ConsumeCondition = default(VectorOffset);
    if (_o.ConsumeCondition != null) {
      var __ConsumeCondition = _o.ConsumeCondition.ToArray();
      _ConsumeCondition = CreateConsumeConditionVector(builder, __ConsumeCondition);
    }
    var _ConsumeExtraStep = default(VectorOffset);
    if (_o.ConsumeExtraStep != null) {
      var __ConsumeExtraStep = _o.ConsumeExtraStep.ToArray();
      _ConsumeExtraStep = CreateConsumeExtraStepVector(builder, __ConsumeExtraStep);
    }
    var _ConsumeExtraAmount = default(VectorOffset);
    if (_o.ConsumeExtraAmount != null) {
      var __ConsumeExtraAmount = _o.ConsumeExtraAmount.ToArray();
      _ConsumeExtraAmount = CreateConsumeExtraAmountVector(builder, __ConsumeExtraAmount);
    }
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
    var _ParcelAmount = default(VectorOffset);
    if (_o.ParcelAmount != null) {
      var __ParcelAmount = _o.ParcelAmount.ToArray();
      _ParcelAmount = CreateParcelAmountVector(builder, __ParcelAmount);
    }
    return CreateGoodsExcel(
      builder,
      _o.Id,
      _o.Type,
      _o.Rarity,
      _IconPath,
      _ConsumeParcelType,
      _ConsumeParcelId,
      _ConsumeParcelAmount,
      _ConsumeCondition,
      _o.ConsumeGachaTicketType,
      _o.ConsumeGachaTicketTypeAmount,
      _o.ProductIdAOS,
      _o.ProductIdiOS,
      _ConsumeExtraStep,
      _ConsumeExtraAmount,
      _o.State,
      _ParcelType,
      _ParcelId,
      _ParcelAmount);
  }
}

public class GoodsExcelT
{
  [Newtonsoft.Json.JsonProperty("Id")]
  public long Id { get; set; }
  [Newtonsoft.Json.JsonProperty("Type")]
  public int Type { get; set; }
  [Newtonsoft.Json.JsonProperty("Rarity")]
  public FlatData.Rarity Rarity { get; set; }
  [Newtonsoft.Json.JsonProperty("IconPath")]
  public string IconPath { get; set; }
  [Newtonsoft.Json.JsonProperty("ConsumeParcelType")]
  public List<FlatData.ParcelType> ConsumeParcelType { get; set; }
  [Newtonsoft.Json.JsonProperty("ConsumeParcelId")]
  public List<long> ConsumeParcelId { get; set; }
  [Newtonsoft.Json.JsonProperty("ConsumeParcelAmount")]
  public List<long> ConsumeParcelAmount { get; set; }
  [Newtonsoft.Json.JsonProperty("ConsumeCondition")]
  public List<FlatData.ConsumeCondition> ConsumeCondition { get; set; }
  [Newtonsoft.Json.JsonProperty("ConsumeGachaTicketType")]
  public FlatData.GachaTicketType ConsumeGachaTicketType { get; set; }
  [Newtonsoft.Json.JsonProperty("ConsumeGachaTicketTypeAmount")]
  public long ConsumeGachaTicketTypeAmount { get; set; }
  [Newtonsoft.Json.JsonProperty("ProductIdAOS")]
  public long ProductIdAOS { get; set; }
  [Newtonsoft.Json.JsonProperty("ProductIdiOS")]
  public long ProductIdiOS { get; set; }
  [Newtonsoft.Json.JsonProperty("ConsumeExtraStep")]
  public List<long> ConsumeExtraStep { get; set; }
  [Newtonsoft.Json.JsonProperty("ConsumeExtraAmount")]
  public List<long> ConsumeExtraAmount { get; set; }
  [Newtonsoft.Json.JsonProperty("State")]
  public int State { get; set; }
  [Newtonsoft.Json.JsonProperty("ParcelType")]
  public List<FlatData.ParcelType> ParcelType { get; set; }
  [Newtonsoft.Json.JsonProperty("ParcelId")]
  public List<long> ParcelId { get; set; }
  [Newtonsoft.Json.JsonProperty("ParcelAmount")]
  public List<long> ParcelAmount { get; set; }

  public GoodsExcelT() {
    this.Id = 0;
    this.Type = 0;
    this.Rarity = FlatData.Rarity.N;
    this.IconPath = null;
    this.ConsumeParcelType = null;
    this.ConsumeParcelId = null;
    this.ConsumeParcelAmount = null;
    this.ConsumeCondition = null;
    this.ConsumeGachaTicketType = FlatData.GachaTicketType.None;
    this.ConsumeGachaTicketTypeAmount = 0;
    this.ProductIdAOS = 0;
    this.ProductIdiOS = 0;
    this.ConsumeExtraStep = null;
    this.ConsumeExtraAmount = null;
    this.State = 0;
    this.ParcelType = null;
    this.ParcelId = null;
    this.ParcelAmount = null;
  }
}


static public class GoodsExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Type*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Rarity*/, 4 /*FlatData.Rarity*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*IconPath*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*ConsumeParcelType*/, 4 /*FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*ConsumeParcelId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*ConsumeParcelAmount*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 18 /*ConsumeCondition*/, 4 /*FlatData.ConsumeCondition*/, false)
      && verifier.VerifyField(tablePos, 20 /*ConsumeGachaTicketType*/, 4 /*FlatData.GachaTicketType*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*ConsumeGachaTicketTypeAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 24 /*ProductIdAOS*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 26 /*ProductIdiOS*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 28 /*ConsumeExtraStep*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 30 /*ConsumeExtraAmount*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 32 /*State*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 34 /*ParcelType*/, 4 /*FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 36 /*ParcelId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 38 /*ParcelAmount*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
