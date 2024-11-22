// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EquipmentStatExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EquipmentStatExcel GetRootAsEquipmentStatExcel(ByteBuffer _bb) { return GetRootAsEquipmentStatExcel(_bb, new EquipmentStatExcel()); }
  public static EquipmentStatExcel GetRootAsEquipmentStatExcel(ByteBuffer _bb, EquipmentStatExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EquipmentStatExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EquipmentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.StatLevelUpType StatLevelUpType { get { int o = __p.__offset(6); return o != 0 ? (FlatData.StatLevelUpType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.StatLevelUpType.Standard; } }
  public FlatData.EquipmentOptionType StatType(int j) { int o = __p.__offset(8); return o != 0 ? (FlatData.EquipmentOptionType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatData.EquipmentOptionType)0; }
  public int StatTypeLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatData.EquipmentOptionType> GetStatTypeBytes() { return __p.__vector_as_span<FlatData.EquipmentOptionType>(8, 4); }
#else
  public ArraySegment<byte>? GetStatTypeBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public FlatData.EquipmentOptionType[] GetStatTypeArray() { int o = __p.__offset(8); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatData.EquipmentOptionType[] a = new FlatData.EquipmentOptionType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatData.EquipmentOptionType)__p.bb.GetInt(p + i * 4); } return a; }
  public long MinStat(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int MinStatLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetMinStatBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetMinStatBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetMinStatArray() { return __p.__vector_as_array<long>(10); }
  public long MaxStat(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int MaxStatLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetMaxStatBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetMaxStatBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetMaxStatArray() { return __p.__vector_as_array<long>(12); }
  public int LevelUpInsertLimit { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long LevelUpFeedExp { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.CurrencyTypes LevelUpFeedCostCurrency { get { int o = __p.__offset(18); return o != 0 ? (FlatData.CurrencyTypes)__p.bb.GetInt(o + __p.bb_pos) : FlatData.CurrencyTypes.Invalid; } }
  public long LevelUpFeedCostAmount { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.EquipmentCategory EquipmentCategory { get { int o = __p.__offset(22); return o != 0 ? (FlatData.EquipmentCategory)__p.bb.GetInt(o + __p.bb_pos) : FlatData.EquipmentCategory.Unable; } }
  public long LevelUpFeedAddExp { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int DefaultMaxLevel { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int TranscendenceMax { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string DamageFactorGroupId { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDamageFactorGroupIdBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetDamageFactorGroupIdBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetDamageFactorGroupIdArray() { return __p.__vector_as_array<byte>(30); }

  public static Offset<FlatData.EquipmentStatExcel> CreateEquipmentStatExcel(FlatBufferBuilder builder,
      long EquipmentId = 0,
      FlatData.StatLevelUpType StatLevelUpType = FlatData.StatLevelUpType.Standard,
      VectorOffset StatTypeOffset = default(VectorOffset),
      VectorOffset MinStatOffset = default(VectorOffset),
      VectorOffset MaxStatOffset = default(VectorOffset),
      int LevelUpInsertLimit = 0,
      long LevelUpFeedExp = 0,
      FlatData.CurrencyTypes LevelUpFeedCostCurrency = FlatData.CurrencyTypes.Invalid,
      long LevelUpFeedCostAmount = 0,
      FlatData.EquipmentCategory EquipmentCategory = FlatData.EquipmentCategory.Unable,
      long LevelUpFeedAddExp = 0,
      int DefaultMaxLevel = 0,
      int TranscendenceMax = 0,
      StringOffset DamageFactorGroupIdOffset = default(StringOffset)) {
    builder.StartTable(14);
    EquipmentStatExcel.AddLevelUpFeedAddExp(builder, LevelUpFeedAddExp);
    EquipmentStatExcel.AddLevelUpFeedCostAmount(builder, LevelUpFeedCostAmount);
    EquipmentStatExcel.AddLevelUpFeedExp(builder, LevelUpFeedExp);
    EquipmentStatExcel.AddEquipmentId(builder, EquipmentId);
    EquipmentStatExcel.AddDamageFactorGroupId(builder, DamageFactorGroupIdOffset);
    EquipmentStatExcel.AddTranscendenceMax(builder, TranscendenceMax);
    EquipmentStatExcel.AddDefaultMaxLevel(builder, DefaultMaxLevel);
    EquipmentStatExcel.AddEquipmentCategory(builder, EquipmentCategory);
    EquipmentStatExcel.AddLevelUpFeedCostCurrency(builder, LevelUpFeedCostCurrency);
    EquipmentStatExcel.AddLevelUpInsertLimit(builder, LevelUpInsertLimit);
    EquipmentStatExcel.AddMaxStat(builder, MaxStatOffset);
    EquipmentStatExcel.AddMinStat(builder, MinStatOffset);
    EquipmentStatExcel.AddStatType(builder, StatTypeOffset);
    EquipmentStatExcel.AddStatLevelUpType(builder, StatLevelUpType);
    return EquipmentStatExcel.EndEquipmentStatExcel(builder);
  }

  public static void StartEquipmentStatExcel(FlatBufferBuilder builder) { builder.StartTable(14); }
  public static void AddEquipmentId(FlatBufferBuilder builder, long equipmentId) { builder.AddLong(0, equipmentId, 0); }
  public static void AddStatLevelUpType(FlatBufferBuilder builder, FlatData.StatLevelUpType statLevelUpType) { builder.AddInt(1, (int)statLevelUpType, 0); }
  public static void AddStatType(FlatBufferBuilder builder, VectorOffset statTypeOffset) { builder.AddOffset(2, statTypeOffset.Value, 0); }
  public static VectorOffset CreateStatTypeVector(FlatBufferBuilder builder, FlatData.EquipmentOptionType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, FlatData.EquipmentOptionType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatData.EquipmentOptionType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatData.EquipmentOptionType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStatTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMinStat(FlatBufferBuilder builder, VectorOffset minStatOffset) { builder.AddOffset(3, minStatOffset.Value, 0); }
  public static VectorOffset CreateMinStatVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMinStatVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMinStatVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMinStatVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMinStatVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddMaxStat(FlatBufferBuilder builder, VectorOffset maxStatOffset) { builder.AddOffset(4, maxStatOffset.Value, 0); }
  public static VectorOffset CreateMaxStatVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMaxStatVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMaxStatVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMaxStatVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMaxStatVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddLevelUpInsertLimit(FlatBufferBuilder builder, int levelUpInsertLimit) { builder.AddInt(5, levelUpInsertLimit, 0); }
  public static void AddLevelUpFeedExp(FlatBufferBuilder builder, long levelUpFeedExp) { builder.AddLong(6, levelUpFeedExp, 0); }
  public static void AddLevelUpFeedCostCurrency(FlatBufferBuilder builder, FlatData.CurrencyTypes levelUpFeedCostCurrency) { builder.AddInt(7, (int)levelUpFeedCostCurrency, 0); }
  public static void AddLevelUpFeedCostAmount(FlatBufferBuilder builder, long levelUpFeedCostAmount) { builder.AddLong(8, levelUpFeedCostAmount, 0); }
  public static void AddEquipmentCategory(FlatBufferBuilder builder, FlatData.EquipmentCategory equipmentCategory) { builder.AddInt(9, (int)equipmentCategory, 0); }
  public static void AddLevelUpFeedAddExp(FlatBufferBuilder builder, long levelUpFeedAddExp) { builder.AddLong(10, levelUpFeedAddExp, 0); }
  public static void AddDefaultMaxLevel(FlatBufferBuilder builder, int defaultMaxLevel) { builder.AddInt(11, defaultMaxLevel, 0); }
  public static void AddTranscendenceMax(FlatBufferBuilder builder, int transcendenceMax) { builder.AddInt(12, transcendenceMax, 0); }
  public static void AddDamageFactorGroupId(FlatBufferBuilder builder, StringOffset damageFactorGroupIdOffset) { builder.AddOffset(13, damageFactorGroupIdOffset.Value, 0); }
  public static Offset<FlatData.EquipmentStatExcel> EndEquipmentStatExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.EquipmentStatExcel>(o);
  }
  public EquipmentStatExcelT UnPack() {
    var _o = new EquipmentStatExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EquipmentStatExcelT _o) {
    _o.EquipmentId = this.EquipmentId;
    _o.StatLevelUpType = this.StatLevelUpType;
    _o.StatType = new List<FlatData.EquipmentOptionType>();
    for (var _j = 0; _j < this.StatTypeLength; ++_j) {_o.StatType.Add(this.StatType(_j));}
    _o.MinStat = new List<long>();
    for (var _j = 0; _j < this.MinStatLength; ++_j) {_o.MinStat.Add(this.MinStat(_j));}
    _o.MaxStat = new List<long>();
    for (var _j = 0; _j < this.MaxStatLength; ++_j) {_o.MaxStat.Add(this.MaxStat(_j));}
    _o.LevelUpInsertLimit = this.LevelUpInsertLimit;
    _o.LevelUpFeedExp = this.LevelUpFeedExp;
    _o.LevelUpFeedCostCurrency = this.LevelUpFeedCostCurrency;
    _o.LevelUpFeedCostAmount = this.LevelUpFeedCostAmount;
    _o.EquipmentCategory = this.EquipmentCategory;
    _o.LevelUpFeedAddExp = this.LevelUpFeedAddExp;
    _o.DefaultMaxLevel = this.DefaultMaxLevel;
    _o.TranscendenceMax = this.TranscendenceMax;
    _o.DamageFactorGroupId = this.DamageFactorGroupId;
  }
  public static Offset<FlatData.EquipmentStatExcel> Pack(FlatBufferBuilder builder, EquipmentStatExcelT _o) {
    if (_o == null) return default(Offset<FlatData.EquipmentStatExcel>);
    var _StatType = default(VectorOffset);
    if (_o.StatType != null) {
      var __StatType = _o.StatType.ToArray();
      _StatType = CreateStatTypeVector(builder, __StatType);
    }
    var _MinStat = default(VectorOffset);
    if (_o.MinStat != null) {
      var __MinStat = _o.MinStat.ToArray();
      _MinStat = CreateMinStatVector(builder, __MinStat);
    }
    var _MaxStat = default(VectorOffset);
    if (_o.MaxStat != null) {
      var __MaxStat = _o.MaxStat.ToArray();
      _MaxStat = CreateMaxStatVector(builder, __MaxStat);
    }
    var _DamageFactorGroupId = _o.DamageFactorGroupId == null ? default(StringOffset) : builder.CreateString(_o.DamageFactorGroupId);
    return CreateEquipmentStatExcel(
      builder,
      _o.EquipmentId,
      _o.StatLevelUpType,
      _StatType,
      _MinStat,
      _MaxStat,
      _o.LevelUpInsertLimit,
      _o.LevelUpFeedExp,
      _o.LevelUpFeedCostCurrency,
      _o.LevelUpFeedCostAmount,
      _o.EquipmentCategory,
      _o.LevelUpFeedAddExp,
      _o.DefaultMaxLevel,
      _o.TranscendenceMax,
      _DamageFactorGroupId);
  }
}

public class EquipmentStatExcelT
{
  [Newtonsoft.Json.JsonProperty("EquipmentId")]
  public long EquipmentId { get; set; }
  [Newtonsoft.Json.JsonProperty("StatLevelUpType")]
  public FlatData.StatLevelUpType StatLevelUpType { get; set; }
  [Newtonsoft.Json.JsonProperty("StatType")]
  public List<FlatData.EquipmentOptionType> StatType { get; set; }
  [Newtonsoft.Json.JsonProperty("MinStat")]
  public List<long> MinStat { get; set; }
  [Newtonsoft.Json.JsonProperty("MaxStat")]
  public List<long> MaxStat { get; set; }
  [Newtonsoft.Json.JsonProperty("LevelUpInsertLimit")]
  public int LevelUpInsertLimit { get; set; }
  [Newtonsoft.Json.JsonProperty("LevelUpFeedExp")]
  public long LevelUpFeedExp { get; set; }
  [Newtonsoft.Json.JsonProperty("LevelUpFeedCostCurrency")]
  public FlatData.CurrencyTypes LevelUpFeedCostCurrency { get; set; }
  [Newtonsoft.Json.JsonProperty("LevelUpFeedCostAmount")]
  public long LevelUpFeedCostAmount { get; set; }
  [Newtonsoft.Json.JsonProperty("EquipmentCategory")]
  public FlatData.EquipmentCategory EquipmentCategory { get; set; }
  [Newtonsoft.Json.JsonProperty("LevelUpFeedAddExp")]
  public long LevelUpFeedAddExp { get; set; }
  [Newtonsoft.Json.JsonProperty("DefaultMaxLevel")]
  public int DefaultMaxLevel { get; set; }
  [Newtonsoft.Json.JsonProperty("TranscendenceMax")]
  public int TranscendenceMax { get; set; }
  [Newtonsoft.Json.JsonProperty("DamageFactorGroupId")]
  public string DamageFactorGroupId { get; set; }

  public EquipmentStatExcelT() {
    this.EquipmentId = 0;
    this.StatLevelUpType = FlatData.StatLevelUpType.Standard;
    this.StatType = null;
    this.MinStat = null;
    this.MaxStat = null;
    this.LevelUpInsertLimit = 0;
    this.LevelUpFeedExp = 0;
    this.LevelUpFeedCostCurrency = FlatData.CurrencyTypes.Invalid;
    this.LevelUpFeedCostAmount = 0;
    this.EquipmentCategory = FlatData.EquipmentCategory.Unable;
    this.LevelUpFeedAddExp = 0;
    this.DefaultMaxLevel = 0;
    this.TranscendenceMax = 0;
    this.DamageFactorGroupId = null;
  }
}


static public class EquipmentStatExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EquipmentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*StatLevelUpType*/, 4 /*FlatData.StatLevelUpType*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*StatType*/, 4 /*FlatData.EquipmentOptionType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*MinStat*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*MaxStat*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 14 /*LevelUpInsertLimit*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*LevelUpFeedExp*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*LevelUpFeedCostCurrency*/, 4 /*FlatData.CurrencyTypes*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*LevelUpFeedCostAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 22 /*EquipmentCategory*/, 4 /*FlatData.EquipmentCategory*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*LevelUpFeedAddExp*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 26 /*DefaultMaxLevel*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 28 /*TranscendenceMax*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 30 /*DamageFactorGroupId*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}