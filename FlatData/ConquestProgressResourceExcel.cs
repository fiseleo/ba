// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ConquestProgressResourceExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ConquestProgressResourceExcel GetRootAsConquestProgressResourceExcel(ByteBuffer _bb) { return GetRootAsConquestProgressResourceExcel(_bb, new ConquestProgressResourceExcel()); }
  public static ConquestProgressResourceExcel GetRootAsConquestProgressResourceExcel(ByteBuffer _bb, ConquestProgressResourceExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConquestProgressResourceExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventContentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.ConquestProgressType Group { get { int o = __p.__offset(8); return o != 0 ? (FlatData.ConquestProgressType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.ConquestProgressType.None; } }
  public string ProgressResource { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetProgressResourceBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetProgressResourceBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetProgressResourceArray() { return __p.__vector_as_array<byte>(10); }
  public uint VoiceId(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int VoiceIdLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<uint> GetVoiceIdBytes() { return __p.__vector_as_span<uint>(12, 4); }
#else
  public ArraySegment<byte>? GetVoiceIdBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public uint[] GetVoiceIdArray() { return __p.__vector_as_array<uint>(12); }
  public string ProgressLocalizeCode { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetProgressLocalizeCodeBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetProgressLocalizeCodeBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetProgressLocalizeCodeArray() { return __p.__vector_as_array<byte>(14); }

  public static Offset<FlatData.ConquestProgressResourceExcel> CreateConquestProgressResourceExcel(FlatBufferBuilder builder,
      long Id = 0,
      long EventContentId = 0,
      FlatData.ConquestProgressType Group = FlatData.ConquestProgressType.None,
      StringOffset ProgressResourceOffset = default(StringOffset),
      VectorOffset VoiceIdOffset = default(VectorOffset),
      StringOffset ProgressLocalizeCodeOffset = default(StringOffset)) {
    builder.StartTable(6);
    ConquestProgressResourceExcel.AddEventContentId(builder, EventContentId);
    ConquestProgressResourceExcel.AddId(builder, Id);
    ConquestProgressResourceExcel.AddProgressLocalizeCode(builder, ProgressLocalizeCodeOffset);
    ConquestProgressResourceExcel.AddVoiceId(builder, VoiceIdOffset);
    ConquestProgressResourceExcel.AddProgressResource(builder, ProgressResourceOffset);
    ConquestProgressResourceExcel.AddGroup(builder, Group);
    return ConquestProgressResourceExcel.EndConquestProgressResourceExcel(builder);
  }

  public static void StartConquestProgressResourceExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(1, eventContentId, 0); }
  public static void AddGroup(FlatBufferBuilder builder, FlatData.ConquestProgressType group) { builder.AddInt(2, (int)group, 0); }
  public static void AddProgressResource(FlatBufferBuilder builder, StringOffset progressResourceOffset) { builder.AddOffset(3, progressResourceOffset.Value, 0); }
  public static void AddVoiceId(FlatBufferBuilder builder, VectorOffset voiceIdOffset) { builder.AddOffset(4, voiceIdOffset.Value, 0); }
  public static VectorOffset CreateVoiceIdVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateVoiceIdVectorBlock(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceIdVectorBlock(FlatBufferBuilder builder, ArraySegment<uint> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateVoiceIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<uint>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartVoiceIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddProgressLocalizeCode(FlatBufferBuilder builder, StringOffset progressLocalizeCodeOffset) { builder.AddOffset(5, progressLocalizeCodeOffset.Value, 0); }
  public static Offset<FlatData.ConquestProgressResourceExcel> EndConquestProgressResourceExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.ConquestProgressResourceExcel>(o);
  }
  public ConquestProgressResourceExcelT UnPack() {
    var _o = new ConquestProgressResourceExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ConquestProgressResourceExcelT _o) {
    _o.Id = this.Id;
    _o.EventContentId = this.EventContentId;
    _o.Group = this.Group;
    _o.ProgressResource = this.ProgressResource;
    _o.VoiceId = new List<uint>();
    for (var _j = 0; _j < this.VoiceIdLength; ++_j) {_o.VoiceId.Add(this.VoiceId(_j));}
    _o.ProgressLocalizeCode = this.ProgressLocalizeCode;
  }
  public static Offset<FlatData.ConquestProgressResourceExcel> Pack(FlatBufferBuilder builder, ConquestProgressResourceExcelT _o) {
    if (_o == null) return default(Offset<FlatData.ConquestProgressResourceExcel>);
    var _ProgressResource = _o.ProgressResource == null ? default(StringOffset) : builder.CreateString(_o.ProgressResource);
    var _VoiceId = default(VectorOffset);
    if (_o.VoiceId != null) {
      var __VoiceId = _o.VoiceId.ToArray();
      _VoiceId = CreateVoiceIdVector(builder, __VoiceId);
    }
    var _ProgressLocalizeCode = _o.ProgressLocalizeCode == null ? default(StringOffset) : builder.CreateString(_o.ProgressLocalizeCode);
    return CreateConquestProgressResourceExcel(
      builder,
      _o.Id,
      _o.EventContentId,
      _o.Group,
      _ProgressResource,
      _VoiceId,
      _ProgressLocalizeCode);
  }
}

public class ConquestProgressResourceExcelT
{
  [Newtonsoft.Json.JsonProperty("Id")]
  public long Id { get; set; }
  [Newtonsoft.Json.JsonProperty("EventContentId")]
  public long EventContentId { get; set; }
  [Newtonsoft.Json.JsonProperty("Group")]
  public FlatData.ConquestProgressType Group { get; set; }
  [Newtonsoft.Json.JsonProperty("ProgressResource")]
  public string ProgressResource { get; set; }
  [Newtonsoft.Json.JsonProperty("VoiceId")]
  public List<uint> VoiceId { get; set; }
  [Newtonsoft.Json.JsonProperty("ProgressLocalizeCode")]
  public string ProgressLocalizeCode { get; set; }

  public ConquestProgressResourceExcelT() {
    this.Id = 0;
    this.EventContentId = 0;
    this.Group = FlatData.ConquestProgressType.None;
    this.ProgressResource = null;
    this.VoiceId = null;
    this.ProgressLocalizeCode = null;
  }
}


static public class ConquestProgressResourceExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*Group*/, 4 /*FlatData.ConquestProgressType*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*ProgressResource*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*VoiceId*/, 4 /*uint*/, false)
      && verifier.VerifyString(tablePos, 14 /*ProgressLocalizeCode*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}