// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ScenarioScriptField1Excel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ScenarioScriptField1Excel GetRootAsScenarioScriptField1Excel(ByteBuffer _bb) { return GetRootAsScenarioScriptField1Excel(_bb, new ScenarioScriptField1Excel()); }
  public static ScenarioScriptField1Excel GetRootAsScenarioScriptField1Excel(ByteBuffer _bb, ScenarioScriptField1Excel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ScenarioScriptField1Excel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long GroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SelectionGroup { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BGMId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string Sound { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSoundBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetSoundBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetSoundArray() { return __p.__vector_as_array<byte>(10); }
  public uint Transition { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint BGName { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint BGEffect { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string PopupFileName { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPopupFileNameBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetPopupFileNameBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetPopupFileNameArray() { return __p.__vector_as_array<byte>(18); }
  public string ScriptKr { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetScriptKrBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetScriptKrBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetScriptKrArray() { return __p.__vector_as_array<byte>(20); }
  public string TextJp { get { int o = __p.__offset(22); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTextJpBytes() { return __p.__vector_as_span<byte>(22, 1); }
#else
  public ArraySegment<byte>? GetTextJpBytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public byte[] GetTextJpArray() { return __p.__vector_as_array<byte>(22); }
  public string VoiceJp { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVoiceJpBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetVoiceJpBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetVoiceJpArray() { return __p.__vector_as_array<byte>(24); }

  public static Offset<FlatData.ScenarioScriptField1Excel> CreateScenarioScriptField1Excel(FlatBufferBuilder builder,
      long GroupId = 0,
      long SelectionGroup = 0,
      long BGMId = 0,
      StringOffset SoundOffset = default(StringOffset),
      uint Transition = 0,
      uint BGName = 0,
      uint BGEffect = 0,
      StringOffset PopupFileNameOffset = default(StringOffset),
      StringOffset ScriptKrOffset = default(StringOffset),
      StringOffset TextJpOffset = default(StringOffset),
      StringOffset VoiceJpOffset = default(StringOffset)) {
    builder.StartTable(11);
    ScenarioScriptField1Excel.AddBGMId(builder, BGMId);
    ScenarioScriptField1Excel.AddSelectionGroup(builder, SelectionGroup);
    ScenarioScriptField1Excel.AddGroupId(builder, GroupId);
    ScenarioScriptField1Excel.AddVoiceJp(builder, VoiceJpOffset);
    ScenarioScriptField1Excel.AddTextJp(builder, TextJpOffset);
    ScenarioScriptField1Excel.AddScriptKr(builder, ScriptKrOffset);
    ScenarioScriptField1Excel.AddPopupFileName(builder, PopupFileNameOffset);
    ScenarioScriptField1Excel.AddBGEffect(builder, BGEffect);
    ScenarioScriptField1Excel.AddBGName(builder, BGName);
    ScenarioScriptField1Excel.AddTransition(builder, Transition);
    ScenarioScriptField1Excel.AddSound(builder, SoundOffset);
    return ScenarioScriptField1Excel.EndScenarioScriptField1Excel(builder);
  }

  public static void StartScenarioScriptField1Excel(FlatBufferBuilder builder) { builder.StartTable(11); }
  public static void AddGroupId(FlatBufferBuilder builder, long groupId) { builder.AddLong(0, groupId, 0); }
  public static void AddSelectionGroup(FlatBufferBuilder builder, long selectionGroup) { builder.AddLong(1, selectionGroup, 0); }
  public static void AddBGMId(FlatBufferBuilder builder, long bGMId) { builder.AddLong(2, bGMId, 0); }
  public static void AddSound(FlatBufferBuilder builder, StringOffset soundOffset) { builder.AddOffset(3, soundOffset.Value, 0); }
  public static void AddTransition(FlatBufferBuilder builder, uint transition) { builder.AddUint(4, transition, 0); }
  public static void AddBGName(FlatBufferBuilder builder, uint bGName) { builder.AddUint(5, bGName, 0); }
  public static void AddBGEffect(FlatBufferBuilder builder, uint bGEffect) { builder.AddUint(6, bGEffect, 0); }
  public static void AddPopupFileName(FlatBufferBuilder builder, StringOffset popupFileNameOffset) { builder.AddOffset(7, popupFileNameOffset.Value, 0); }
  public static void AddScriptKr(FlatBufferBuilder builder, StringOffset scriptKrOffset) { builder.AddOffset(8, scriptKrOffset.Value, 0); }
  public static void AddTextJp(FlatBufferBuilder builder, StringOffset textJpOffset) { builder.AddOffset(9, textJpOffset.Value, 0); }
  public static void AddVoiceJp(FlatBufferBuilder builder, StringOffset voiceJpOffset) { builder.AddOffset(10, voiceJpOffset.Value, 0); }
  public static Offset<FlatData.ScenarioScriptField1Excel> EndScenarioScriptField1Excel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.ScenarioScriptField1Excel>(o);
  }
  public ScenarioScriptField1ExcelT UnPack() {
    var _o = new ScenarioScriptField1ExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ScenarioScriptField1ExcelT _o) {
    _o.GroupId = this.GroupId;
    _o.SelectionGroup = this.SelectionGroup;
    _o.BGMId = this.BGMId;
    _o.Sound = this.Sound;
    _o.Transition = this.Transition;
    _o.BGName = this.BGName;
    _o.BGEffect = this.BGEffect;
    _o.PopupFileName = this.PopupFileName;
    _o.ScriptKr = this.ScriptKr;
    _o.TextJp = this.TextJp;
    _o.VoiceJp = this.VoiceJp;
  }
  public static Offset<FlatData.ScenarioScriptField1Excel> Pack(FlatBufferBuilder builder, ScenarioScriptField1ExcelT _o) {
    if (_o == null) return default(Offset<FlatData.ScenarioScriptField1Excel>);
    var _Sound = _o.Sound == null ? default(StringOffset) : builder.CreateString(_o.Sound);
    var _PopupFileName = _o.PopupFileName == null ? default(StringOffset) : builder.CreateString(_o.PopupFileName);
    var _ScriptKr = _o.ScriptKr == null ? default(StringOffset) : builder.CreateString(_o.ScriptKr);
    var _TextJp = _o.TextJp == null ? default(StringOffset) : builder.CreateString(_o.TextJp);
    var _VoiceJp = _o.VoiceJp == null ? default(StringOffset) : builder.CreateString(_o.VoiceJp);
    return CreateScenarioScriptField1Excel(
      builder,
      _o.GroupId,
      _o.SelectionGroup,
      _o.BGMId,
      _Sound,
      _o.Transition,
      _o.BGName,
      _o.BGEffect,
      _PopupFileName,
      _ScriptKr,
      _TextJp,
      _VoiceJp);
  }
}

public class ScenarioScriptField1ExcelT
{
  [Newtonsoft.Json.JsonProperty("GroupId")]
  public long GroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("SelectionGroup")]
  public long SelectionGroup { get; set; }
  [Newtonsoft.Json.JsonProperty("BGMId")]
  public long BGMId { get; set; }
  [Newtonsoft.Json.JsonProperty("Sound")]
  public string Sound { get; set; }
  [Newtonsoft.Json.JsonProperty("Transition")]
  public uint Transition { get; set; }
  [Newtonsoft.Json.JsonProperty("BGName")]
  public uint BGName { get; set; }
  [Newtonsoft.Json.JsonProperty("BGEffect")]
  public uint BGEffect { get; set; }
  [Newtonsoft.Json.JsonProperty("PopupFileName")]
  public string PopupFileName { get; set; }
  [Newtonsoft.Json.JsonProperty("ScriptKr")]
  public string ScriptKr { get; set; }
  [Newtonsoft.Json.JsonProperty("TextJp")]
  public string TextJp { get; set; }
  [Newtonsoft.Json.JsonProperty("VoiceJp")]
  public string VoiceJp { get; set; }

  public ScenarioScriptField1ExcelT() {
    this.GroupId = 0;
    this.SelectionGroup = 0;
    this.BGMId = 0;
    this.Sound = null;
    this.Transition = 0;
    this.BGName = 0;
    this.BGEffect = 0;
    this.PopupFileName = null;
    this.ScriptKr = null;
    this.TextJp = null;
    this.VoiceJp = null;
  }
}


static public class ScenarioScriptField1ExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*GroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*SelectionGroup*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*BGMId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 10 /*Sound*/, false)
      && verifier.VerifyField(tablePos, 12 /*Transition*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*BGName*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*BGEffect*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 18 /*PopupFileName*/, false)
      && verifier.VerifyString(tablePos, 20 /*ScriptKr*/, false)
      && verifier.VerifyString(tablePos, 22 /*TextJp*/, false)
      && verifier.VerifyString(tablePos, 24 /*VoiceJp*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
