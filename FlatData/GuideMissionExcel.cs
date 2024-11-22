// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GuideMissionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static GuideMissionExcel GetRootAsGuideMissionExcel(ByteBuffer _bb) { return GetRootAsGuideMissionExcel(_bb, new GuideMissionExcel()); }
  public static GuideMissionExcel GetRootAsGuideMissionExcel(ByteBuffer _bb, GuideMissionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GuideMissionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long SeasonId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Id { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.MissionCategory Category { get { int o = __p.__offset(8); return o != 0 ? (FlatData.MissionCategory)__p.bb.GetInt(o + __p.bb_pos) : FlatData.MissionCategory.Challenge; } }
  public bool IsLegacy { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long TabNumber { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PreMissionId(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int PreMissionIdLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetPreMissionIdBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetPreMissionIdBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetPreMissionIdArray() { return __p.__vector_as_array<long>(14); }
  public uint Description { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public FlatData.MissionToastDisplayConditionType ToastDisplayType { get { int o = __p.__offset(18); return o != 0 ? (FlatData.MissionToastDisplayConditionType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.MissionToastDisplayConditionType.Always; } }
  public string ToastImagePath { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetToastImagePathBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetToastImagePathBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetToastImagePathArray() { return __p.__vector_as_array<byte>(20); }
  public string ShortcutUI(int j) { int o = __p.__offset(22); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ShortcutUILength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
  public FlatData.MissionCompleteConditionType CompleteConditionType { get { int o = __p.__offset(24); return o != 0 ? (FlatData.MissionCompleteConditionType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.MissionCompleteConditionType.None; } }
  public long CompleteConditionCount { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CompleteConditionParameter(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int CompleteConditionParameterLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetCompleteConditionParameterBytes() { return __p.__vector_as_span<long>(28, 8); }
#else
  public ArraySegment<byte>? GetCompleteConditionParameterBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public long[] GetCompleteConditionParameterArray() { return __p.__vector_as_array<long>(28); }
  public FlatData.Tag CompleteConditionParameterTag(int j) { int o = __p.__offset(30); return o != 0 ? (FlatData.Tag)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatData.Tag)0; }
  public int CompleteConditionParameterTagLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatData.Tag> GetCompleteConditionParameterTagBytes() { return __p.__vector_as_span<FlatData.Tag>(30, 4); }
#else
  public ArraySegment<byte>? GetCompleteConditionParameterTagBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public FlatData.Tag[] GetCompleteConditionParameterTagArray() { int o = __p.__offset(30); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatData.Tag[] a = new FlatData.Tag[l]; for (int i = 0; i < l; i++) { a[i] = (FlatData.Tag)__p.bb.GetInt(p + i * 4); } return a; }
  public bool IsAutoClearForScenario { get { int o = __p.__offset(32); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public FlatData.ParcelType MissionRewardParcelType(int j) { int o = __p.__offset(34); return o != 0 ? (FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatData.ParcelType)0; }
  public int MissionRewardParcelTypeLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatData.ParcelType> GetMissionRewardParcelTypeBytes() { return __p.__vector_as_span<FlatData.ParcelType>(34, 4); }
#else
  public ArraySegment<byte>? GetMissionRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public FlatData.ParcelType[] GetMissionRewardParcelTypeArray() { int o = __p.__offset(34); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatData.ParcelType[] a = new FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long MissionRewardParcelId(int j) { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int MissionRewardParcelIdLength { get { int o = __p.__offset(36); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetMissionRewardParcelIdBytes() { return __p.__vector_as_span<long>(36, 8); }
#else
  public ArraySegment<byte>? GetMissionRewardParcelIdBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public long[] GetMissionRewardParcelIdArray() { return __p.__vector_as_array<long>(36); }
  public int MissionRewardAmount(int j) { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int MissionRewardAmountLength { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetMissionRewardAmountBytes() { return __p.__vector_as_span<int>(38, 4); }
#else
  public ArraySegment<byte>? GetMissionRewardAmountBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public int[] GetMissionRewardAmountArray() { return __p.__vector_as_array<int>(38); }

  public static Offset<FlatData.GuideMissionExcel> CreateGuideMissionExcel(FlatBufferBuilder builder,
      long SeasonId = 0,
      long Id = 0,
      FlatData.MissionCategory Category = FlatData.MissionCategory.Challenge,
      bool IsLegacy = false,
      long TabNumber = 0,
      VectorOffset PreMissionIdOffset = default(VectorOffset),
      uint Description = 0,
      FlatData.MissionToastDisplayConditionType ToastDisplayType = FlatData.MissionToastDisplayConditionType.Always,
      StringOffset ToastImagePathOffset = default(StringOffset),
      VectorOffset ShortcutUIOffset = default(VectorOffset),
      FlatData.MissionCompleteConditionType CompleteConditionType = FlatData.MissionCompleteConditionType.None,
      long CompleteConditionCount = 0,
      VectorOffset CompleteConditionParameterOffset = default(VectorOffset),
      VectorOffset CompleteConditionParameterTagOffset = default(VectorOffset),
      bool IsAutoClearForScenario = false,
      VectorOffset MissionRewardParcelTypeOffset = default(VectorOffset),
      VectorOffset MissionRewardParcelIdOffset = default(VectorOffset),
      VectorOffset MissionRewardAmountOffset = default(VectorOffset)) {
    builder.StartTable(18);
    GuideMissionExcel.AddCompleteConditionCount(builder, CompleteConditionCount);
    GuideMissionExcel.AddTabNumber(builder, TabNumber);
    GuideMissionExcel.AddId(builder, Id);
    GuideMissionExcel.AddSeasonId(builder, SeasonId);
    GuideMissionExcel.AddMissionRewardAmount(builder, MissionRewardAmountOffset);
    GuideMissionExcel.AddMissionRewardParcelId(builder, MissionRewardParcelIdOffset);
    GuideMissionExcel.AddMissionRewardParcelType(builder, MissionRewardParcelTypeOffset);
    GuideMissionExcel.AddCompleteConditionParameterTag(builder, CompleteConditionParameterTagOffset);
    GuideMissionExcel.AddCompleteConditionParameter(builder, CompleteConditionParameterOffset);
    GuideMissionExcel.AddCompleteConditionType(builder, CompleteConditionType);
    GuideMissionExcel.AddShortcutUI(builder, ShortcutUIOffset);
    GuideMissionExcel.AddToastImagePath(builder, ToastImagePathOffset);
    GuideMissionExcel.AddToastDisplayType(builder, ToastDisplayType);
    GuideMissionExcel.AddDescription(builder, Description);
    GuideMissionExcel.AddPreMissionId(builder, PreMissionIdOffset);
    GuideMissionExcel.AddCategory(builder, Category);
    GuideMissionExcel.AddIsAutoClearForScenario(builder, IsAutoClearForScenario);
    GuideMissionExcel.AddIsLegacy(builder, IsLegacy);
    return GuideMissionExcel.EndGuideMissionExcel(builder);
  }

  public static void StartGuideMissionExcel(FlatBufferBuilder builder) { builder.StartTable(18); }
  public static void AddSeasonId(FlatBufferBuilder builder, long seasonId) { builder.AddLong(0, seasonId, 0); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(1, id, 0); }
  public static void AddCategory(FlatBufferBuilder builder, FlatData.MissionCategory category) { builder.AddInt(2, (int)category, 0); }
  public static void AddIsLegacy(FlatBufferBuilder builder, bool isLegacy) { builder.AddBool(3, isLegacy, false); }
  public static void AddTabNumber(FlatBufferBuilder builder, long tabNumber) { builder.AddLong(4, tabNumber, 0); }
  public static void AddPreMissionId(FlatBufferBuilder builder, VectorOffset preMissionIdOffset) { builder.AddOffset(5, preMissionIdOffset.Value, 0); }
  public static VectorOffset CreatePreMissionIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePreMissionIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePreMissionIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePreMissionIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPreMissionIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddDescription(FlatBufferBuilder builder, uint description) { builder.AddUint(6, description, 0); }
  public static void AddToastDisplayType(FlatBufferBuilder builder, FlatData.MissionToastDisplayConditionType toastDisplayType) { builder.AddInt(7, (int)toastDisplayType, 0); }
  public static void AddToastImagePath(FlatBufferBuilder builder, StringOffset toastImagePathOffset) { builder.AddOffset(8, toastImagePathOffset.Value, 0); }
  public static void AddShortcutUI(FlatBufferBuilder builder, VectorOffset shortcutUIOffset) { builder.AddOffset(9, shortcutUIOffset.Value, 0); }
  public static VectorOffset CreateShortcutUIVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUIVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUIVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUIVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartShortcutUIVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCompleteConditionType(FlatBufferBuilder builder, FlatData.MissionCompleteConditionType completeConditionType) { builder.AddInt(10, (int)completeConditionType, 0); }
  public static void AddCompleteConditionCount(FlatBufferBuilder builder, long completeConditionCount) { builder.AddLong(11, completeConditionCount, 0); }
  public static void AddCompleteConditionParameter(FlatBufferBuilder builder, VectorOffset completeConditionParameterOffset) { builder.AddOffset(12, completeConditionParameterOffset.Value, 0); }
  public static VectorOffset CreateCompleteConditionParameterVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCompleteConditionParameterVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddCompleteConditionParameterTag(FlatBufferBuilder builder, VectorOffset completeConditionParameterTagOffset) { builder.AddOffset(13, completeConditionParameterTagOffset.Value, 0); }
  public static VectorOffset CreateCompleteConditionParameterTagVector(FlatBufferBuilder builder, FlatData.Tag[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterTagVectorBlock(FlatBufferBuilder builder, FlatData.Tag[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterTagVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatData.Tag> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCompleteConditionParameterTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatData.Tag>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCompleteConditionParameterTagVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIsAutoClearForScenario(FlatBufferBuilder builder, bool isAutoClearForScenario) { builder.AddBool(14, isAutoClearForScenario, false); }
  public static void AddMissionRewardParcelType(FlatBufferBuilder builder, VectorOffset missionRewardParcelTypeOffset) { builder.AddOffset(15, missionRewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateMissionRewardParcelTypeVector(FlatBufferBuilder builder, FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMissionRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMissionRewardParcelId(FlatBufferBuilder builder, VectorOffset missionRewardParcelIdOffset) { builder.AddOffset(16, missionRewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateMissionRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMissionRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddMissionRewardAmount(FlatBufferBuilder builder, VectorOffset missionRewardAmountOffset) { builder.AddOffset(17, missionRewardAmountOffset.Value, 0); }
  public static VectorOffset CreateMissionRewardAmountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardAmountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMissionRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMissionRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatData.GuideMissionExcel> EndGuideMissionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.GuideMissionExcel>(o);
  }
  public GuideMissionExcelT UnPack() {
    var _o = new GuideMissionExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(GuideMissionExcelT _o) {
    _o.SeasonId = this.SeasonId;
    _o.Id = this.Id;
    _o.Category = this.Category;
    _o.IsLegacy = this.IsLegacy;
    _o.TabNumber = this.TabNumber;
    _o.PreMissionId = new List<long>();
    for (var _j = 0; _j < this.PreMissionIdLength; ++_j) {_o.PreMissionId.Add(this.PreMissionId(_j));}
    _o.Description = this.Description;
    _o.ToastDisplayType = this.ToastDisplayType;
    _o.ToastImagePath = this.ToastImagePath;
    _o.ShortcutUI = new List<string>();
    for (var _j = 0; _j < this.ShortcutUILength; ++_j) {_o.ShortcutUI.Add(this.ShortcutUI(_j));}
    _o.CompleteConditionType = this.CompleteConditionType;
    _o.CompleteConditionCount = this.CompleteConditionCount;
    _o.CompleteConditionParameter = new List<long>();
    for (var _j = 0; _j < this.CompleteConditionParameterLength; ++_j) {_o.CompleteConditionParameter.Add(this.CompleteConditionParameter(_j));}
    _o.CompleteConditionParameterTag = new List<FlatData.Tag>();
    for (var _j = 0; _j < this.CompleteConditionParameterTagLength; ++_j) {_o.CompleteConditionParameterTag.Add(this.CompleteConditionParameterTag(_j));}
    _o.IsAutoClearForScenario = this.IsAutoClearForScenario;
    _o.MissionRewardParcelType = new List<FlatData.ParcelType>();
    for (var _j = 0; _j < this.MissionRewardParcelTypeLength; ++_j) {_o.MissionRewardParcelType.Add(this.MissionRewardParcelType(_j));}
    _o.MissionRewardParcelId = new List<long>();
    for (var _j = 0; _j < this.MissionRewardParcelIdLength; ++_j) {_o.MissionRewardParcelId.Add(this.MissionRewardParcelId(_j));}
    _o.MissionRewardAmount = new List<int>();
    for (var _j = 0; _j < this.MissionRewardAmountLength; ++_j) {_o.MissionRewardAmount.Add(this.MissionRewardAmount(_j));}
  }
  public static Offset<FlatData.GuideMissionExcel> Pack(FlatBufferBuilder builder, GuideMissionExcelT _o) {
    if (_o == null) return default(Offset<FlatData.GuideMissionExcel>);
    var _PreMissionId = default(VectorOffset);
    if (_o.PreMissionId != null) {
      var __PreMissionId = _o.PreMissionId.ToArray();
      _PreMissionId = CreatePreMissionIdVector(builder, __PreMissionId);
    }
    var _ToastImagePath = _o.ToastImagePath == null ? default(StringOffset) : builder.CreateString(_o.ToastImagePath);
    var _ShortcutUI = default(VectorOffset);
    if (_o.ShortcutUI != null) {
      var __ShortcutUI = new StringOffset[_o.ShortcutUI.Count];
      for (var _j = 0; _j < __ShortcutUI.Length; ++_j) { __ShortcutUI[_j] = builder.CreateString(_o.ShortcutUI[_j]); }
      _ShortcutUI = CreateShortcutUIVector(builder, __ShortcutUI);
    }
    var _CompleteConditionParameter = default(VectorOffset);
    if (_o.CompleteConditionParameter != null) {
      var __CompleteConditionParameter = _o.CompleteConditionParameter.ToArray();
      _CompleteConditionParameter = CreateCompleteConditionParameterVector(builder, __CompleteConditionParameter);
    }
    var _CompleteConditionParameterTag = default(VectorOffset);
    if (_o.CompleteConditionParameterTag != null) {
      var __CompleteConditionParameterTag = _o.CompleteConditionParameterTag.ToArray();
      _CompleteConditionParameterTag = CreateCompleteConditionParameterTagVector(builder, __CompleteConditionParameterTag);
    }
    var _MissionRewardParcelType = default(VectorOffset);
    if (_o.MissionRewardParcelType != null) {
      var __MissionRewardParcelType = _o.MissionRewardParcelType.ToArray();
      _MissionRewardParcelType = CreateMissionRewardParcelTypeVector(builder, __MissionRewardParcelType);
    }
    var _MissionRewardParcelId = default(VectorOffset);
    if (_o.MissionRewardParcelId != null) {
      var __MissionRewardParcelId = _o.MissionRewardParcelId.ToArray();
      _MissionRewardParcelId = CreateMissionRewardParcelIdVector(builder, __MissionRewardParcelId);
    }
    var _MissionRewardAmount = default(VectorOffset);
    if (_o.MissionRewardAmount != null) {
      var __MissionRewardAmount = _o.MissionRewardAmount.ToArray();
      _MissionRewardAmount = CreateMissionRewardAmountVector(builder, __MissionRewardAmount);
    }
    return CreateGuideMissionExcel(
      builder,
      _o.SeasonId,
      _o.Id,
      _o.Category,
      _o.IsLegacy,
      _o.TabNumber,
      _PreMissionId,
      _o.Description,
      _o.ToastDisplayType,
      _ToastImagePath,
      _ShortcutUI,
      _o.CompleteConditionType,
      _o.CompleteConditionCount,
      _CompleteConditionParameter,
      _CompleteConditionParameterTag,
      _o.IsAutoClearForScenario,
      _MissionRewardParcelType,
      _MissionRewardParcelId,
      _MissionRewardAmount);
  }
}

public class GuideMissionExcelT
{
  [Newtonsoft.Json.JsonProperty("SeasonId")]
  public long SeasonId { get; set; }
  [Newtonsoft.Json.JsonProperty("Id")]
  public long Id { get; set; }
  [Newtonsoft.Json.JsonProperty("Category")]
  public FlatData.MissionCategory Category { get; set; }
  [Newtonsoft.Json.JsonProperty("IsLegacy")]
  public bool IsLegacy { get; set; }
  [Newtonsoft.Json.JsonProperty("TabNumber")]
  public long TabNumber { get; set; }
  [Newtonsoft.Json.JsonProperty("PreMissionId")]
  public List<long> PreMissionId { get; set; }
  [Newtonsoft.Json.JsonProperty("Description")]
  public uint Description { get; set; }
  [Newtonsoft.Json.JsonProperty("ToastDisplayType")]
  public FlatData.MissionToastDisplayConditionType ToastDisplayType { get; set; }
  [Newtonsoft.Json.JsonProperty("ToastImagePath")]
  public string ToastImagePath { get; set; }
  [Newtonsoft.Json.JsonProperty("ShortcutUI")]
  public List<string> ShortcutUI { get; set; }
  [Newtonsoft.Json.JsonProperty("CompleteConditionType")]
  public FlatData.MissionCompleteConditionType CompleteConditionType { get; set; }
  [Newtonsoft.Json.JsonProperty("CompleteConditionCount")]
  public long CompleteConditionCount { get; set; }
  [Newtonsoft.Json.JsonProperty("CompleteConditionParameter")]
  public List<long> CompleteConditionParameter { get; set; }
  [Newtonsoft.Json.JsonProperty("CompleteConditionParameterTag")]
  public List<FlatData.Tag> CompleteConditionParameterTag { get; set; }
  [Newtonsoft.Json.JsonProperty("IsAutoClearForScenario")]
  public bool IsAutoClearForScenario { get; set; }
  [Newtonsoft.Json.JsonProperty("MissionRewardParcelType")]
  public List<FlatData.ParcelType> MissionRewardParcelType { get; set; }
  [Newtonsoft.Json.JsonProperty("MissionRewardParcelId")]
  public List<long> MissionRewardParcelId { get; set; }
  [Newtonsoft.Json.JsonProperty("MissionRewardAmount")]
  public List<int> MissionRewardAmount { get; set; }

  public GuideMissionExcelT() {
    this.SeasonId = 0;
    this.Id = 0;
    this.Category = FlatData.MissionCategory.Challenge;
    this.IsLegacy = false;
    this.TabNumber = 0;
    this.PreMissionId = null;
    this.Description = 0;
    this.ToastDisplayType = FlatData.MissionToastDisplayConditionType.Always;
    this.ToastImagePath = null;
    this.ShortcutUI = null;
    this.CompleteConditionType = FlatData.MissionCompleteConditionType.None;
    this.CompleteConditionCount = 0;
    this.CompleteConditionParameter = null;
    this.CompleteConditionParameterTag = null;
    this.IsAutoClearForScenario = false;
    this.MissionRewardParcelType = null;
    this.MissionRewardParcelId = null;
    this.MissionRewardAmount = null;
  }
}


static public class GuideMissionExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*SeasonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*Category*/, 4 /*FlatData.MissionCategory*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*IsLegacy*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 12 /*TabNumber*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*PreMissionId*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 16 /*Description*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*ToastDisplayType*/, 4 /*FlatData.MissionToastDisplayConditionType*/, 4, false)
      && verifier.VerifyString(tablePos, 20 /*ToastImagePath*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 22 /*ShortcutUI*/, false)
      && verifier.VerifyField(tablePos, 24 /*CompleteConditionType*/, 4 /*FlatData.MissionCompleteConditionType*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*CompleteConditionCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 28 /*CompleteConditionParameter*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 30 /*CompleteConditionParameterTag*/, 4 /*FlatData.Tag*/, false)
      && verifier.VerifyField(tablePos, 32 /*IsAutoClearForScenario*/, 1 /*bool*/, 1, false)
      && verifier.VerifyVectorOfData(tablePos, 34 /*MissionRewardParcelType*/, 4 /*FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 36 /*MissionRewardParcelId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 38 /*MissionRewardAmount*/, 4 /*int*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
