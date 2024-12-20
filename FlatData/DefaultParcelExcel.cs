// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct DefaultParcelExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static DefaultParcelExcel GetRootAsDefaultParcelExcel(ByteBuffer _bb) { return GetRootAsDefaultParcelExcel(_bb, new DefaultParcelExcel()); }
  public static DefaultParcelExcel GetRootAsDefaultParcelExcel(ByteBuffer _bb, DefaultParcelExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DefaultParcelExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatData.ParcelType ParcelType { get { int o = __p.__offset(4); return o != 0 ? (FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.ParcelType.None; } }
  public long ParcelId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ParcelAmount { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatData.DefaultParcelExcel> CreateDefaultParcelExcel(FlatBufferBuilder builder,
      FlatData.ParcelType ParcelType = FlatData.ParcelType.None,
      long ParcelId = 0,
      long ParcelAmount = 0) {
    builder.StartTable(3);
    DefaultParcelExcel.AddParcelAmount(builder, ParcelAmount);
    DefaultParcelExcel.AddParcelId(builder, ParcelId);
    DefaultParcelExcel.AddParcelType(builder, ParcelType);
    return DefaultParcelExcel.EndDefaultParcelExcel(builder);
  }

  public static void StartDefaultParcelExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddParcelType(FlatBufferBuilder builder, FlatData.ParcelType parcelType) { builder.AddInt(0, (int)parcelType, 0); }
  public static void AddParcelId(FlatBufferBuilder builder, long parcelId) { builder.AddLong(1, parcelId, 0); }
  public static void AddParcelAmount(FlatBufferBuilder builder, long parcelAmount) { builder.AddLong(2, parcelAmount, 0); }
  public static Offset<FlatData.DefaultParcelExcel> EndDefaultParcelExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.DefaultParcelExcel>(o);
  }
  public DefaultParcelExcelT UnPack() {
    var _o = new DefaultParcelExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(DefaultParcelExcelT _o) {
    _o.ParcelType = this.ParcelType;
    _o.ParcelId = this.ParcelId;
    _o.ParcelAmount = this.ParcelAmount;
  }
  public static Offset<FlatData.DefaultParcelExcel> Pack(FlatBufferBuilder builder, DefaultParcelExcelT _o) {
    if (_o == null) return default(Offset<FlatData.DefaultParcelExcel>);
    return CreateDefaultParcelExcel(
      builder,
      _o.ParcelType,
      _o.ParcelId,
      _o.ParcelAmount);
  }
}

public class DefaultParcelExcelT
{
  [Newtonsoft.Json.JsonProperty("ParcelType")]
  public FlatData.ParcelType ParcelType { get; set; }
  [Newtonsoft.Json.JsonProperty("ParcelId")]
  public long ParcelId { get; set; }
  [Newtonsoft.Json.JsonProperty("ParcelAmount")]
  public long ParcelAmount { get; set; }

  public DefaultParcelExcelT() {
    this.ParcelType = FlatData.ParcelType.None;
    this.ParcelId = 0;
    this.ParcelAmount = 0;
  }
}


static public class DefaultParcelExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*ParcelType*/, 4 /*FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*ParcelId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*ParcelAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
