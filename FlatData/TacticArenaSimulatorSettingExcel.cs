// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TacticArenaSimulatorSettingExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static TacticArenaSimulatorSettingExcel GetRootAsTacticArenaSimulatorSettingExcel(ByteBuffer _bb) { return GetRootAsTacticArenaSimulatorSettingExcel(_bb, new TacticArenaSimulatorSettingExcel()); }
  public static TacticArenaSimulatorSettingExcel GetRootAsTacticArenaSimulatorSettingExcel(ByteBuffer _bb, TacticArenaSimulatorSettingExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TacticArenaSimulatorSettingExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Order { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Repeat { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.ArenaSimulatorServer AttackerFrom { get { int o = __p.__offset(8); return o != 0 ? (FlatData.ArenaSimulatorServer)__p.bb.GetInt(o + __p.bb_pos) : FlatData.ArenaSimulatorServer.Preset; } }
  public long AttackerUserArenaGroup { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AttackerUserArenaRank { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AttackerPresetGroupId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AttackerStrikerNum { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AttackerSpecialNum { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.ArenaSimulatorServer DefenderFrom { get { int o = __p.__offset(20); return o != 0 ? (FlatData.ArenaSimulatorServer)__p.bb.GetInt(o + __p.bb_pos) : FlatData.ArenaSimulatorServer.Preset; } }
  public long DefenderUserArenaGroup { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefenderUserArenaRank { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefenderPresetGroupId { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefenderStrikerNum { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefenderSpecialNum { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GroundId { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatData.TacticArenaSimulatorSettingExcel> CreateTacticArenaSimulatorSettingExcel(FlatBufferBuilder builder,
      long Order = 0,
      long Repeat = 0,
      FlatData.ArenaSimulatorServer AttackerFrom = FlatData.ArenaSimulatorServer.Preset,
      long AttackerUserArenaGroup = 0,
      long AttackerUserArenaRank = 0,
      long AttackerPresetGroupId = 0,
      long AttackerStrikerNum = 0,
      long AttackerSpecialNum = 0,
      FlatData.ArenaSimulatorServer DefenderFrom = FlatData.ArenaSimulatorServer.Preset,
      long DefenderUserArenaGroup = 0,
      long DefenderUserArenaRank = 0,
      long DefenderPresetGroupId = 0,
      long DefenderStrikerNum = 0,
      long DefenderSpecialNum = 0,
      long GroundId = 0) {
    builder.StartTable(15);
    TacticArenaSimulatorSettingExcel.AddGroundId(builder, GroundId);
    TacticArenaSimulatorSettingExcel.AddDefenderSpecialNum(builder, DefenderSpecialNum);
    TacticArenaSimulatorSettingExcel.AddDefenderStrikerNum(builder, DefenderStrikerNum);
    TacticArenaSimulatorSettingExcel.AddDefenderPresetGroupId(builder, DefenderPresetGroupId);
    TacticArenaSimulatorSettingExcel.AddDefenderUserArenaRank(builder, DefenderUserArenaRank);
    TacticArenaSimulatorSettingExcel.AddDefenderUserArenaGroup(builder, DefenderUserArenaGroup);
    TacticArenaSimulatorSettingExcel.AddAttackerSpecialNum(builder, AttackerSpecialNum);
    TacticArenaSimulatorSettingExcel.AddAttackerStrikerNum(builder, AttackerStrikerNum);
    TacticArenaSimulatorSettingExcel.AddAttackerPresetGroupId(builder, AttackerPresetGroupId);
    TacticArenaSimulatorSettingExcel.AddAttackerUserArenaRank(builder, AttackerUserArenaRank);
    TacticArenaSimulatorSettingExcel.AddAttackerUserArenaGroup(builder, AttackerUserArenaGroup);
    TacticArenaSimulatorSettingExcel.AddRepeat(builder, Repeat);
    TacticArenaSimulatorSettingExcel.AddOrder(builder, Order);
    TacticArenaSimulatorSettingExcel.AddDefenderFrom(builder, DefenderFrom);
    TacticArenaSimulatorSettingExcel.AddAttackerFrom(builder, AttackerFrom);
    return TacticArenaSimulatorSettingExcel.EndTacticArenaSimulatorSettingExcel(builder);
  }

  public static void StartTacticArenaSimulatorSettingExcel(FlatBufferBuilder builder) { builder.StartTable(15); }
  public static void AddOrder(FlatBufferBuilder builder, long order) { builder.AddLong(0, order, 0); }
  public static void AddRepeat(FlatBufferBuilder builder, long repeat) { builder.AddLong(1, repeat, 0); }
  public static void AddAttackerFrom(FlatBufferBuilder builder, FlatData.ArenaSimulatorServer attackerFrom) { builder.AddInt(2, (int)attackerFrom, 0); }
  public static void AddAttackerUserArenaGroup(FlatBufferBuilder builder, long attackerUserArenaGroup) { builder.AddLong(3, attackerUserArenaGroup, 0); }
  public static void AddAttackerUserArenaRank(FlatBufferBuilder builder, long attackerUserArenaRank) { builder.AddLong(4, attackerUserArenaRank, 0); }
  public static void AddAttackerPresetGroupId(FlatBufferBuilder builder, long attackerPresetGroupId) { builder.AddLong(5, attackerPresetGroupId, 0); }
  public static void AddAttackerStrikerNum(FlatBufferBuilder builder, long attackerStrikerNum) { builder.AddLong(6, attackerStrikerNum, 0); }
  public static void AddAttackerSpecialNum(FlatBufferBuilder builder, long attackerSpecialNum) { builder.AddLong(7, attackerSpecialNum, 0); }
  public static void AddDefenderFrom(FlatBufferBuilder builder, FlatData.ArenaSimulatorServer defenderFrom) { builder.AddInt(8, (int)defenderFrom, 0); }
  public static void AddDefenderUserArenaGroup(FlatBufferBuilder builder, long defenderUserArenaGroup) { builder.AddLong(9, defenderUserArenaGroup, 0); }
  public static void AddDefenderUserArenaRank(FlatBufferBuilder builder, long defenderUserArenaRank) { builder.AddLong(10, defenderUserArenaRank, 0); }
  public static void AddDefenderPresetGroupId(FlatBufferBuilder builder, long defenderPresetGroupId) { builder.AddLong(11, defenderPresetGroupId, 0); }
  public static void AddDefenderStrikerNum(FlatBufferBuilder builder, long defenderStrikerNum) { builder.AddLong(12, defenderStrikerNum, 0); }
  public static void AddDefenderSpecialNum(FlatBufferBuilder builder, long defenderSpecialNum) { builder.AddLong(13, defenderSpecialNum, 0); }
  public static void AddGroundId(FlatBufferBuilder builder, long groundId) { builder.AddLong(14, groundId, 0); }
  public static Offset<FlatData.TacticArenaSimulatorSettingExcel> EndTacticArenaSimulatorSettingExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.TacticArenaSimulatorSettingExcel>(o);
  }
  public TacticArenaSimulatorSettingExcelT UnPack() {
    var _o = new TacticArenaSimulatorSettingExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TacticArenaSimulatorSettingExcelT _o) {
    _o.Order = this.Order;
    _o.Repeat = this.Repeat;
    _o.AttackerFrom = this.AttackerFrom;
    _o.AttackerUserArenaGroup = this.AttackerUserArenaGroup;
    _o.AttackerUserArenaRank = this.AttackerUserArenaRank;
    _o.AttackerPresetGroupId = this.AttackerPresetGroupId;
    _o.AttackerStrikerNum = this.AttackerStrikerNum;
    _o.AttackerSpecialNum = this.AttackerSpecialNum;
    _o.DefenderFrom = this.DefenderFrom;
    _o.DefenderUserArenaGroup = this.DefenderUserArenaGroup;
    _o.DefenderUserArenaRank = this.DefenderUserArenaRank;
    _o.DefenderPresetGroupId = this.DefenderPresetGroupId;
    _o.DefenderStrikerNum = this.DefenderStrikerNum;
    _o.DefenderSpecialNum = this.DefenderSpecialNum;
    _o.GroundId = this.GroundId;
  }
  public static Offset<FlatData.TacticArenaSimulatorSettingExcel> Pack(FlatBufferBuilder builder, TacticArenaSimulatorSettingExcelT _o) {
    if (_o == null) return default(Offset<FlatData.TacticArenaSimulatorSettingExcel>);
    return CreateTacticArenaSimulatorSettingExcel(
      builder,
      _o.Order,
      _o.Repeat,
      _o.AttackerFrom,
      _o.AttackerUserArenaGroup,
      _o.AttackerUserArenaRank,
      _o.AttackerPresetGroupId,
      _o.AttackerStrikerNum,
      _o.AttackerSpecialNum,
      _o.DefenderFrom,
      _o.DefenderUserArenaGroup,
      _o.DefenderUserArenaRank,
      _o.DefenderPresetGroupId,
      _o.DefenderStrikerNum,
      _o.DefenderSpecialNum,
      _o.GroundId);
  }
}

public class TacticArenaSimulatorSettingExcelT
{
  [Newtonsoft.Json.JsonProperty("Order")]
  public long Order { get; set; }
  [Newtonsoft.Json.JsonProperty("Repeat")]
  public long Repeat { get; set; }
  [Newtonsoft.Json.JsonProperty("AttackerFrom")]
  public FlatData.ArenaSimulatorServer AttackerFrom { get; set; }
  [Newtonsoft.Json.JsonProperty("AttackerUserArenaGroup")]
  public long AttackerUserArenaGroup { get; set; }
  [Newtonsoft.Json.JsonProperty("AttackerUserArenaRank")]
  public long AttackerUserArenaRank { get; set; }
  [Newtonsoft.Json.JsonProperty("AttackerPresetGroupId")]
  public long AttackerPresetGroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("AttackerStrikerNum")]
  public long AttackerStrikerNum { get; set; }
  [Newtonsoft.Json.JsonProperty("AttackerSpecialNum")]
  public long AttackerSpecialNum { get; set; }
  [Newtonsoft.Json.JsonProperty("DefenderFrom")]
  public FlatData.ArenaSimulatorServer DefenderFrom { get; set; }
  [Newtonsoft.Json.JsonProperty("DefenderUserArenaGroup")]
  public long DefenderUserArenaGroup { get; set; }
  [Newtonsoft.Json.JsonProperty("DefenderUserArenaRank")]
  public long DefenderUserArenaRank { get; set; }
  [Newtonsoft.Json.JsonProperty("DefenderPresetGroupId")]
  public long DefenderPresetGroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("DefenderStrikerNum")]
  public long DefenderStrikerNum { get; set; }
  [Newtonsoft.Json.JsonProperty("DefenderSpecialNum")]
  public long DefenderSpecialNum { get; set; }
  [Newtonsoft.Json.JsonProperty("GroundId")]
  public long GroundId { get; set; }

  public TacticArenaSimulatorSettingExcelT() {
    this.Order = 0;
    this.Repeat = 0;
    this.AttackerFrom = FlatData.ArenaSimulatorServer.Preset;
    this.AttackerUserArenaGroup = 0;
    this.AttackerUserArenaRank = 0;
    this.AttackerPresetGroupId = 0;
    this.AttackerStrikerNum = 0;
    this.AttackerSpecialNum = 0;
    this.DefenderFrom = FlatData.ArenaSimulatorServer.Preset;
    this.DefenderUserArenaGroup = 0;
    this.DefenderUserArenaRank = 0;
    this.DefenderPresetGroupId = 0;
    this.DefenderStrikerNum = 0;
    this.DefenderSpecialNum = 0;
    this.GroundId = 0;
  }
}


static public class TacticArenaSimulatorSettingExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Order*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Repeat*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*AttackerFrom*/, 4 /*FlatData.ArenaSimulatorServer*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*AttackerUserArenaGroup*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*AttackerUserArenaRank*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*AttackerPresetGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*AttackerStrikerNum*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*AttackerSpecialNum*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*DefenderFrom*/, 4 /*FlatData.ArenaSimulatorServer*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*DefenderUserArenaGroup*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 24 /*DefenderUserArenaRank*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 26 /*DefenderPresetGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 28 /*DefenderStrikerNum*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 30 /*DefenderSpecialNum*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 32 /*GroundId*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
