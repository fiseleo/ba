// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GroundGridFlat : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static GroundGridFlat GetRootAsGroundGridFlat(ByteBuffer _bb) { return GetRootAsGroundGridFlat(_bb, new GroundGridFlat()); }
  public static GroundGridFlat GetRootAsGroundGridFlat(ByteBuffer _bb, GroundGridFlat obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GroundGridFlat __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int X { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Y { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float StartX { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float StartY { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Gap { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public FlatData.GroundNodeFlat? Nodes(int j) { int o = __p.__offset(14); return o != 0 ? (FlatData.GroundNodeFlat?)(new FlatData.GroundNodeFlat()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int NodesLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string Version { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVersionBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetVersionBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetVersionArray() { return __p.__vector_as_array<byte>(16); }

  public static Offset<FlatData.GroundGridFlat> CreateGroundGridFlat(FlatBufferBuilder builder,
      int X = 0,
      int Y = 0,
      float StartX = 0.0f,
      float StartY = 0.0f,
      float Gap = 0.0f,
      VectorOffset NodesOffset = default(VectorOffset),
      StringOffset VersionOffset = default(StringOffset)) {
    builder.StartTable(7);
    GroundGridFlat.AddVersion(builder, VersionOffset);
    GroundGridFlat.AddNodes(builder, NodesOffset);
    GroundGridFlat.AddGap(builder, Gap);
    GroundGridFlat.AddStartY(builder, StartY);
    GroundGridFlat.AddStartX(builder, StartX);
    GroundGridFlat.AddY(builder, Y);
    GroundGridFlat.AddX(builder, X);
    return GroundGridFlat.EndGroundGridFlat(builder);
  }

  public static void StartGroundGridFlat(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddX(FlatBufferBuilder builder, int x) { builder.AddInt(0, x, 0); }
  public static void AddY(FlatBufferBuilder builder, int y) { builder.AddInt(1, y, 0); }
  public static void AddStartX(FlatBufferBuilder builder, float startX) { builder.AddFloat(2, startX, 0.0f); }
  public static void AddStartY(FlatBufferBuilder builder, float startY) { builder.AddFloat(3, startY, 0.0f); }
  public static void AddGap(FlatBufferBuilder builder, float gap) { builder.AddFloat(4, gap, 0.0f); }
  public static void AddNodes(FlatBufferBuilder builder, VectorOffset nodesOffset) { builder.AddOffset(5, nodesOffset.Value, 0); }
  public static VectorOffset CreateNodesVector(FlatBufferBuilder builder, Offset<FlatData.GroundNodeFlat>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, Offset<FlatData.GroundNodeFlat>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FlatData.GroundNodeFlat>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateNodesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FlatData.GroundNodeFlat>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartNodesVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVersion(FlatBufferBuilder builder, StringOffset versionOffset) { builder.AddOffset(6, versionOffset.Value, 0); }
  public static Offset<FlatData.GroundGridFlat> EndGroundGridFlat(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.GroundGridFlat>(o);
  }
  public GroundGridFlatT UnPack() {
    var _o = new GroundGridFlatT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(GroundGridFlatT _o) {
    _o.X = this.X;
    _o.Y = this.Y;
    _o.StartX = this.StartX;
    _o.StartY = this.StartY;
    _o.Gap = this.Gap;
    _o.Nodes = new List<FlatData.GroundNodeFlatT>();
    for (var _j = 0; _j < this.NodesLength; ++_j) {_o.Nodes.Add(this.Nodes(_j).HasValue ? this.Nodes(_j).Value.UnPack() : null);}
    _o.Version = this.Version;
  }
  public static Offset<FlatData.GroundGridFlat> Pack(FlatBufferBuilder builder, GroundGridFlatT _o) {
    if (_o == null) return default(Offset<FlatData.GroundGridFlat>);
    var _Nodes = default(VectorOffset);
    if (_o.Nodes != null) {
      var __Nodes = new Offset<FlatData.GroundNodeFlat>[_o.Nodes.Count];
      for (var _j = 0; _j < __Nodes.Length; ++_j) { __Nodes[_j] = FlatData.GroundNodeFlat.Pack(builder, _o.Nodes[_j]); }
      _Nodes = CreateNodesVector(builder, __Nodes);
    }
    var _Version = _o.Version == null ? default(StringOffset) : builder.CreateString(_o.Version);
    return CreateGroundGridFlat(
      builder,
      _o.X,
      _o.Y,
      _o.StartX,
      _o.StartY,
      _o.Gap,
      _Nodes,
      _Version);
  }
}

public class GroundGridFlatT
{
  [Newtonsoft.Json.JsonProperty("X")]
  public int X { get; set; }
  [Newtonsoft.Json.JsonProperty("Y")]
  public int Y { get; set; }
  [Newtonsoft.Json.JsonProperty("StartX")]
  public float StartX { get; set; }
  [Newtonsoft.Json.JsonProperty("StartY")]
  public float StartY { get; set; }
  [Newtonsoft.Json.JsonProperty("Gap")]
  public float Gap { get; set; }
  [Newtonsoft.Json.JsonProperty("Nodes")]
  public List<FlatData.GroundNodeFlatT> Nodes { get; set; }
  [Newtonsoft.Json.JsonProperty("Version")]
  public string Version { get; set; }

  public GroundGridFlatT() {
    this.X = 0;
    this.Y = 0;
    this.StartX = 0.0f;
    this.StartY = 0.0f;
    this.Gap = 0.0f;
    this.Nodes = null;
    this.Version = null;
  }
}


static public class GroundGridFlatVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*X*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Y*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*StartX*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*StartY*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*Gap*/, 4 /*float*/, 4, false)
      && verifier.VerifyVectorOfTables(tablePos, 14 /*Nodes*/, FlatData.GroundNodeFlatVerify.Verify, false)
      && verifier.VerifyString(tablePos, 16 /*Version*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}