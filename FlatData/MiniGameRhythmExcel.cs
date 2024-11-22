// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MiniGameRhythmExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MiniGameRhythmExcel GetRootAsMiniGameRhythmExcel(ByteBuffer _bb) { return GetRootAsMiniGameRhythmExcel(_bb, new MiniGameRhythmExcel()); }
  public static MiniGameRhythmExcel GetRootAsMiniGameRhythmExcel(ByteBuffer _bb, MiniGameRhythmExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MiniGameRhythmExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RhythmBgmId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string PresetName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPresetNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetPresetNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetPresetNameArray() { return __p.__vector_as_array<byte>(8); }
  public FlatData.Difficulty StageDifficulty { get { int o = __p.__offset(10); return o != 0 ? (FlatData.Difficulty)__p.bb.GetInt(o + __p.bb_pos) : FlatData.Difficulty.Normal; } }
  public bool IsSpecial { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long OpenStageScoreAmount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxHp { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MissDamage { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CriticalHPRestoreValue { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MaxScore { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FeverScoreRate { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NoteScoreRate { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ComboScoreRate { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AttackScoreRate { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float FeverCriticalRate { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float FeverAttackRate { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public long MaxHpScore { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string RhythmFileName { get { int o = __p.__offset(38); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRhythmFileNameBytes() { return __p.__vector_as_span<byte>(38, 1); }
#else
  public ArraySegment<byte>? GetRhythmFileNameBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public byte[] GetRhythmFileNameArray() { return __p.__vector_as_array<byte>(38); }
  public string ArtLevelSceneName { get { int o = __p.__offset(40); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetArtLevelSceneNameBytes() { return __p.__vector_as_span<byte>(40, 1); }
#else
  public ArraySegment<byte>? GetArtLevelSceneNameBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public byte[] GetArtLevelSceneNameArray() { return __p.__vector_as_array<byte>(40); }
  public string ComboImagePath { get { int o = __p.__offset(42); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetComboImagePathBytes() { return __p.__vector_as_span<byte>(42, 1); }
#else
  public ArraySegment<byte>? GetComboImagePathBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public byte[] GetComboImagePathArray() { return __p.__vector_as_array<byte>(42); }

  public static Offset<FlatData.MiniGameRhythmExcel> CreateMiniGameRhythmExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      long RhythmBgmId = 0,
      StringOffset PresetNameOffset = default(StringOffset),
      FlatData.Difficulty StageDifficulty = FlatData.Difficulty.Normal,
      bool IsSpecial = false,
      long OpenStageScoreAmount = 0,
      long MaxHp = 0,
      long MissDamage = 0,
      long CriticalHPRestoreValue = 0,
      long MaxScore = 0,
      long FeverScoreRate = 0,
      long NoteScoreRate = 0,
      long ComboScoreRate = 0,
      long AttackScoreRate = 0,
      float FeverCriticalRate = 0.0f,
      float FeverAttackRate = 0.0f,
      long MaxHpScore = 0,
      StringOffset RhythmFileNameOffset = default(StringOffset),
      StringOffset ArtLevelSceneNameOffset = default(StringOffset),
      StringOffset ComboImagePathOffset = default(StringOffset)) {
    builder.StartTable(20);
    MiniGameRhythmExcel.AddMaxHpScore(builder, MaxHpScore);
    MiniGameRhythmExcel.AddAttackScoreRate(builder, AttackScoreRate);
    MiniGameRhythmExcel.AddComboScoreRate(builder, ComboScoreRate);
    MiniGameRhythmExcel.AddNoteScoreRate(builder, NoteScoreRate);
    MiniGameRhythmExcel.AddFeverScoreRate(builder, FeverScoreRate);
    MiniGameRhythmExcel.AddMaxScore(builder, MaxScore);
    MiniGameRhythmExcel.AddCriticalHPRestoreValue(builder, CriticalHPRestoreValue);
    MiniGameRhythmExcel.AddMissDamage(builder, MissDamage);
    MiniGameRhythmExcel.AddMaxHp(builder, MaxHp);
    MiniGameRhythmExcel.AddOpenStageScoreAmount(builder, OpenStageScoreAmount);
    MiniGameRhythmExcel.AddRhythmBgmId(builder, RhythmBgmId);
    MiniGameRhythmExcel.AddUniqueId(builder, UniqueId);
    MiniGameRhythmExcel.AddComboImagePath(builder, ComboImagePathOffset);
    MiniGameRhythmExcel.AddArtLevelSceneName(builder, ArtLevelSceneNameOffset);
    MiniGameRhythmExcel.AddRhythmFileName(builder, RhythmFileNameOffset);
    MiniGameRhythmExcel.AddFeverAttackRate(builder, FeverAttackRate);
    MiniGameRhythmExcel.AddFeverCriticalRate(builder, FeverCriticalRate);
    MiniGameRhythmExcel.AddStageDifficulty(builder, StageDifficulty);
    MiniGameRhythmExcel.AddPresetName(builder, PresetNameOffset);
    MiniGameRhythmExcel.AddIsSpecial(builder, IsSpecial);
    return MiniGameRhythmExcel.EndMiniGameRhythmExcel(builder);
  }

  public static void StartMiniGameRhythmExcel(FlatBufferBuilder builder) { builder.StartTable(20); }
  public static void AddUniqueId(FlatBufferBuilder builder, long uniqueId) { builder.AddLong(0, uniqueId, 0); }
  public static void AddRhythmBgmId(FlatBufferBuilder builder, long rhythmBgmId) { builder.AddLong(1, rhythmBgmId, 0); }
  public static void AddPresetName(FlatBufferBuilder builder, StringOffset presetNameOffset) { builder.AddOffset(2, presetNameOffset.Value, 0); }
  public static void AddStageDifficulty(FlatBufferBuilder builder, FlatData.Difficulty stageDifficulty) { builder.AddInt(3, (int)stageDifficulty, 0); }
  public static void AddIsSpecial(FlatBufferBuilder builder, bool isSpecial) { builder.AddBool(4, isSpecial, false); }
  public static void AddOpenStageScoreAmount(FlatBufferBuilder builder, long openStageScoreAmount) { builder.AddLong(5, openStageScoreAmount, 0); }
  public static void AddMaxHp(FlatBufferBuilder builder, long maxHp) { builder.AddLong(6, maxHp, 0); }
  public static void AddMissDamage(FlatBufferBuilder builder, long missDamage) { builder.AddLong(7, missDamage, 0); }
  public static void AddCriticalHPRestoreValue(FlatBufferBuilder builder, long criticalHPRestoreValue) { builder.AddLong(8, criticalHPRestoreValue, 0); }
  public static void AddMaxScore(FlatBufferBuilder builder, long maxScore) { builder.AddLong(9, maxScore, 0); }
  public static void AddFeverScoreRate(FlatBufferBuilder builder, long feverScoreRate) { builder.AddLong(10, feverScoreRate, 0); }
  public static void AddNoteScoreRate(FlatBufferBuilder builder, long noteScoreRate) { builder.AddLong(11, noteScoreRate, 0); }
  public static void AddComboScoreRate(FlatBufferBuilder builder, long comboScoreRate) { builder.AddLong(12, comboScoreRate, 0); }
  public static void AddAttackScoreRate(FlatBufferBuilder builder, long attackScoreRate) { builder.AddLong(13, attackScoreRate, 0); }
  public static void AddFeverCriticalRate(FlatBufferBuilder builder, float feverCriticalRate) { builder.AddFloat(14, feverCriticalRate, 0.0f); }
  public static void AddFeverAttackRate(FlatBufferBuilder builder, float feverAttackRate) { builder.AddFloat(15, feverAttackRate, 0.0f); }
  public static void AddMaxHpScore(FlatBufferBuilder builder, long maxHpScore) { builder.AddLong(16, maxHpScore, 0); }
  public static void AddRhythmFileName(FlatBufferBuilder builder, StringOffset rhythmFileNameOffset) { builder.AddOffset(17, rhythmFileNameOffset.Value, 0); }
  public static void AddArtLevelSceneName(FlatBufferBuilder builder, StringOffset artLevelSceneNameOffset) { builder.AddOffset(18, artLevelSceneNameOffset.Value, 0); }
  public static void AddComboImagePath(FlatBufferBuilder builder, StringOffset comboImagePathOffset) { builder.AddOffset(19, comboImagePathOffset.Value, 0); }
  public static Offset<FlatData.MiniGameRhythmExcel> EndMiniGameRhythmExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.MiniGameRhythmExcel>(o);
  }
  public MiniGameRhythmExcelT UnPack() {
    var _o = new MiniGameRhythmExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MiniGameRhythmExcelT _o) {
    _o.UniqueId = this.UniqueId;
    _o.RhythmBgmId = this.RhythmBgmId;
    _o.PresetName = this.PresetName;
    _o.StageDifficulty = this.StageDifficulty;
    _o.IsSpecial = this.IsSpecial;
    _o.OpenStageScoreAmount = this.OpenStageScoreAmount;
    _o.MaxHp = this.MaxHp;
    _o.MissDamage = this.MissDamage;
    _o.CriticalHPRestoreValue = this.CriticalHPRestoreValue;
    _o.MaxScore = this.MaxScore;
    _o.FeverScoreRate = this.FeverScoreRate;
    _o.NoteScoreRate = this.NoteScoreRate;
    _o.ComboScoreRate = this.ComboScoreRate;
    _o.AttackScoreRate = this.AttackScoreRate;
    _o.FeverCriticalRate = this.FeverCriticalRate;
    _o.FeverAttackRate = this.FeverAttackRate;
    _o.MaxHpScore = this.MaxHpScore;
    _o.RhythmFileName = this.RhythmFileName;
    _o.ArtLevelSceneName = this.ArtLevelSceneName;
    _o.ComboImagePath = this.ComboImagePath;
  }
  public static Offset<FlatData.MiniGameRhythmExcel> Pack(FlatBufferBuilder builder, MiniGameRhythmExcelT _o) {
    if (_o == null) return default(Offset<FlatData.MiniGameRhythmExcel>);
    var _PresetName = _o.PresetName == null ? default(StringOffset) : builder.CreateString(_o.PresetName);
    var _RhythmFileName = _o.RhythmFileName == null ? default(StringOffset) : builder.CreateString(_o.RhythmFileName);
    var _ArtLevelSceneName = _o.ArtLevelSceneName == null ? default(StringOffset) : builder.CreateString(_o.ArtLevelSceneName);
    var _ComboImagePath = _o.ComboImagePath == null ? default(StringOffset) : builder.CreateString(_o.ComboImagePath);
    return CreateMiniGameRhythmExcel(
      builder,
      _o.UniqueId,
      _o.RhythmBgmId,
      _PresetName,
      _o.StageDifficulty,
      _o.IsSpecial,
      _o.OpenStageScoreAmount,
      _o.MaxHp,
      _o.MissDamage,
      _o.CriticalHPRestoreValue,
      _o.MaxScore,
      _o.FeverScoreRate,
      _o.NoteScoreRate,
      _o.ComboScoreRate,
      _o.AttackScoreRate,
      _o.FeverCriticalRate,
      _o.FeverAttackRate,
      _o.MaxHpScore,
      _RhythmFileName,
      _ArtLevelSceneName,
      _ComboImagePath);
  }
}

public class MiniGameRhythmExcelT
{
  [Newtonsoft.Json.JsonProperty("UniqueId")]
  public long UniqueId { get; set; }
  [Newtonsoft.Json.JsonProperty("RhythmBgmId")]
  public long RhythmBgmId { get; set; }
  [Newtonsoft.Json.JsonProperty("PresetName")]
  public string PresetName { get; set; }
  [Newtonsoft.Json.JsonProperty("StageDifficulty")]
  public FlatData.Difficulty StageDifficulty { get; set; }
  [Newtonsoft.Json.JsonProperty("IsSpecial")]
  public bool IsSpecial { get; set; }
  [Newtonsoft.Json.JsonProperty("OpenStageScoreAmount")]
  public long OpenStageScoreAmount { get; set; }
  [Newtonsoft.Json.JsonProperty("MaxHp")]
  public long MaxHp { get; set; }
  [Newtonsoft.Json.JsonProperty("MissDamage")]
  public long MissDamage { get; set; }
  [Newtonsoft.Json.JsonProperty("CriticalHPRestoreValue")]
  public long CriticalHPRestoreValue { get; set; }
  [Newtonsoft.Json.JsonProperty("MaxScore")]
  public long MaxScore { get; set; }
  [Newtonsoft.Json.JsonProperty("FeverScoreRate")]
  public long FeverScoreRate { get; set; }
  [Newtonsoft.Json.JsonProperty("NoteScoreRate")]
  public long NoteScoreRate { get; set; }
  [Newtonsoft.Json.JsonProperty("ComboScoreRate")]
  public long ComboScoreRate { get; set; }
  [Newtonsoft.Json.JsonProperty("AttackScoreRate")]
  public long AttackScoreRate { get; set; }
  [Newtonsoft.Json.JsonProperty("FeverCriticalRate")]
  public float FeverCriticalRate { get; set; }
  [Newtonsoft.Json.JsonProperty("FeverAttackRate")]
  public float FeverAttackRate { get; set; }
  [Newtonsoft.Json.JsonProperty("MaxHpScore")]
  public long MaxHpScore { get; set; }
  [Newtonsoft.Json.JsonProperty("RhythmFileName")]
  public string RhythmFileName { get; set; }
  [Newtonsoft.Json.JsonProperty("ArtLevelSceneName")]
  public string ArtLevelSceneName { get; set; }
  [Newtonsoft.Json.JsonProperty("ComboImagePath")]
  public string ComboImagePath { get; set; }

  public MiniGameRhythmExcelT() {
    this.UniqueId = 0;
    this.RhythmBgmId = 0;
    this.PresetName = null;
    this.StageDifficulty = FlatData.Difficulty.Normal;
    this.IsSpecial = false;
    this.OpenStageScoreAmount = 0;
    this.MaxHp = 0;
    this.MissDamage = 0;
    this.CriticalHPRestoreValue = 0;
    this.MaxScore = 0;
    this.FeverScoreRate = 0;
    this.NoteScoreRate = 0;
    this.ComboScoreRate = 0;
    this.AttackScoreRate = 0;
    this.FeverCriticalRate = 0.0f;
    this.FeverAttackRate = 0.0f;
    this.MaxHpScore = 0;
    this.RhythmFileName = null;
    this.ArtLevelSceneName = null;
    this.ComboImagePath = null;
  }
}


static public class MiniGameRhythmExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*UniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*RhythmBgmId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 8 /*PresetName*/, false)
      && verifier.VerifyField(tablePos, 10 /*StageDifficulty*/, 4 /*FlatData.Difficulty*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*IsSpecial*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 14 /*OpenStageScoreAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*MaxHp*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*MissDamage*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*CriticalHPRestoreValue*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 22 /*MaxScore*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 24 /*FeverScoreRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 26 /*NoteScoreRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 28 /*ComboScoreRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 30 /*AttackScoreRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 32 /*FeverCriticalRate*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 34 /*FeverAttackRate*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 36 /*MaxHpScore*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 38 /*RhythmFileName*/, false)
      && verifier.VerifyString(tablePos, 40 /*ArtLevelSceneName*/, false)
      && verifier.VerifyString(tablePos, 42 /*ComboImagePath*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
