// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterStatLimitExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CharacterStatLimitExcel GetRootAsCharacterStatLimitExcel(ByteBuffer _bb) { return GetRootAsCharacterStatLimitExcel(_bb, new CharacterStatLimitExcel()); }
  public static CharacterStatLimitExcel GetRootAsCharacterStatLimitExcel(ByteBuffer _bb, CharacterStatLimitExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterStatLimitExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.TacticEntityType TacticEntityType { get { int o = __p.__offset(6); return o != 0 ? (FlatData.TacticEntityType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.TacticEntityType.None; } }
  public FlatData.StatType StatType { get { int o = __p.__offset(8); return o != 0 ? (FlatData.StatType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.StatType.None; } }
  public long StatMinValue { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StatMaxValue { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StatRatioMinValue { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long StatRatioMaxValue { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatData.CharacterStatLimitExcel> CreateCharacterStatLimitExcel(FlatBufferBuilder builder,
      long Id = 0,
      FlatData.TacticEntityType TacticEntityType = FlatData.TacticEntityType.None,
      FlatData.StatType StatType = FlatData.StatType.None,
      long StatMinValue = 0,
      long StatMaxValue = 0,
      long StatRatioMinValue = 0,
      long StatRatioMaxValue = 0) {
    builder.StartTable(7);
    CharacterStatLimitExcel.AddStatRatioMaxValue(builder, StatRatioMaxValue);
    CharacterStatLimitExcel.AddStatRatioMinValue(builder, StatRatioMinValue);
    CharacterStatLimitExcel.AddStatMaxValue(builder, StatMaxValue);
    CharacterStatLimitExcel.AddStatMinValue(builder, StatMinValue);
    CharacterStatLimitExcel.AddId(builder, Id);
    CharacterStatLimitExcel.AddStatType(builder, StatType);
    CharacterStatLimitExcel.AddTacticEntityType(builder, TacticEntityType);
    return CharacterStatLimitExcel.EndCharacterStatLimitExcel(builder);
  }

  public static void StartCharacterStatLimitExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddTacticEntityType(FlatBufferBuilder builder, FlatData.TacticEntityType tacticEntityType) { builder.AddInt(1, (int)tacticEntityType, 0); }
  public static void AddStatType(FlatBufferBuilder builder, FlatData.StatType statType) { builder.AddInt(2, (int)statType, 0); }
  public static void AddStatMinValue(FlatBufferBuilder builder, long statMinValue) { builder.AddLong(3, statMinValue, 0); }
  public static void AddStatMaxValue(FlatBufferBuilder builder, long statMaxValue) { builder.AddLong(4, statMaxValue, 0); }
  public static void AddStatRatioMinValue(FlatBufferBuilder builder, long statRatioMinValue) { builder.AddLong(5, statRatioMinValue, 0); }
  public static void AddStatRatioMaxValue(FlatBufferBuilder builder, long statRatioMaxValue) { builder.AddLong(6, statRatioMaxValue, 0); }
  public static Offset<FlatData.CharacterStatLimitExcel> EndCharacterStatLimitExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.CharacterStatLimitExcel>(o);
  }
  public CharacterStatLimitExcelT UnPack() {
    var _o = new CharacterStatLimitExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CharacterStatLimitExcelT _o) {
    _o.Id = this.Id;
    _o.TacticEntityType = this.TacticEntityType;
    _o.StatType = this.StatType;
    _o.StatMinValue = this.StatMinValue;
    _o.StatMaxValue = this.StatMaxValue;
    _o.StatRatioMinValue = this.StatRatioMinValue;
    _o.StatRatioMaxValue = this.StatRatioMaxValue;
  }
  public static Offset<FlatData.CharacterStatLimitExcel> Pack(FlatBufferBuilder builder, CharacterStatLimitExcelT _o) {
    if (_o == null) return default(Offset<FlatData.CharacterStatLimitExcel>);
    return CreateCharacterStatLimitExcel(
      builder,
      _o.Id,
      _o.TacticEntityType,
      _o.StatType,
      _o.StatMinValue,
      _o.StatMaxValue,
      _o.StatRatioMinValue,
      _o.StatRatioMaxValue);
  }
}

public class CharacterStatLimitExcelT
{
  [Newtonsoft.Json.JsonProperty("Id")]
  public long Id { get; set; }
  [Newtonsoft.Json.JsonProperty("TacticEntityType")]
  public FlatData.TacticEntityType TacticEntityType { get; set; }
  [Newtonsoft.Json.JsonProperty("StatType")]
  public FlatData.StatType StatType { get; set; }
  [Newtonsoft.Json.JsonProperty("StatMinValue")]
  public long StatMinValue { get; set; }
  [Newtonsoft.Json.JsonProperty("StatMaxValue")]
  public long StatMaxValue { get; set; }
  [Newtonsoft.Json.JsonProperty("StatRatioMinValue")]
  public long StatRatioMinValue { get; set; }
  [Newtonsoft.Json.JsonProperty("StatRatioMaxValue")]
  public long StatRatioMaxValue { get; set; }

  public CharacterStatLimitExcelT() {
    this.Id = 0;
    this.TacticEntityType = FlatData.TacticEntityType.None;
    this.StatType = FlatData.StatType.None;
    this.StatMinValue = 0;
    this.StatMaxValue = 0;
    this.StatRatioMinValue = 0;
    this.StatRatioMaxValue = 0;
  }
}


static public class CharacterStatLimitExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*TacticEntityType*/, 4 /*FlatData.TacticEntityType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*StatType*/, 4 /*FlatData.StatType*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*StatMinValue*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*StatMaxValue*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*StatRatioMinValue*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*StatRatioMaxValue*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
