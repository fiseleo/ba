// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MoveEnd : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MoveEnd GetRootAsMoveEnd(ByteBuffer _bb) { return GetRootAsMoveEnd(_bb, new MoveEnd()); }
  public static MoveEnd GetRootAsMoveEnd(ByteBuffer _bb, MoveEnd obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MoveEnd __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatData.Motion? Normal { get { int o = __p.__offset(4); return o != 0 ? (FlatData.Motion?)(new FlatData.Motion()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public FlatData.Motion? Stand { get { int o = __p.__offset(6); return o != 0 ? (FlatData.Motion?)(new FlatData.Motion()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public FlatData.Motion? Kneel { get { int o = __p.__offset(8); return o != 0 ? (FlatData.Motion?)(new FlatData.Motion()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static Offset<FlatData.MoveEnd> CreateMoveEnd(FlatBufferBuilder builder,
      Offset<FlatData.Motion> NormalOffset = default(Offset<FlatData.Motion>),
      Offset<FlatData.Motion> StandOffset = default(Offset<FlatData.Motion>),
      Offset<FlatData.Motion> KneelOffset = default(Offset<FlatData.Motion>)) {
    builder.StartTable(3);
    MoveEnd.AddKneel(builder, KneelOffset);
    MoveEnd.AddStand(builder, StandOffset);
    MoveEnd.AddNormal(builder, NormalOffset);
    return MoveEnd.EndMoveEnd(builder);
  }

  public static void StartMoveEnd(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddNormal(FlatBufferBuilder builder, Offset<FlatData.Motion> normalOffset) { builder.AddOffset(0, normalOffset.Value, 0); }
  public static void AddStand(FlatBufferBuilder builder, Offset<FlatData.Motion> standOffset) { builder.AddOffset(1, standOffset.Value, 0); }
  public static void AddKneel(FlatBufferBuilder builder, Offset<FlatData.Motion> kneelOffset) { builder.AddOffset(2, kneelOffset.Value, 0); }
  public static Offset<FlatData.MoveEnd> EndMoveEnd(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.MoveEnd>(o);
  }
  public MoveEndT UnPack() {
    var _o = new MoveEndT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MoveEndT _o) {
    _o.Normal = this.Normal.HasValue ? this.Normal.Value.UnPack() : null;
    _o.Stand = this.Stand.HasValue ? this.Stand.Value.UnPack() : null;
    _o.Kneel = this.Kneel.HasValue ? this.Kneel.Value.UnPack() : null;
  }
  public static Offset<FlatData.MoveEnd> Pack(FlatBufferBuilder builder, MoveEndT _o) {
    if (_o == null) return default(Offset<FlatData.MoveEnd>);
    var _Normal = _o.Normal == null ? default(Offset<FlatData.Motion>) : FlatData.Motion.Pack(builder, _o.Normal);
    var _Stand = _o.Stand == null ? default(Offset<FlatData.Motion>) : FlatData.Motion.Pack(builder, _o.Stand);
    var _Kneel = _o.Kneel == null ? default(Offset<FlatData.Motion>) : FlatData.Motion.Pack(builder, _o.Kneel);
    return CreateMoveEnd(
      builder,
      _Normal,
      _Stand,
      _Kneel);
  }
}

public class MoveEndT
{
  [Newtonsoft.Json.JsonProperty("Normal")]
  public FlatData.MotionT Normal { get; set; }
  [Newtonsoft.Json.JsonProperty("Stand")]
  public FlatData.MotionT Stand { get; set; }
  [Newtonsoft.Json.JsonProperty("Kneel")]
  public FlatData.MotionT Kneel { get; set; }

  public MoveEndT() {
    this.Normal = null;
    this.Stand = null;
    this.Kneel = null;
  }
}


static public class MoveEndVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyTable(tablePos, 4 /*Normal*/, FlatData.MotionVerify.Verify, false)
      && verifier.VerifyTable(tablePos, 6 /*Stand*/, FlatData.MotionVerify.Verify, false)
      && verifier.VerifyTable(tablePos, 8 /*Kneel*/, FlatData.MotionVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
