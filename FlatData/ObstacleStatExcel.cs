// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ObstacleStatExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ObstacleStatExcel GetRootAsObstacleStatExcel(ByteBuffer _bb) { return GetRootAsObstacleStatExcel(_bb, new ObstacleStatExcel()); }
  public static ObstacleStatExcel GetRootAsObstacleStatExcel(ByteBuffer _bb, ObstacleStatExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ObstacleStatExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint StringID { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }
  public long MaxHP1 { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxHP100 { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BlockRate { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Dodge { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CanNotStandRange { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float HighlightFloaterHeight { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<FlatData.ObstacleStatExcel> CreateObstacleStatExcel(FlatBufferBuilder builder,
      uint StringID = 0,
      StringOffset NameOffset = default(StringOffset),
      long MaxHP1 = 0,
      long MaxHP100 = 0,
      long BlockRate = 0,
      long Dodge = 0,
      long CanNotStandRange = 0,
      float HighlightFloaterHeight = 0.0f) {
    builder.StartTable(8);
    ObstacleStatExcel.AddCanNotStandRange(builder, CanNotStandRange);
    ObstacleStatExcel.AddDodge(builder, Dodge);
    ObstacleStatExcel.AddBlockRate(builder, BlockRate);
    ObstacleStatExcel.AddMaxHP100(builder, MaxHP100);
    ObstacleStatExcel.AddMaxHP1(builder, MaxHP1);
    ObstacleStatExcel.AddHighlightFloaterHeight(builder, HighlightFloaterHeight);
    ObstacleStatExcel.AddName(builder, NameOffset);
    ObstacleStatExcel.AddStringID(builder, StringID);
    return ObstacleStatExcel.EndObstacleStatExcel(builder);
  }

  public static void StartObstacleStatExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddStringID(FlatBufferBuilder builder, uint stringID) { builder.AddUint(0, stringID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddMaxHP1(FlatBufferBuilder builder, long maxHP1) { builder.AddLong(2, maxHP1, 0); }
  public static void AddMaxHP100(FlatBufferBuilder builder, long maxHP100) { builder.AddLong(3, maxHP100, 0); }
  public static void AddBlockRate(FlatBufferBuilder builder, long blockRate) { builder.AddLong(4, blockRate, 0); }
  public static void AddDodge(FlatBufferBuilder builder, long dodge) { builder.AddLong(5, dodge, 0); }
  public static void AddCanNotStandRange(FlatBufferBuilder builder, long canNotStandRange) { builder.AddLong(6, canNotStandRange, 0); }
  public static void AddHighlightFloaterHeight(FlatBufferBuilder builder, float highlightFloaterHeight) { builder.AddFloat(7, highlightFloaterHeight, 0.0f); }
  public static Offset<FlatData.ObstacleStatExcel> EndObstacleStatExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.ObstacleStatExcel>(o);
  }
  public ObstacleStatExcelT UnPack() {
    var _o = new ObstacleStatExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ObstacleStatExcelT _o) {
    _o.StringID = this.StringID;
    _o.Name = this.Name;
    _o.MaxHP1 = this.MaxHP1;
    _o.MaxHP100 = this.MaxHP100;
    _o.BlockRate = this.BlockRate;
    _o.Dodge = this.Dodge;
    _o.CanNotStandRange = this.CanNotStandRange;
    _o.HighlightFloaterHeight = this.HighlightFloaterHeight;
  }
  public static Offset<FlatData.ObstacleStatExcel> Pack(FlatBufferBuilder builder, ObstacleStatExcelT _o) {
    if (_o == null) return default(Offset<FlatData.ObstacleStatExcel>);
    var _Name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    return CreateObstacleStatExcel(
      builder,
      _o.StringID,
      _Name,
      _o.MaxHP1,
      _o.MaxHP100,
      _o.BlockRate,
      _o.Dodge,
      _o.CanNotStandRange,
      _o.HighlightFloaterHeight);
  }
}

public class ObstacleStatExcelT
{
  [Newtonsoft.Json.JsonProperty("StringID")]
  public uint StringID { get; set; }
  [Newtonsoft.Json.JsonProperty("Name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("MaxHP1")]
  public long MaxHP1 { get; set; }
  [Newtonsoft.Json.JsonProperty("MaxHP100")]
  public long MaxHP100 { get; set; }
  [Newtonsoft.Json.JsonProperty("BlockRate")]
  public long BlockRate { get; set; }
  [Newtonsoft.Json.JsonProperty("Dodge")]
  public long Dodge { get; set; }
  [Newtonsoft.Json.JsonProperty("CanNotStandRange")]
  public long CanNotStandRange { get; set; }
  [Newtonsoft.Json.JsonProperty("HighlightFloaterHeight")]
  public float HighlightFloaterHeight { get; set; }

  public ObstacleStatExcelT() {
    this.StringID = 0;
    this.Name = null;
    this.MaxHP1 = 0;
    this.MaxHP100 = 0;
    this.BlockRate = 0;
    this.Dodge = 0;
    this.CanNotStandRange = 0;
    this.HighlightFloaterHeight = 0.0f;
  }
}


static public class ObstacleStatExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*StringID*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 6 /*Name*/, false)
      && verifier.VerifyField(tablePos, 8 /*MaxHP1*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*MaxHP100*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*BlockRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*Dodge*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*CanNotStandRange*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*HighlightFloaterHeight*/, 4 /*float*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
