// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct PropRootMotionFlat : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static PropRootMotionFlat GetRootAsPropRootMotionFlat(ByteBuffer _bb) { return GetRootAsPropRootMotionFlat(_bb, new PropRootMotionFlat()); }
  public static PropRootMotionFlat GetRootAsPropRootMotionFlat(ByteBuffer _bb, PropRootMotionFlat obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PropRootMotionFlat __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatData.PropMotion? RootMotions(int j) { int o = __p.__offset(4); return o != 0 ? (FlatData.PropMotion?)(new FlatData.PropMotion()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int RootMotionsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatData.PropRootMotionFlat> CreatePropRootMotionFlat(FlatBufferBuilder builder,
      VectorOffset RootMotionsOffset = default(VectorOffset)) {
    builder.StartTable(1);
    PropRootMotionFlat.AddRootMotions(builder, RootMotionsOffset);
    return PropRootMotionFlat.EndPropRootMotionFlat(builder);
  }

  public static void StartPropRootMotionFlat(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddRootMotions(FlatBufferBuilder builder, VectorOffset rootMotionsOffset) { builder.AddOffset(0, rootMotionsOffset.Value, 0); }
  public static VectorOffset CreateRootMotionsVector(FlatBufferBuilder builder, Offset<FlatData.PropMotion>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateRootMotionsVectorBlock(FlatBufferBuilder builder, Offset<FlatData.PropMotion>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRootMotionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FlatData.PropMotion>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRootMotionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FlatData.PropMotion>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRootMotionsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatData.PropRootMotionFlat> EndPropRootMotionFlat(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.PropRootMotionFlat>(o);
  }
  public PropRootMotionFlatT UnPack() {
    var _o = new PropRootMotionFlatT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(PropRootMotionFlatT _o) {
    _o.RootMotions = new List<FlatData.PropMotionT>();
    for (var _j = 0; _j < this.RootMotionsLength; ++_j) {_o.RootMotions.Add(this.RootMotions(_j).HasValue ? this.RootMotions(_j).Value.UnPack() : null);}
  }
  public static Offset<FlatData.PropRootMotionFlat> Pack(FlatBufferBuilder builder, PropRootMotionFlatT _o) {
    if (_o == null) return default(Offset<FlatData.PropRootMotionFlat>);
    var _RootMotions = default(VectorOffset);
    if (_o.RootMotions != null) {
      var __RootMotions = new Offset<FlatData.PropMotion>[_o.RootMotions.Count];
      for (var _j = 0; _j < __RootMotions.Length; ++_j) { __RootMotions[_j] = FlatData.PropMotion.Pack(builder, _o.RootMotions[_j]); }
      _RootMotions = CreateRootMotionsVector(builder, __RootMotions);
    }
    return CreatePropRootMotionFlat(
      builder,
      _RootMotions);
  }
}

public class PropRootMotionFlatT
{
  [Newtonsoft.Json.JsonProperty("RootMotions")]
  public List<FlatData.PropMotionT> RootMotions { get; set; }

  public PropRootMotionFlatT() {
    this.RootMotions = null;
  }
}


static public class PropRootMotionFlatVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*RootMotions*/, FlatData.PropMotionVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
