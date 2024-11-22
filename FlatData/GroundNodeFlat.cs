// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GroundNodeFlat : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static GroundNodeFlat GetRootAsGroundNodeFlat(ByteBuffer _bb) { return GetRootAsGroundNodeFlat(_bb, new GroundNodeFlat()); }
  public static GroundNodeFlat GetRootAsGroundNodeFlat(ByteBuffer _bb, GroundNodeFlat obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GroundNodeFlat __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int X { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Y { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool IsCanNotUseSkill { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public FlatData.GroundVector3? Position { get { int o = __p.__offset(10); return o != 0 ? (FlatData.GroundVector3?)(new FlatData.GroundVector3()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public FlatData.GroundNodeType NodeType { get { int o = __p.__offset(12); return o != 0 ? (FlatData.GroundNodeType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.GroundNodeType.None; } }
  public FlatData.GroundNodeType OriginalNodeType { get { int o = __p.__offset(14); return o != 0 ? (FlatData.GroundNodeType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.GroundNodeType.None; } }

  public static Offset<FlatData.GroundNodeFlat> CreateGroundNodeFlat(FlatBufferBuilder builder,
      int X = 0,
      int Y = 0,
      bool IsCanNotUseSkill = false,
      Offset<FlatData.GroundVector3> PositionOffset = default(Offset<FlatData.GroundVector3>),
      FlatData.GroundNodeType NodeType = FlatData.GroundNodeType.None,
      FlatData.GroundNodeType OriginalNodeType = FlatData.GroundNodeType.None) {
    builder.StartTable(6);
    GroundNodeFlat.AddOriginalNodeType(builder, OriginalNodeType);
    GroundNodeFlat.AddNodeType(builder, NodeType);
    GroundNodeFlat.AddPosition(builder, PositionOffset);
    GroundNodeFlat.AddY(builder, Y);
    GroundNodeFlat.AddX(builder, X);
    GroundNodeFlat.AddIsCanNotUseSkill(builder, IsCanNotUseSkill);
    return GroundNodeFlat.EndGroundNodeFlat(builder);
  }

  public static void StartGroundNodeFlat(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddX(FlatBufferBuilder builder, int x) { builder.AddInt(0, x, 0); }
  public static void AddY(FlatBufferBuilder builder, int y) { builder.AddInt(1, y, 0); }
  public static void AddIsCanNotUseSkill(FlatBufferBuilder builder, bool isCanNotUseSkill) { builder.AddBool(2, isCanNotUseSkill, false); }
  public static void AddPosition(FlatBufferBuilder builder, Offset<FlatData.GroundVector3> positionOffset) { builder.AddOffset(3, positionOffset.Value, 0); }
  public static void AddNodeType(FlatBufferBuilder builder, FlatData.GroundNodeType nodeType) { builder.AddInt(4, (int)nodeType, 0); }
  public static void AddOriginalNodeType(FlatBufferBuilder builder, FlatData.GroundNodeType originalNodeType) { builder.AddInt(5, (int)originalNodeType, 0); }
  public static Offset<FlatData.GroundNodeFlat> EndGroundNodeFlat(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.GroundNodeFlat>(o);
  }
  public GroundNodeFlatT UnPack() {
    var _o = new GroundNodeFlatT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(GroundNodeFlatT _o) {
    _o.X = this.X;
    _o.Y = this.Y;
    _o.IsCanNotUseSkill = this.IsCanNotUseSkill;
    _o.Position = this.Position.HasValue ? this.Position.Value.UnPack() : null;
    _o.NodeType = this.NodeType;
    _o.OriginalNodeType = this.OriginalNodeType;
  }
  public static Offset<FlatData.GroundNodeFlat> Pack(FlatBufferBuilder builder, GroundNodeFlatT _o) {
    if (_o == null) return default(Offset<FlatData.GroundNodeFlat>);
    var _Position = _o.Position == null ? default(Offset<FlatData.GroundVector3>) : FlatData.GroundVector3.Pack(builder, _o.Position);
    return CreateGroundNodeFlat(
      builder,
      _o.X,
      _o.Y,
      _o.IsCanNotUseSkill,
      _Position,
      _o.NodeType,
      _o.OriginalNodeType);
  }
}

public class GroundNodeFlatT
{
  [Newtonsoft.Json.JsonProperty("X")]
  public int X { get; set; }
  [Newtonsoft.Json.JsonProperty("Y")]
  public int Y { get; set; }
  [Newtonsoft.Json.JsonProperty("IsCanNotUseSkill")]
  public bool IsCanNotUseSkill { get; set; }
  [Newtonsoft.Json.JsonProperty("Position")]
  public FlatData.GroundVector3T Position { get; set; }
  [Newtonsoft.Json.JsonProperty("NodeType")]
  public FlatData.GroundNodeType NodeType { get; set; }
  [Newtonsoft.Json.JsonProperty("OriginalNodeType")]
  public FlatData.GroundNodeType OriginalNodeType { get; set; }

  public GroundNodeFlatT() {
    this.X = 0;
    this.Y = 0;
    this.IsCanNotUseSkill = false;
    this.Position = null;
    this.NodeType = FlatData.GroundNodeType.None;
    this.OriginalNodeType = FlatData.GroundNodeType.None;
  }
}


static public class GroundNodeFlatVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*X*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Y*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*IsCanNotUseSkill*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTable(tablePos, 10 /*Position*/, FlatData.GroundVector3Verify.Verify, false)
      && verifier.VerifyField(tablePos, 12 /*NodeType*/, 4 /*FlatData.GroundNodeType*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*OriginalNodeType*/, 4 /*FlatData.GroundNodeType*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}