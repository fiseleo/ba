// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct AcademyLocationRankExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static AcademyLocationRankExcel GetRootAsAcademyLocationRankExcel(ByteBuffer _bb) { return GetRootAsAcademyLocationRankExcel(_bb, new AcademyLocationRankExcel()); }
  public static AcademyLocationRankExcel GetRootAsAcademyLocationRankExcel(ByteBuffer _bb, AcademyLocationRankExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AcademyLocationRankExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Rank { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RankExp { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long TotalExp { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatData.AcademyLocationRankExcel> CreateAcademyLocationRankExcel(FlatBufferBuilder builder,
      long Rank = 0,
      long RankExp = 0,
      long TotalExp = 0) {
    builder.StartTable(3);
    AcademyLocationRankExcel.AddTotalExp(builder, TotalExp);
    AcademyLocationRankExcel.AddRankExp(builder, RankExp);
    AcademyLocationRankExcel.AddRank(builder, Rank);
    return AcademyLocationRankExcel.EndAcademyLocationRankExcel(builder);
  }

  public static void StartAcademyLocationRankExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddRank(FlatBufferBuilder builder, long rank) { builder.AddLong(0, rank, 0); }
  public static void AddRankExp(FlatBufferBuilder builder, long rankExp) { builder.AddLong(1, rankExp, 0); }
  public static void AddTotalExp(FlatBufferBuilder builder, long totalExp) { builder.AddLong(2, totalExp, 0); }
  public static Offset<FlatData.AcademyLocationRankExcel> EndAcademyLocationRankExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.AcademyLocationRankExcel>(o);
  }
  public AcademyLocationRankExcelT UnPack() {
    var _o = new AcademyLocationRankExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AcademyLocationRankExcelT _o) {
    _o.Rank = this.Rank;
    _o.RankExp = this.RankExp;
    _o.TotalExp = this.TotalExp;
  }
  public static Offset<FlatData.AcademyLocationRankExcel> Pack(FlatBufferBuilder builder, AcademyLocationRankExcelT _o) {
    if (_o == null) return default(Offset<FlatData.AcademyLocationRankExcel>);
    return CreateAcademyLocationRankExcel(
      builder,
      _o.Rank,
      _o.RankExp,
      _o.TotalExp);
  }
}

public class AcademyLocationRankExcelT
{
  [Newtonsoft.Json.JsonProperty("Rank")]
  public long Rank { get; set; }
  [Newtonsoft.Json.JsonProperty("RankExp")]
  public long RankExp { get; set; }
  [Newtonsoft.Json.JsonProperty("TotalExp")]
  public long TotalExp { get; set; }

  public AcademyLocationRankExcelT() {
    this.Rank = 0;
    this.RankExp = 0;
    this.TotalExp = 0;
  }
}


static public class AcademyLocationRankExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Rank*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*RankExp*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*TotalExp*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
