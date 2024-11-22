// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct HpBarAbbreviationExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static HpBarAbbreviationExcel GetRootAsHpBarAbbreviationExcel(ByteBuffer _bb) { return GetRootAsHpBarAbbreviationExcel(_bb, new HpBarAbbreviationExcel()); }
  public static HpBarAbbreviationExcel GetRootAsHpBarAbbreviationExcel(ByteBuffer _bb, HpBarAbbreviationExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public HpBarAbbreviationExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int MonsterLv { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int StandardHpBar { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RaidBossHpBar { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatData.HpBarAbbreviationExcel> CreateHpBarAbbreviationExcel(FlatBufferBuilder builder,
      int MonsterLv = 0,
      int StandardHpBar = 0,
      int RaidBossHpBar = 0) {
    builder.StartTable(3);
    HpBarAbbreviationExcel.AddRaidBossHpBar(builder, RaidBossHpBar);
    HpBarAbbreviationExcel.AddStandardHpBar(builder, StandardHpBar);
    HpBarAbbreviationExcel.AddMonsterLv(builder, MonsterLv);
    return HpBarAbbreviationExcel.EndHpBarAbbreviationExcel(builder);
  }

  public static void StartHpBarAbbreviationExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddMonsterLv(FlatBufferBuilder builder, int monsterLv) { builder.AddInt(0, monsterLv, 0); }
  public static void AddStandardHpBar(FlatBufferBuilder builder, int standardHpBar) { builder.AddInt(1, standardHpBar, 0); }
  public static void AddRaidBossHpBar(FlatBufferBuilder builder, int raidBossHpBar) { builder.AddInt(2, raidBossHpBar, 0); }
  public static Offset<FlatData.HpBarAbbreviationExcel> EndHpBarAbbreviationExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.HpBarAbbreviationExcel>(o);
  }
  public HpBarAbbreviationExcelT UnPack() {
    var _o = new HpBarAbbreviationExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(HpBarAbbreviationExcelT _o) {
    _o.MonsterLv = this.MonsterLv;
    _o.StandardHpBar = this.StandardHpBar;
    _o.RaidBossHpBar = this.RaidBossHpBar;
  }
  public static Offset<FlatData.HpBarAbbreviationExcel> Pack(FlatBufferBuilder builder, HpBarAbbreviationExcelT _o) {
    if (_o == null) return default(Offset<FlatData.HpBarAbbreviationExcel>);
    return CreateHpBarAbbreviationExcel(
      builder,
      _o.MonsterLv,
      _o.StandardHpBar,
      _o.RaidBossHpBar);
  }
}

public class HpBarAbbreviationExcelT
{
  [Newtonsoft.Json.JsonProperty("MonsterLv")]
  public int MonsterLv { get; set; }
  [Newtonsoft.Json.JsonProperty("StandardHpBar")]
  public int StandardHpBar { get; set; }
  [Newtonsoft.Json.JsonProperty("RaidBossHpBar")]
  public int RaidBossHpBar { get; set; }

  public HpBarAbbreviationExcelT() {
    this.MonsterLv = 0;
    this.StandardHpBar = 0;
    this.RaidBossHpBar = 0;
  }
}


static public class HpBarAbbreviationExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*MonsterLv*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*StandardHpBar*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*RaidBossHpBar*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
