// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GachaElementRecursiveExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static GachaElementRecursiveExcel GetRootAsGachaElementRecursiveExcel(ByteBuffer _bb) { return GetRootAsGachaElementRecursiveExcel(_bb, new GachaElementRecursiveExcel()); }
  public static GachaElementRecursiveExcel GetRootAsGachaElementRecursiveExcel(ByteBuffer _bb, GachaElementRecursiveExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GachaElementRecursiveExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long ID { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GachaGroupID { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.ParcelType ParcelType { get { int o = __p.__offset(8); return o != 0 ? (FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.ParcelType.None; } }
  public long ParcelID { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int ParcelAmountMin { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ParcelAmountMax { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Prob { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int State { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<FlatData.GachaElementRecursiveExcel> CreateGachaElementRecursiveExcel(FlatBufferBuilder builder,
      long ID = 0,
      long GachaGroupID = 0,
      FlatData.ParcelType ParcelType = FlatData.ParcelType.None,
      long ParcelID = 0,
      int ParcelAmountMin = 0,
      int ParcelAmountMax = 0,
      int Prob = 0,
      int State = 0) {
    builder.StartTable(8);
    GachaElementRecursiveExcel.AddParcelID(builder, ParcelID);
    GachaElementRecursiveExcel.AddGachaGroupID(builder, GachaGroupID);
    GachaElementRecursiveExcel.AddID(builder, ID);
    GachaElementRecursiveExcel.AddState(builder, State);
    GachaElementRecursiveExcel.AddProb(builder, Prob);
    GachaElementRecursiveExcel.AddParcelAmountMax(builder, ParcelAmountMax);
    GachaElementRecursiveExcel.AddParcelAmountMin(builder, ParcelAmountMin);
    GachaElementRecursiveExcel.AddParcelType(builder, ParcelType);
    return GachaElementRecursiveExcel.EndGachaElementRecursiveExcel(builder);
  }

  public static void StartGachaElementRecursiveExcel(FlatBufferBuilder builder) { builder.StartTable(8); }
  public static void AddID(FlatBufferBuilder builder, long iD) { builder.AddLong(0, iD, 0); }
  public static void AddGachaGroupID(FlatBufferBuilder builder, long gachaGroupID) { builder.AddLong(1, gachaGroupID, 0); }
  public static void AddParcelType(FlatBufferBuilder builder, FlatData.ParcelType parcelType) { builder.AddInt(2, (int)parcelType, 0); }
  public static void AddParcelID(FlatBufferBuilder builder, long parcelID) { builder.AddLong(3, parcelID, 0); }
  public static void AddParcelAmountMin(FlatBufferBuilder builder, int parcelAmountMin) { builder.AddInt(4, parcelAmountMin, 0); }
  public static void AddParcelAmountMax(FlatBufferBuilder builder, int parcelAmountMax) { builder.AddInt(5, parcelAmountMax, 0); }
  public static void AddProb(FlatBufferBuilder builder, int prob) { builder.AddInt(6, prob, 0); }
  public static void AddState(FlatBufferBuilder builder, int state) { builder.AddInt(7, state, 0); }
  public static Offset<FlatData.GachaElementRecursiveExcel> EndGachaElementRecursiveExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.GachaElementRecursiveExcel>(o);
  }
  public GachaElementRecursiveExcelT UnPack() {
    var _o = new GachaElementRecursiveExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(GachaElementRecursiveExcelT _o) {
    _o.ID = this.ID;
    _o.GachaGroupID = this.GachaGroupID;
    _o.ParcelType = this.ParcelType;
    _o.ParcelID = this.ParcelID;
    _o.ParcelAmountMin = this.ParcelAmountMin;
    _o.ParcelAmountMax = this.ParcelAmountMax;
    _o.Prob = this.Prob;
    _o.State = this.State;
  }
  public static Offset<FlatData.GachaElementRecursiveExcel> Pack(FlatBufferBuilder builder, GachaElementRecursiveExcelT _o) {
    if (_o == null) return default(Offset<FlatData.GachaElementRecursiveExcel>);
    return CreateGachaElementRecursiveExcel(
      builder,
      _o.ID,
      _o.GachaGroupID,
      _o.ParcelType,
      _o.ParcelID,
      _o.ParcelAmountMin,
      _o.ParcelAmountMax,
      _o.Prob,
      _o.State);
  }
}

public class GachaElementRecursiveExcelT
{
  [Newtonsoft.Json.JsonProperty("ID")]
  public long ID { get; set; }
  [Newtonsoft.Json.JsonProperty("GachaGroupID")]
  public long GachaGroupID { get; set; }
  [Newtonsoft.Json.JsonProperty("ParcelType")]
  public FlatData.ParcelType ParcelType { get; set; }
  [Newtonsoft.Json.JsonProperty("ParcelID")]
  public long ParcelID { get; set; }
  [Newtonsoft.Json.JsonProperty("ParcelAmountMin")]
  public int ParcelAmountMin { get; set; }
  [Newtonsoft.Json.JsonProperty("ParcelAmountMax")]
  public int ParcelAmountMax { get; set; }
  [Newtonsoft.Json.JsonProperty("Prob")]
  public int Prob { get; set; }
  [Newtonsoft.Json.JsonProperty("State")]
  public int State { get; set; }

  public GachaElementRecursiveExcelT() {
    this.ID = 0;
    this.GachaGroupID = 0;
    this.ParcelType = FlatData.ParcelType.None;
    this.ParcelID = 0;
    this.ParcelAmountMin = 0;
    this.ParcelAmountMax = 0;
    this.Prob = 0;
    this.State = 0;
  }
}


static public class GachaElementRecursiveExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*ID*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*GachaGroupID*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*ParcelType*/, 4 /*FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*ParcelID*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*ParcelAmountMin*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*ParcelAmountMax*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*Prob*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*State*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
