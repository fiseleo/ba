// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GachaGroupExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static GachaGroupExcel GetRootAsGachaGroupExcel(ByteBuffer _bb) { return GetRootAsGachaGroupExcel(_bb, new GachaGroupExcel()); }
  public static GachaGroupExcel GetRootAsGachaGroupExcel(ByteBuffer _bb, GachaGroupExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GachaGroupExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long ID { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string NameKr { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameKrBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameKrBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameKrArray() { return __p.__vector_as_array<byte>(6); }
  public bool IsRecursive { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public FlatData.GachaGroupType GroupType { get { int o = __p.__offset(10); return o != 0 ? (FlatData.GachaGroupType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.GachaGroupType.None; } }

  public static Offset<FlatData.GachaGroupExcel> CreateGachaGroupExcel(FlatBufferBuilder builder,
      long ID = 0,
      StringOffset NameKrOffset = default(StringOffset),
      bool IsRecursive = false,
      FlatData.GachaGroupType GroupType = FlatData.GachaGroupType.None) {
    builder.StartTable(4);
    GachaGroupExcel.AddID(builder, ID);
    GachaGroupExcel.AddGroupType(builder, GroupType);
    GachaGroupExcel.AddNameKr(builder, NameKrOffset);
    GachaGroupExcel.AddIsRecursive(builder, IsRecursive);
    return GachaGroupExcel.EndGachaGroupExcel(builder);
  }

  public static void StartGachaGroupExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddID(FlatBufferBuilder builder, long iD) { builder.AddLong(0, iD, 0); }
  public static void AddNameKr(FlatBufferBuilder builder, StringOffset nameKrOffset) { builder.AddOffset(1, nameKrOffset.Value, 0); }
  public static void AddIsRecursive(FlatBufferBuilder builder, bool isRecursive) { builder.AddBool(2, isRecursive, false); }
  public static void AddGroupType(FlatBufferBuilder builder, FlatData.GachaGroupType groupType) { builder.AddInt(3, (int)groupType, 0); }
  public static Offset<FlatData.GachaGroupExcel> EndGachaGroupExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.GachaGroupExcel>(o);
  }
  public GachaGroupExcelT UnPack() {
    var _o = new GachaGroupExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(GachaGroupExcelT _o) {
    _o.ID = this.ID;
    _o.NameKr = this.NameKr;
    _o.IsRecursive = this.IsRecursive;
    _o.GroupType = this.GroupType;
  }
  public static Offset<FlatData.GachaGroupExcel> Pack(FlatBufferBuilder builder, GachaGroupExcelT _o) {
    if (_o == null) return default(Offset<FlatData.GachaGroupExcel>);
    var _NameKr = _o.NameKr == null ? default(StringOffset) : builder.CreateString(_o.NameKr);
    return CreateGachaGroupExcel(
      builder,
      _o.ID,
      _NameKr,
      _o.IsRecursive,
      _o.GroupType);
  }
}

public class GachaGroupExcelT
{
  [Newtonsoft.Json.JsonProperty("ID")]
  public long ID { get; set; }
  [Newtonsoft.Json.JsonProperty("NameKr")]
  public string NameKr { get; set; }
  [Newtonsoft.Json.JsonProperty("IsRecursive")]
  public bool IsRecursive { get; set; }
  [Newtonsoft.Json.JsonProperty("GroupType")]
  public FlatData.GachaGroupType GroupType { get; set; }

  public GachaGroupExcelT() {
    this.ID = 0;
    this.NameKr = null;
    this.IsRecursive = false;
    this.GroupType = FlatData.GachaGroupType.None;
  }
}


static public class GachaGroupExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*ID*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 6 /*NameKr*/, false)
      && verifier.VerifyField(tablePos, 8 /*IsRecursive*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 10 /*GroupType*/, 4 /*FlatData.GachaGroupType*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}