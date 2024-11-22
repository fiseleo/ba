// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ObstacleExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ObstacleExcel GetRootAsObstacleExcel(ByteBuffer _bb) { return GetRootAsObstacleExcel(_bb, new ObstacleExcel()); }
  public static ObstacleExcel GetRootAsObstacleExcel(ByteBuffer _bb, ObstacleExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ObstacleExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Index { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string PrefabName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPrefabNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetPrefabNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetPrefabNameArray() { return __p.__vector_as_array<byte>(6); }
  public bool JumpAble { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public float SubOffset(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int SubOffsetLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetSubOffsetBytes() { return __p.__vector_as_span<float>(10, 4); }
#else
  public ArraySegment<byte>? GetSubOffsetBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public float[] GetSubOffsetArray() { return __p.__vector_as_array<float>(10); }
  public float X { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Z { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public long Hp { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxHp { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int BlockRate { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int EvasionRate { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public FlatData.ObstacleDestroyType DestroyType { get { int o = __p.__offset(24); return o != 0 ? (FlatData.ObstacleDestroyType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.ObstacleDestroyType.Remain; } }
  public float Point1Offeset(int j) { int o = __p.__offset(26); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int Point1OffesetLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetPoint1OffesetBytes() { return __p.__vector_as_span<float>(26, 4); }
#else
  public ArraySegment<byte>? GetPoint1OffesetBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public float[] GetPoint1OffesetArray() { return __p.__vector_as_array<float>(26); }
  public float EnemyPoint1Osset(int j) { int o = __p.__offset(28); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int EnemyPoint1OssetLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetEnemyPoint1OssetBytes() { return __p.__vector_as_span<float>(28, 4); }
#else
  public ArraySegment<byte>? GetEnemyPoint1OssetBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public float[] GetEnemyPoint1OssetArray() { return __p.__vector_as_array<float>(28); }
  public float Point2Offeset(int j) { int o = __p.__offset(30); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int Point2OffesetLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetPoint2OffesetBytes() { return __p.__vector_as_span<float>(30, 4); }
#else
  public ArraySegment<byte>? GetPoint2OffesetBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public float[] GetPoint2OffesetArray() { return __p.__vector_as_array<float>(30); }
  public float EnemyPoint2Osset(int j) { int o = __p.__offset(32); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int EnemyPoint2OssetLength { get { int o = __p.__offset(32); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<float> GetEnemyPoint2OssetBytes() { return __p.__vector_as_span<float>(32, 4); }
#else
  public ArraySegment<byte>? GetEnemyPoint2OssetBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public float[] GetEnemyPoint2OssetArray() { return __p.__vector_as_array<float>(32); }
  public long SubObstacleID(int j) { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int SubObstacleIDLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetSubObstacleIDBytes() { return __p.__vector_as_span<long>(34, 8); }
#else
  public ArraySegment<byte>? GetSubObstacleIDBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public long[] GetSubObstacleIDArray() { return __p.__vector_as_array<long>(34); }

  public static Offset<FlatData.ObstacleExcel> CreateObstacleExcel(FlatBufferBuilder builder,
      long Index = 0,
      StringOffset PrefabNameOffset = default(StringOffset),
      bool JumpAble = false,
      VectorOffset SubOffsetOffset = default(VectorOffset),
      float X = 0.0f,
      float Z = 0.0f,
      long Hp = 0,
      long MaxHp = 0,
      int BlockRate = 0,
      int EvasionRate = 0,
      FlatData.ObstacleDestroyType DestroyType = FlatData.ObstacleDestroyType.Remain,
      VectorOffset Point1OffesetOffset = default(VectorOffset),
      VectorOffset EnemyPoint1OssetOffset = default(VectorOffset),
      VectorOffset Point2OffesetOffset = default(VectorOffset),
      VectorOffset EnemyPoint2OssetOffset = default(VectorOffset),
      VectorOffset SubObstacleIDOffset = default(VectorOffset)) {
    builder.StartTable(16);
    ObstacleExcel.AddMaxHp(builder, MaxHp);
    ObstacleExcel.AddHp(builder, Hp);
    ObstacleExcel.AddIndex(builder, Index);
    ObstacleExcel.AddSubObstacleID(builder, SubObstacleIDOffset);
    ObstacleExcel.AddEnemyPoint2Osset(builder, EnemyPoint2OssetOffset);
    ObstacleExcel.AddPoint2Offeset(builder, Point2OffesetOffset);
    ObstacleExcel.AddEnemyPoint1Osset(builder, EnemyPoint1OssetOffset);
    ObstacleExcel.AddPoint1Offeset(builder, Point1OffesetOffset);
    ObstacleExcel.AddDestroyType(builder, DestroyType);
    ObstacleExcel.AddEvasionRate(builder, EvasionRate);
    ObstacleExcel.AddBlockRate(builder, BlockRate);
    ObstacleExcel.AddZ(builder, Z);
    ObstacleExcel.AddX(builder, X);
    ObstacleExcel.AddSubOffset(builder, SubOffsetOffset);
    ObstacleExcel.AddPrefabName(builder, PrefabNameOffset);
    ObstacleExcel.AddJumpAble(builder, JumpAble);
    return ObstacleExcel.EndObstacleExcel(builder);
  }

  public static void StartObstacleExcel(FlatBufferBuilder builder) { builder.StartTable(16); }
  public static void AddIndex(FlatBufferBuilder builder, long index) { builder.AddLong(0, index, 0); }
  public static void AddPrefabName(FlatBufferBuilder builder, StringOffset prefabNameOffset) { builder.AddOffset(1, prefabNameOffset.Value, 0); }
  public static void AddJumpAble(FlatBufferBuilder builder, bool jumpAble) { builder.AddBool(2, jumpAble, false); }
  public static void AddSubOffset(FlatBufferBuilder builder, VectorOffset subOffsetOffset) { builder.AddOffset(3, subOffsetOffset.Value, 0); }
  public static VectorOffset CreateSubOffsetVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSubOffsetVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSubOffsetVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSubOffsetVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSubOffsetVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddX(FlatBufferBuilder builder, float x) { builder.AddFloat(4, x, 0.0f); }
  public static void AddZ(FlatBufferBuilder builder, float z) { builder.AddFloat(5, z, 0.0f); }
  public static void AddHp(FlatBufferBuilder builder, long hp) { builder.AddLong(6, hp, 0); }
  public static void AddMaxHp(FlatBufferBuilder builder, long maxHp) { builder.AddLong(7, maxHp, 0); }
  public static void AddBlockRate(FlatBufferBuilder builder, int blockRate) { builder.AddInt(8, blockRate, 0); }
  public static void AddEvasionRate(FlatBufferBuilder builder, int evasionRate) { builder.AddInt(9, evasionRate, 0); }
  public static void AddDestroyType(FlatBufferBuilder builder, FlatData.ObstacleDestroyType destroyType) { builder.AddInt(10, (int)destroyType, 0); }
  public static void AddPoint1Offeset(FlatBufferBuilder builder, VectorOffset point1OffesetOffset) { builder.AddOffset(11, point1OffesetOffset.Value, 0); }
  public static VectorOffset CreatePoint1OffesetVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePoint1OffesetVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePoint1OffesetVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePoint1OffesetVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPoint1OffesetVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEnemyPoint1Osset(FlatBufferBuilder builder, VectorOffset enemyPoint1OssetOffset) { builder.AddOffset(12, enemyPoint1OssetOffset.Value, 0); }
  public static VectorOffset CreateEnemyPoint1OssetVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateEnemyPoint1OssetVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnemyPoint1OssetVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnemyPoint1OssetVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEnemyPoint1OssetVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPoint2Offeset(FlatBufferBuilder builder, VectorOffset point2OffesetOffset) { builder.AddOffset(13, point2OffesetOffset.Value, 0); }
  public static VectorOffset CreatePoint2OffesetVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreatePoint2OffesetVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePoint2OffesetVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePoint2OffesetVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPoint2OffesetVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEnemyPoint2Osset(FlatBufferBuilder builder, VectorOffset enemyPoint2OssetOffset) { builder.AddOffset(14, enemyPoint2OssetOffset.Value, 0); }
  public static VectorOffset CreateEnemyPoint2OssetVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateEnemyPoint2OssetVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnemyPoint2OssetVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateEnemyPoint2OssetVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<float>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartEnemyPoint2OssetVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSubObstacleID(FlatBufferBuilder builder, VectorOffset subObstacleIDOffset) { builder.AddOffset(15, subObstacleIDOffset.Value, 0); }
  public static VectorOffset CreateSubObstacleIDVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateSubObstacleIDVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSubObstacleIDVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSubObstacleIDVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSubObstacleIDVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatData.ObstacleExcel> EndObstacleExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.ObstacleExcel>(o);
  }
  public ObstacleExcelT UnPack() {
    var _o = new ObstacleExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ObstacleExcelT _o) {
    _o.Index = this.Index;
    _o.PrefabName = this.PrefabName;
    _o.JumpAble = this.JumpAble;
    _o.SubOffset = new List<float>();
    for (var _j = 0; _j < this.SubOffsetLength; ++_j) {_o.SubOffset.Add(this.SubOffset(_j));}
    _o.X = this.X;
    _o.Z = this.Z;
    _o.Hp = this.Hp;
    _o.MaxHp = this.MaxHp;
    _o.BlockRate = this.BlockRate;
    _o.EvasionRate = this.EvasionRate;
    _o.DestroyType = this.DestroyType;
    _o.Point1Offeset = new List<float>();
    for (var _j = 0; _j < this.Point1OffesetLength; ++_j) {_o.Point1Offeset.Add(this.Point1Offeset(_j));}
    _o.EnemyPoint1Osset = new List<float>();
    for (var _j = 0; _j < this.EnemyPoint1OssetLength; ++_j) {_o.EnemyPoint1Osset.Add(this.EnemyPoint1Osset(_j));}
    _o.Point2Offeset = new List<float>();
    for (var _j = 0; _j < this.Point2OffesetLength; ++_j) {_o.Point2Offeset.Add(this.Point2Offeset(_j));}
    _o.EnemyPoint2Osset = new List<float>();
    for (var _j = 0; _j < this.EnemyPoint2OssetLength; ++_j) {_o.EnemyPoint2Osset.Add(this.EnemyPoint2Osset(_j));}
    _o.SubObstacleID = new List<long>();
    for (var _j = 0; _j < this.SubObstacleIDLength; ++_j) {_o.SubObstacleID.Add(this.SubObstacleID(_j));}
  }
  public static Offset<FlatData.ObstacleExcel> Pack(FlatBufferBuilder builder, ObstacleExcelT _o) {
    if (_o == null) return default(Offset<FlatData.ObstacleExcel>);
    var _PrefabName = _o.PrefabName == null ? default(StringOffset) : builder.CreateString(_o.PrefabName);
    var _SubOffset = default(VectorOffset);
    if (_o.SubOffset != null) {
      var __SubOffset = _o.SubOffset.ToArray();
      _SubOffset = CreateSubOffsetVector(builder, __SubOffset);
    }
    var _Point1Offeset = default(VectorOffset);
    if (_o.Point1Offeset != null) {
      var __Point1Offeset = _o.Point1Offeset.ToArray();
      _Point1Offeset = CreatePoint1OffesetVector(builder, __Point1Offeset);
    }
    var _EnemyPoint1Osset = default(VectorOffset);
    if (_o.EnemyPoint1Osset != null) {
      var __EnemyPoint1Osset = _o.EnemyPoint1Osset.ToArray();
      _EnemyPoint1Osset = CreateEnemyPoint1OssetVector(builder, __EnemyPoint1Osset);
    }
    var _Point2Offeset = default(VectorOffset);
    if (_o.Point2Offeset != null) {
      var __Point2Offeset = _o.Point2Offeset.ToArray();
      _Point2Offeset = CreatePoint2OffesetVector(builder, __Point2Offeset);
    }
    var _EnemyPoint2Osset = default(VectorOffset);
    if (_o.EnemyPoint2Osset != null) {
      var __EnemyPoint2Osset = _o.EnemyPoint2Osset.ToArray();
      _EnemyPoint2Osset = CreateEnemyPoint2OssetVector(builder, __EnemyPoint2Osset);
    }
    var _SubObstacleID = default(VectorOffset);
    if (_o.SubObstacleID != null) {
      var __SubObstacleID = _o.SubObstacleID.ToArray();
      _SubObstacleID = CreateSubObstacleIDVector(builder, __SubObstacleID);
    }
    return CreateObstacleExcel(
      builder,
      _o.Index,
      _PrefabName,
      _o.JumpAble,
      _SubOffset,
      _o.X,
      _o.Z,
      _o.Hp,
      _o.MaxHp,
      _o.BlockRate,
      _o.EvasionRate,
      _o.DestroyType,
      _Point1Offeset,
      _EnemyPoint1Osset,
      _Point2Offeset,
      _EnemyPoint2Osset,
      _SubObstacleID);
  }
}

public class ObstacleExcelT
{
  [Newtonsoft.Json.JsonProperty("Index")]
  public long Index { get; set; }
  [Newtonsoft.Json.JsonProperty("PrefabName")]
  public string PrefabName { get; set; }
  [Newtonsoft.Json.JsonProperty("JumpAble")]
  public bool JumpAble { get; set; }
  [Newtonsoft.Json.JsonProperty("SubOffset")]
  public List<float> SubOffset { get; set; }
  [Newtonsoft.Json.JsonProperty("X")]
  public float X { get; set; }
  [Newtonsoft.Json.JsonProperty("Z")]
  public float Z { get; set; }
  [Newtonsoft.Json.JsonProperty("Hp")]
  public long Hp { get; set; }
  [Newtonsoft.Json.JsonProperty("MaxHp")]
  public long MaxHp { get; set; }
  [Newtonsoft.Json.JsonProperty("BlockRate")]
  public int BlockRate { get; set; }
  [Newtonsoft.Json.JsonProperty("EvasionRate")]
  public int EvasionRate { get; set; }
  [Newtonsoft.Json.JsonProperty("DestroyType")]
  public FlatData.ObstacleDestroyType DestroyType { get; set; }
  [Newtonsoft.Json.JsonProperty("Point1Offeset")]
  public List<float> Point1Offeset { get; set; }
  [Newtonsoft.Json.JsonProperty("EnemyPoint1Osset")]
  public List<float> EnemyPoint1Osset { get; set; }
  [Newtonsoft.Json.JsonProperty("Point2Offeset")]
  public List<float> Point2Offeset { get; set; }
  [Newtonsoft.Json.JsonProperty("EnemyPoint2Osset")]
  public List<float> EnemyPoint2Osset { get; set; }
  [Newtonsoft.Json.JsonProperty("SubObstacleID")]
  public List<long> SubObstacleID { get; set; }

  public ObstacleExcelT() {
    this.Index = 0;
    this.PrefabName = null;
    this.JumpAble = false;
    this.SubOffset = null;
    this.X = 0.0f;
    this.Z = 0.0f;
    this.Hp = 0;
    this.MaxHp = 0;
    this.BlockRate = 0;
    this.EvasionRate = 0;
    this.DestroyType = FlatData.ObstacleDestroyType.Remain;
    this.Point1Offeset = null;
    this.EnemyPoint1Osset = null;
    this.Point2Offeset = null;
    this.EnemyPoint2Osset = null;
    this.SubObstacleID = null;
  }
}


static public class ObstacleExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Index*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 6 /*PrefabName*/, false)
      && verifier.VerifyField(tablePos, 8 /*JumpAble*/, 1 /*bool*/, 1, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*SubOffset*/, 4 /*float*/, false)
      && verifier.VerifyField(tablePos, 12 /*X*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*Z*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*Hp*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*MaxHp*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*BlockRate*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*EvasionRate*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*DestroyType*/, 4 /*FlatData.ObstacleDestroyType*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 26 /*Point1Offeset*/, 4 /*float*/, false)
      && verifier.VerifyVectorOfData(tablePos, 28 /*EnemyPoint1Osset*/, 4 /*float*/, false)
      && verifier.VerifyVectorOfData(tablePos, 30 /*Point2Offeset*/, 4 /*float*/, false)
      && verifier.VerifyVectorOfData(tablePos, 32 /*EnemyPoint2Osset*/, 4 /*float*/, false)
      && verifier.VerifyVectorOfData(tablePos, 34 /*SubObstacleID*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}