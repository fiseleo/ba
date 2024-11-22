// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MinigameTBGEncounterOptionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MinigameTBGEncounterOptionExcel GetRootAsMinigameTBGEncounterOptionExcel(ByteBuffer _bb) { return GetRootAsMinigameTBGEncounterOptionExcel(_bb, new MinigameTBGEncounterOptionExcel()); }
  public static MinigameTBGEncounterOptionExcel GetRootAsMinigameTBGEncounterOptionExcel(ByteBuffer _bb, MinigameTBGEncounterOptionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MinigameTBGEncounterOptionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long OptionGroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long UniqueId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int SlotIndex { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string OptionTitleLocalize { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOptionTitleLocalizeBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetOptionTitleLocalizeBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetOptionTitleLocalizeArray() { return __p.__vector_as_array<byte>(10); }
  public string OptionSuccessLocalize { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOptionSuccessLocalizeBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetOptionSuccessLocalizeBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetOptionSuccessLocalizeArray() { return __p.__vector_as_array<byte>(12); }
  public long OptionSuccessRewardGroupId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int OptionSuccessOrHigherDiceCount { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int OptionGreatSuccessOrHigherDiceCount { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string OptionFailLocalize { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOptionFailLocalizeBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetOptionFailLocalizeBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetOptionFailLocalizeArray() { return __p.__vector_as_array<byte>(20); }
  public int OptionFailLessDiceCount { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RunawayOrHigherDiceCount { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool RewardHide { get { int o = __p.__offset(26); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatData.MinigameTBGEncounterOptionExcel> CreateMinigameTBGEncounterOptionExcel(FlatBufferBuilder builder,
      long OptionGroupId = 0,
      long UniqueId = 0,
      int SlotIndex = 0,
      StringOffset OptionTitleLocalizeOffset = default(StringOffset),
      StringOffset OptionSuccessLocalizeOffset = default(StringOffset),
      long OptionSuccessRewardGroupId = 0,
      int OptionSuccessOrHigherDiceCount = 0,
      int OptionGreatSuccessOrHigherDiceCount = 0,
      StringOffset OptionFailLocalizeOffset = default(StringOffset),
      int OptionFailLessDiceCount = 0,
      int RunawayOrHigherDiceCount = 0,
      bool RewardHide = false) {
    builder.StartTable(12);
    MinigameTBGEncounterOptionExcel.AddOptionSuccessRewardGroupId(builder, OptionSuccessRewardGroupId);
    MinigameTBGEncounterOptionExcel.AddUniqueId(builder, UniqueId);
    MinigameTBGEncounterOptionExcel.AddOptionGroupId(builder, OptionGroupId);
    MinigameTBGEncounterOptionExcel.AddRunawayOrHigherDiceCount(builder, RunawayOrHigherDiceCount);
    MinigameTBGEncounterOptionExcel.AddOptionFailLessDiceCount(builder, OptionFailLessDiceCount);
    MinigameTBGEncounterOptionExcel.AddOptionFailLocalize(builder, OptionFailLocalizeOffset);
    MinigameTBGEncounterOptionExcel.AddOptionGreatSuccessOrHigherDiceCount(builder, OptionGreatSuccessOrHigherDiceCount);
    MinigameTBGEncounterOptionExcel.AddOptionSuccessOrHigherDiceCount(builder, OptionSuccessOrHigherDiceCount);
    MinigameTBGEncounterOptionExcel.AddOptionSuccessLocalize(builder, OptionSuccessLocalizeOffset);
    MinigameTBGEncounterOptionExcel.AddOptionTitleLocalize(builder, OptionTitleLocalizeOffset);
    MinigameTBGEncounterOptionExcel.AddSlotIndex(builder, SlotIndex);
    MinigameTBGEncounterOptionExcel.AddRewardHide(builder, RewardHide);
    return MinigameTBGEncounterOptionExcel.EndMinigameTBGEncounterOptionExcel(builder);
  }

  public static void StartMinigameTBGEncounterOptionExcel(FlatBufferBuilder builder) { builder.StartTable(12); }
  public static void AddOptionGroupId(FlatBufferBuilder builder, long optionGroupId) { builder.AddLong(0, optionGroupId, 0); }
  public static void AddUniqueId(FlatBufferBuilder builder, long uniqueId) { builder.AddLong(1, uniqueId, 0); }
  public static void AddSlotIndex(FlatBufferBuilder builder, int slotIndex) { builder.AddInt(2, slotIndex, 0); }
  public static void AddOptionTitleLocalize(FlatBufferBuilder builder, StringOffset optionTitleLocalizeOffset) { builder.AddOffset(3, optionTitleLocalizeOffset.Value, 0); }
  public static void AddOptionSuccessLocalize(FlatBufferBuilder builder, StringOffset optionSuccessLocalizeOffset) { builder.AddOffset(4, optionSuccessLocalizeOffset.Value, 0); }
  public static void AddOptionSuccessRewardGroupId(FlatBufferBuilder builder, long optionSuccessRewardGroupId) { builder.AddLong(5, optionSuccessRewardGroupId, 0); }
  public static void AddOptionSuccessOrHigherDiceCount(FlatBufferBuilder builder, int optionSuccessOrHigherDiceCount) { builder.AddInt(6, optionSuccessOrHigherDiceCount, 0); }
  public static void AddOptionGreatSuccessOrHigherDiceCount(FlatBufferBuilder builder, int optionGreatSuccessOrHigherDiceCount) { builder.AddInt(7, optionGreatSuccessOrHigherDiceCount, 0); }
  public static void AddOptionFailLocalize(FlatBufferBuilder builder, StringOffset optionFailLocalizeOffset) { builder.AddOffset(8, optionFailLocalizeOffset.Value, 0); }
  public static void AddOptionFailLessDiceCount(FlatBufferBuilder builder, int optionFailLessDiceCount) { builder.AddInt(9, optionFailLessDiceCount, 0); }
  public static void AddRunawayOrHigherDiceCount(FlatBufferBuilder builder, int runawayOrHigherDiceCount) { builder.AddInt(10, runawayOrHigherDiceCount, 0); }
  public static void AddRewardHide(FlatBufferBuilder builder, bool rewardHide) { builder.AddBool(11, rewardHide, false); }
  public static Offset<FlatData.MinigameTBGEncounterOptionExcel> EndMinigameTBGEncounterOptionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.MinigameTBGEncounterOptionExcel>(o);
  }
  public MinigameTBGEncounterOptionExcelT UnPack() {
    var _o = new MinigameTBGEncounterOptionExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MinigameTBGEncounterOptionExcelT _o) {
    _o.OptionGroupId = this.OptionGroupId;
    _o.UniqueId = this.UniqueId;
    _o.SlotIndex = this.SlotIndex;
    _o.OptionTitleLocalize = this.OptionTitleLocalize;
    _o.OptionSuccessLocalize = this.OptionSuccessLocalize;
    _o.OptionSuccessRewardGroupId = this.OptionSuccessRewardGroupId;
    _o.OptionSuccessOrHigherDiceCount = this.OptionSuccessOrHigherDiceCount;
    _o.OptionGreatSuccessOrHigherDiceCount = this.OptionGreatSuccessOrHigherDiceCount;
    _o.OptionFailLocalize = this.OptionFailLocalize;
    _o.OptionFailLessDiceCount = this.OptionFailLessDiceCount;
    _o.RunawayOrHigherDiceCount = this.RunawayOrHigherDiceCount;
    _o.RewardHide = this.RewardHide;
  }
  public static Offset<FlatData.MinigameTBGEncounterOptionExcel> Pack(FlatBufferBuilder builder, MinigameTBGEncounterOptionExcelT _o) {
    if (_o == null) return default(Offset<FlatData.MinigameTBGEncounterOptionExcel>);
    var _OptionTitleLocalize = _o.OptionTitleLocalize == null ? default(StringOffset) : builder.CreateString(_o.OptionTitleLocalize);
    var _OptionSuccessLocalize = _o.OptionSuccessLocalize == null ? default(StringOffset) : builder.CreateString(_o.OptionSuccessLocalize);
    var _OptionFailLocalize = _o.OptionFailLocalize == null ? default(StringOffset) : builder.CreateString(_o.OptionFailLocalize);
    return CreateMinigameTBGEncounterOptionExcel(
      builder,
      _o.OptionGroupId,
      _o.UniqueId,
      _o.SlotIndex,
      _OptionTitleLocalize,
      _OptionSuccessLocalize,
      _o.OptionSuccessRewardGroupId,
      _o.OptionSuccessOrHigherDiceCount,
      _o.OptionGreatSuccessOrHigherDiceCount,
      _OptionFailLocalize,
      _o.OptionFailLessDiceCount,
      _o.RunawayOrHigherDiceCount,
      _o.RewardHide);
  }
}

public class MinigameTBGEncounterOptionExcelT
{
  [Newtonsoft.Json.JsonProperty("OptionGroupId")]
  public long OptionGroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("UniqueId")]
  public long UniqueId { get; set; }
  [Newtonsoft.Json.JsonProperty("SlotIndex")]
  public int SlotIndex { get; set; }
  [Newtonsoft.Json.JsonProperty("OptionTitleLocalize")]
  public string OptionTitleLocalize { get; set; }
  [Newtonsoft.Json.JsonProperty("OptionSuccessLocalize")]
  public string OptionSuccessLocalize { get; set; }
  [Newtonsoft.Json.JsonProperty("OptionSuccessRewardGroupId")]
  public long OptionSuccessRewardGroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("OptionSuccessOrHigherDiceCount")]
  public int OptionSuccessOrHigherDiceCount { get; set; }
  [Newtonsoft.Json.JsonProperty("OptionGreatSuccessOrHigherDiceCount")]
  public int OptionGreatSuccessOrHigherDiceCount { get; set; }
  [Newtonsoft.Json.JsonProperty("OptionFailLocalize")]
  public string OptionFailLocalize { get; set; }
  [Newtonsoft.Json.JsonProperty("OptionFailLessDiceCount")]
  public int OptionFailLessDiceCount { get; set; }
  [Newtonsoft.Json.JsonProperty("RunawayOrHigherDiceCount")]
  public int RunawayOrHigherDiceCount { get; set; }
  [Newtonsoft.Json.JsonProperty("RewardHide")]
  public bool RewardHide { get; set; }

  public MinigameTBGEncounterOptionExcelT() {
    this.OptionGroupId = 0;
    this.UniqueId = 0;
    this.SlotIndex = 0;
    this.OptionTitleLocalize = null;
    this.OptionSuccessLocalize = null;
    this.OptionSuccessRewardGroupId = 0;
    this.OptionSuccessOrHigherDiceCount = 0;
    this.OptionGreatSuccessOrHigherDiceCount = 0;
    this.OptionFailLocalize = null;
    this.OptionFailLessDiceCount = 0;
    this.RunawayOrHigherDiceCount = 0;
    this.RewardHide = false;
  }
}


static public class MinigameTBGEncounterOptionExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*OptionGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*UniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*SlotIndex*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*OptionTitleLocalize*/, false)
      && verifier.VerifyString(tablePos, 12 /*OptionSuccessLocalize*/, false)
      && verifier.VerifyField(tablePos, 14 /*OptionSuccessRewardGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*OptionSuccessOrHigherDiceCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*OptionGreatSuccessOrHigherDiceCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 20 /*OptionFailLocalize*/, false)
      && verifier.VerifyField(tablePos, 22 /*OptionFailLessDiceCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*RunawayOrHigherDiceCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*RewardHide*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}