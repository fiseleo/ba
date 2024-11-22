// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct PropVector3 : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static PropVector3 GetRootAsPropVector3(ByteBuffer _bb) { return GetRootAsPropVector3(_bb, new PropVector3()); }
  public static PropVector3 GetRootAsPropVector3(ByteBuffer _bb, PropVector3 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PropVector3 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float X { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Y { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Z { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<FlatData.PropVector3> CreatePropVector3(FlatBufferBuilder builder,
      float X = 0.0f,
      float Y = 0.0f,
      float Z = 0.0f) {
    builder.StartTable(3);
    PropVector3.AddZ(builder, Z);
    PropVector3.AddY(builder, Y);
    PropVector3.AddX(builder, X);
    return PropVector3.EndPropVector3(builder);
  }

  public static void StartPropVector3(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddX(FlatBufferBuilder builder, float x) { builder.AddFloat(0, x, 0.0f); }
  public static void AddY(FlatBufferBuilder builder, float y) { builder.AddFloat(1, y, 0.0f); }
  public static void AddZ(FlatBufferBuilder builder, float z) { builder.AddFloat(2, z, 0.0f); }
  public static Offset<FlatData.PropVector3> EndPropVector3(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.PropVector3>(o);
  }
  public PropVector3T UnPack() {
    var _o = new PropVector3T();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(PropVector3T _o) {
    _o.X = this.X;
    _o.Y = this.Y;
    _o.Z = this.Z;
  }
  public static Offset<FlatData.PropVector3> Pack(FlatBufferBuilder builder, PropVector3T _o) {
    if (_o == null) return default(Offset<FlatData.PropVector3>);
    return CreatePropVector3(
      builder,
      _o.X,
      _o.Y,
      _o.Z);
  }
}

public class PropVector3T
{
  [Newtonsoft.Json.JsonProperty("X")]
  public float X { get; set; }
  [Newtonsoft.Json.JsonProperty("Y")]
  public float Y { get; set; }
  [Newtonsoft.Json.JsonProperty("Z")]
  public float Z { get; set; }

  public PropVector3T() {
    this.X = 0.0f;
    this.Y = 0.0f;
    this.Z = 0.0f;
  }
}


static public class PropVector3Verify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*X*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Y*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Z*/, 4 /*float*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
