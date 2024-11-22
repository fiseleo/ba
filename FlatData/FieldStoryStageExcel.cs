// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FieldStoryStageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FieldStoryStageExcel GetRootAsFieldStoryStageExcel(ByteBuffer _bb) { return GetRootAsFieldStoryStageExcel(_bb, new FieldStoryStageExcel()); }
  public static FieldStoryStageExcel GetRootAsFieldStoryStageExcel(ByteBuffer _bb, FieldStoryStageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FieldStoryStageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long SeasonId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string Name { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(8); }
  public long BattleDuration { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.StageTopography StageTopography { get { int o = __p.__offset(12); return o != 0 ? (FlatData.StageTopography)__p.bb.GetInt(o + __p.bb_pos) : FlatData.StageTopography.Street; } }
  public int RecommandLevel { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long GroundID { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BGMId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FixedEchelonId { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool SkipFormationSettings { get { int o = __p.__offset(22); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatData.FieldStoryStageExcel> CreateFieldStoryStageExcel(FlatBufferBuilder builder,
      long Id = 0,
      long SeasonId = 0,
      StringOffset NameOffset = default(StringOffset),
      long BattleDuration = 0,
      FlatData.StageTopography StageTopography = FlatData.StageTopography.Street,
      int RecommandLevel = 0,
      long GroundID = 0,
      long BGMId = 0,
      long FixedEchelonId = 0,
      bool SkipFormationSettings = false) {
    builder.StartTable(10);
    FieldStoryStageExcel.AddFixedEchelonId(builder, FixedEchelonId);
    FieldStoryStageExcel.AddBGMId(builder, BGMId);
    FieldStoryStageExcel.AddGroundID(builder, GroundID);
    FieldStoryStageExcel.AddBattleDuration(builder, BattleDuration);
    FieldStoryStageExcel.AddSeasonId(builder, SeasonId);
    FieldStoryStageExcel.AddId(builder, Id);
    FieldStoryStageExcel.AddRecommandLevel(builder, RecommandLevel);
    FieldStoryStageExcel.AddStageTopography(builder, StageTopography);
    FieldStoryStageExcel.AddName(builder, NameOffset);
    FieldStoryStageExcel.AddSkipFormationSettings(builder, SkipFormationSettings);
    return FieldStoryStageExcel.EndFieldStoryStageExcel(builder);
  }

  public static void StartFieldStoryStageExcel(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddSeasonId(FlatBufferBuilder builder, long seasonId) { builder.AddLong(1, seasonId, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(2, nameOffset.Value, 0); }
  public static void AddBattleDuration(FlatBufferBuilder builder, long battleDuration) { builder.AddLong(3, battleDuration, 0); }
  public static void AddStageTopography(FlatBufferBuilder builder, FlatData.StageTopography stageTopography) { builder.AddInt(4, (int)stageTopography, 0); }
  public static void AddRecommandLevel(FlatBufferBuilder builder, int recommandLevel) { builder.AddInt(5, recommandLevel, 0); }
  public static void AddGroundID(FlatBufferBuilder builder, long groundID) { builder.AddLong(6, groundID, 0); }
  public static void AddBGMId(FlatBufferBuilder builder, long bGMId) { builder.AddLong(7, bGMId, 0); }
  public static void AddFixedEchelonId(FlatBufferBuilder builder, long fixedEchelonId) { builder.AddLong(8, fixedEchelonId, 0); }
  public static void AddSkipFormationSettings(FlatBufferBuilder builder, bool skipFormationSettings) { builder.AddBool(9, skipFormationSettings, false); }
  public static Offset<FlatData.FieldStoryStageExcel> EndFieldStoryStageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.FieldStoryStageExcel>(o);
  }
  public FieldStoryStageExcelT UnPack() {
    var _o = new FieldStoryStageExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FieldStoryStageExcelT _o) {
    _o.Id = this.Id;
    _o.SeasonId = this.SeasonId;
    _o.Name = this.Name;
    _o.BattleDuration = this.BattleDuration;
    _o.StageTopography = this.StageTopography;
    _o.RecommandLevel = this.RecommandLevel;
    _o.GroundID = this.GroundID;
    _o.BGMId = this.BGMId;
    _o.FixedEchelonId = this.FixedEchelonId;
    _o.SkipFormationSettings = this.SkipFormationSettings;
  }
  public static Offset<FlatData.FieldStoryStageExcel> Pack(FlatBufferBuilder builder, FieldStoryStageExcelT _o) {
    if (_o == null) return default(Offset<FlatData.FieldStoryStageExcel>);
    var _Name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    return CreateFieldStoryStageExcel(
      builder,
      _o.Id,
      _o.SeasonId,
      _Name,
      _o.BattleDuration,
      _o.StageTopography,
      _o.RecommandLevel,
      _o.GroundID,
      _o.BGMId,
      _o.FixedEchelonId,
      _o.SkipFormationSettings);
  }
}

public class FieldStoryStageExcelT
{
  [Newtonsoft.Json.JsonProperty("Id")]
  public long Id { get; set; }
  [Newtonsoft.Json.JsonProperty("SeasonId")]
  public long SeasonId { get; set; }
  [Newtonsoft.Json.JsonProperty("Name")]
  public string Name { get; set; }
  [Newtonsoft.Json.JsonProperty("BattleDuration")]
  public long BattleDuration { get; set; }
  [Newtonsoft.Json.JsonProperty("StageTopography")]
  public FlatData.StageTopography StageTopography { get; set; }
  [Newtonsoft.Json.JsonProperty("RecommandLevel")]
  public int RecommandLevel { get; set; }
  [Newtonsoft.Json.JsonProperty("GroundID")]
  public long GroundID { get; set; }
  [Newtonsoft.Json.JsonProperty("BGMId")]
  public long BGMId { get; set; }
  [Newtonsoft.Json.JsonProperty("FixedEchelonId")]
  public long FixedEchelonId { get; set; }
  [Newtonsoft.Json.JsonProperty("SkipFormationSettings")]
  public bool SkipFormationSettings { get; set; }

  public FieldStoryStageExcelT() {
    this.Id = 0;
    this.SeasonId = 0;
    this.Name = null;
    this.BattleDuration = 0;
    this.StageTopography = FlatData.StageTopography.Street;
    this.RecommandLevel = 0;
    this.GroundID = 0;
    this.BGMId = 0;
    this.FixedEchelonId = 0;
    this.SkipFormationSettings = false;
  }
}


static public class FieldStoryStageExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*SeasonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 8 /*Name*/, false)
      && verifier.VerifyField(tablePos, 10 /*BattleDuration*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*StageTopography*/, 4 /*FlatData.StageTopography*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*RecommandLevel*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*GroundID*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*BGMId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*FixedEchelonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 22 /*SkipFormationSettings*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}