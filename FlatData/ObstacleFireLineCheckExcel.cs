// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ObstacleFireLineCheckExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ObstacleFireLineCheckExcel GetRootAsObstacleFireLineCheckExcel(ByteBuffer _bb) { return GetRootAsObstacleFireLineCheckExcel(_bb, new ObstacleFireLineCheckExcel()); }
  public static ObstacleFireLineCheckExcel GetRootAsObstacleFireLineCheckExcel(ByteBuffer _bb, ObstacleFireLineCheckExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ObstacleFireLineCheckExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public bool MyObstacleFireLineCheck { get { int o = __p.__offset(4); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool AllyObstacleFireLineCheck { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool EnemyObstacleFireLineCheck { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool EmptyObstacleFireLineCheck { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatData.ObstacleFireLineCheckExcel> CreateObstacleFireLineCheckExcel(FlatBufferBuilder builder,
      bool MyObstacleFireLineCheck = false,
      bool AllyObstacleFireLineCheck = false,
      bool EnemyObstacleFireLineCheck = false,
      bool EmptyObstacleFireLineCheck = false) {
    builder.StartTable(4);
    ObstacleFireLineCheckExcel.AddEmptyObstacleFireLineCheck(builder, EmptyObstacleFireLineCheck);
    ObstacleFireLineCheckExcel.AddEnemyObstacleFireLineCheck(builder, EnemyObstacleFireLineCheck);
    ObstacleFireLineCheckExcel.AddAllyObstacleFireLineCheck(builder, AllyObstacleFireLineCheck);
    ObstacleFireLineCheckExcel.AddMyObstacleFireLineCheck(builder, MyObstacleFireLineCheck);
    return ObstacleFireLineCheckExcel.EndObstacleFireLineCheckExcel(builder);
  }

  public static void StartObstacleFireLineCheckExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddMyObstacleFireLineCheck(FlatBufferBuilder builder, bool myObstacleFireLineCheck) { builder.AddBool(0, myObstacleFireLineCheck, false); }
  public static void AddAllyObstacleFireLineCheck(FlatBufferBuilder builder, bool allyObstacleFireLineCheck) { builder.AddBool(1, allyObstacleFireLineCheck, false); }
  public static void AddEnemyObstacleFireLineCheck(FlatBufferBuilder builder, bool enemyObstacleFireLineCheck) { builder.AddBool(2, enemyObstacleFireLineCheck, false); }
  public static void AddEmptyObstacleFireLineCheck(FlatBufferBuilder builder, bool emptyObstacleFireLineCheck) { builder.AddBool(3, emptyObstacleFireLineCheck, false); }
  public static Offset<FlatData.ObstacleFireLineCheckExcel> EndObstacleFireLineCheckExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.ObstacleFireLineCheckExcel>(o);
  }
  public ObstacleFireLineCheckExcelT UnPack() {
    var _o = new ObstacleFireLineCheckExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ObstacleFireLineCheckExcelT _o) {
    _o.MyObstacleFireLineCheck = this.MyObstacleFireLineCheck;
    _o.AllyObstacleFireLineCheck = this.AllyObstacleFireLineCheck;
    _o.EnemyObstacleFireLineCheck = this.EnemyObstacleFireLineCheck;
    _o.EmptyObstacleFireLineCheck = this.EmptyObstacleFireLineCheck;
  }
  public static Offset<FlatData.ObstacleFireLineCheckExcel> Pack(FlatBufferBuilder builder, ObstacleFireLineCheckExcelT _o) {
    if (_o == null) return default(Offset<FlatData.ObstacleFireLineCheckExcel>);
    return CreateObstacleFireLineCheckExcel(
      builder,
      _o.MyObstacleFireLineCheck,
      _o.AllyObstacleFireLineCheck,
      _o.EnemyObstacleFireLineCheck,
      _o.EmptyObstacleFireLineCheck);
  }
}

public class ObstacleFireLineCheckExcelT
{
  [Newtonsoft.Json.JsonProperty("MyObstacleFireLineCheck")]
  public bool MyObstacleFireLineCheck { get; set; }
  [Newtonsoft.Json.JsonProperty("AllyObstacleFireLineCheck")]
  public bool AllyObstacleFireLineCheck { get; set; }
  [Newtonsoft.Json.JsonProperty("EnemyObstacleFireLineCheck")]
  public bool EnemyObstacleFireLineCheck { get; set; }
  [Newtonsoft.Json.JsonProperty("EmptyObstacleFireLineCheck")]
  public bool EmptyObstacleFireLineCheck { get; set; }

  public ObstacleFireLineCheckExcelT() {
    this.MyObstacleFireLineCheck = false;
    this.AllyObstacleFireLineCheck = false;
    this.EnemyObstacleFireLineCheck = false;
    this.EmptyObstacleFireLineCheck = false;
  }
}


static public class ObstacleFireLineCheckExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*MyObstacleFireLineCheck*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 6 /*AllyObstacleFireLineCheck*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 8 /*EnemyObstacleFireLineCheck*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 10 /*EmptyObstacleFireLineCheck*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
