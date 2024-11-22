// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct StatLevelInterpolationExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static StatLevelInterpolationExcel GetRootAsStatLevelInterpolationExcel(ByteBuffer _bb) { return GetRootAsStatLevelInterpolationExcel(_bb, new StatLevelInterpolationExcel()); }
  public static StatLevelInterpolationExcel GetRootAsStatLevelInterpolationExcel(ByteBuffer _bb, StatLevelInterpolationExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public StatLevelInterpolationExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Level { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StatTypeIndex(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int StatTypeIndexLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetStatTypeIndexBytes() { return __p.__vector_as_span<long>(6, 8); }
#else
  public ArraySegment<byte>? GetStatTypeIndexBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public long[] GetStatTypeIndexArray() { return __p.__vector_as_array<long>(6); }

  public static Offset<FlatData.StatLevelInterpolationExcel> CreateStatLevelInterpolationExcel(FlatBufferBuilder builder,
      long Level = 0,
      VectorOffset StatTypeIndexOffset = default(VectorOffset)) {
    builder.StartTable(2);
    StatLevelInterpolationExcel.AddLevel(builder, Level);
    StatLevelInterpolationExcel.AddStatTypeIndex(builder, StatTypeIndexOffset);
    return StatLevelInterpolationExcel.EndStatLevelInterpolationExcel(builder);
  }

  public static void StartStatLevelInterpolationExcel(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddLevel(FlatBufferBuilder builder, long level) { builder.AddLong(0, level, 0); }
  public static void AddStatTypeIndex(FlatBufferBuilder builder, VectorOffset statTypeIndexOffset) { builder.AddOffset(1, statTypeIndexOffset.Value, 0); }
  public static VectorOffset CreateStatTypeIndexVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeIndexVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeIndexVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatTypeIndexVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStatTypeIndexVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<FlatData.StatLevelInterpolationExcel> EndStatLevelInterpolationExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.StatLevelInterpolationExcel>(o);
  }
  public StatLevelInterpolationExcelT UnPack() {
    var _o = new StatLevelInterpolationExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(StatLevelInterpolationExcelT _o) {
    _o.Level = this.Level;
    _o.StatTypeIndex = new List<long>();
    for (var _j = 0; _j < this.StatTypeIndexLength; ++_j) {_o.StatTypeIndex.Add(this.StatTypeIndex(_j));}
  }
  public static Offset<FlatData.StatLevelInterpolationExcel> Pack(FlatBufferBuilder builder, StatLevelInterpolationExcelT _o) {
    if (_o == null) return default(Offset<FlatData.StatLevelInterpolationExcel>);
    var _StatTypeIndex = default(VectorOffset);
    if (_o.StatTypeIndex != null) {
      var __StatTypeIndex = _o.StatTypeIndex.ToArray();
      _StatTypeIndex = CreateStatTypeIndexVector(builder, __StatTypeIndex);
    }
    return CreateStatLevelInterpolationExcel(
      builder,
      _o.Level,
      _StatTypeIndex);
  }
}

public class StatLevelInterpolationExcelT
{
  [Newtonsoft.Json.JsonProperty("Level")]
  public long Level { get; set; }
  [Newtonsoft.Json.JsonProperty("StatTypeIndex")]
  public List<long> StatTypeIndex { get; set; }

  public StatLevelInterpolationExcelT() {
    this.Level = 0;
    this.StatTypeIndex = null;
  }
}


static public class StatLevelInterpolationExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Level*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 6 /*StatTypeIndex*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}