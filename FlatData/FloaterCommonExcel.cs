// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FloaterCommonExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FloaterCommonExcel GetRootAsFloaterCommonExcel(ByteBuffer _bb) { return GetRootAsFloaterCommonExcel(_bb, new FloaterCommonExcel()); }
  public static FloaterCommonExcel GetRootAsFloaterCommonExcel(ByteBuffer _bb, FloaterCommonExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FloaterCommonExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.TacticEntityType TacticEntityType { get { int o = __p.__offset(6); return o != 0 ? (FlatData.TacticEntityType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.TacticEntityType.None; } }
  public int FloaterOffsetPosX { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int FloaterOffsetPosY { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int FloaterRandomPosRangeX { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int FloaterRandomPosRangeY { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatData.FloaterCommonExcel> CreateFloaterCommonExcel(FlatBufferBuilder builder,
      long Id = 0,
      FlatData.TacticEntityType TacticEntityType = FlatData.TacticEntityType.None,
      int FloaterOffsetPosX = 0,
      int FloaterOffsetPosY = 0,
      int FloaterRandomPosRangeX = 0,
      int FloaterRandomPosRangeY = 0) {
    builder.StartTable(6);
    FloaterCommonExcel.AddId(builder, Id);
    FloaterCommonExcel.AddFloaterRandomPosRangeY(builder, FloaterRandomPosRangeY);
    FloaterCommonExcel.AddFloaterRandomPosRangeX(builder, FloaterRandomPosRangeX);
    FloaterCommonExcel.AddFloaterOffsetPosY(builder, FloaterOffsetPosY);
    FloaterCommonExcel.AddFloaterOffsetPosX(builder, FloaterOffsetPosX);
    FloaterCommonExcel.AddTacticEntityType(builder, TacticEntityType);
    return FloaterCommonExcel.EndFloaterCommonExcel(builder);
  }

  public static void StartFloaterCommonExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddTacticEntityType(FlatBufferBuilder builder, FlatData.TacticEntityType tacticEntityType) { builder.AddInt(1, (int)tacticEntityType, 0); }
  public static void AddFloaterOffsetPosX(FlatBufferBuilder builder, int floaterOffsetPosX) { builder.AddInt(2, floaterOffsetPosX, 0); }
  public static void AddFloaterOffsetPosY(FlatBufferBuilder builder, int floaterOffsetPosY) { builder.AddInt(3, floaterOffsetPosY, 0); }
  public static void AddFloaterRandomPosRangeX(FlatBufferBuilder builder, int floaterRandomPosRangeX) { builder.AddInt(4, floaterRandomPosRangeX, 0); }
  public static void AddFloaterRandomPosRangeY(FlatBufferBuilder builder, int floaterRandomPosRangeY) { builder.AddInt(5, floaterRandomPosRangeY, 0); }
  public static Offset<FlatData.FloaterCommonExcel> EndFloaterCommonExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.FloaterCommonExcel>(o);
  }
  public FloaterCommonExcelT UnPack() {
    var _o = new FloaterCommonExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FloaterCommonExcelT _o) {
    _o.Id = this.Id;
    _o.TacticEntityType = this.TacticEntityType;
    _o.FloaterOffsetPosX = this.FloaterOffsetPosX;
    _o.FloaterOffsetPosY = this.FloaterOffsetPosY;
    _o.FloaterRandomPosRangeX = this.FloaterRandomPosRangeX;
    _o.FloaterRandomPosRangeY = this.FloaterRandomPosRangeY;
  }
  public static Offset<FlatData.FloaterCommonExcel> Pack(FlatBufferBuilder builder, FloaterCommonExcelT _o) {
    if (_o == null) return default(Offset<FlatData.FloaterCommonExcel>);
    return CreateFloaterCommonExcel(
      builder,
      _o.Id,
      _o.TacticEntityType,
      _o.FloaterOffsetPosX,
      _o.FloaterOffsetPosY,
      _o.FloaterRandomPosRangeX,
      _o.FloaterRandomPosRangeY);
  }
}

public class FloaterCommonExcelT
{
  [Newtonsoft.Json.JsonProperty("Id")]
  public long Id { get; set; }
  [Newtonsoft.Json.JsonProperty("TacticEntityType")]
  public FlatData.TacticEntityType TacticEntityType { get; set; }
  [Newtonsoft.Json.JsonProperty("FloaterOffsetPosX")]
  public int FloaterOffsetPosX { get; set; }
  [Newtonsoft.Json.JsonProperty("FloaterOffsetPosY")]
  public int FloaterOffsetPosY { get; set; }
  [Newtonsoft.Json.JsonProperty("FloaterRandomPosRangeX")]
  public int FloaterRandomPosRangeX { get; set; }
  [Newtonsoft.Json.JsonProperty("FloaterRandomPosRangeY")]
  public int FloaterRandomPosRangeY { get; set; }

  public FloaterCommonExcelT() {
    this.Id = 0;
    this.TacticEntityType = FlatData.TacticEntityType.None;
    this.FloaterOffsetPosX = 0;
    this.FloaterOffsetPosY = 0;
    this.FloaterRandomPosRangeX = 0;
    this.FloaterRandomPosRangeY = 0;
  }
}


static public class FloaterCommonExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*TacticEntityType*/, 4 /*FlatData.TacticEntityType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*FloaterOffsetPosX*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*FloaterOffsetPosY*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*FloaterRandomPosRangeX*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*FloaterRandomPosRangeY*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
