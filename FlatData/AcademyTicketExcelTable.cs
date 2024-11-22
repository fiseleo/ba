// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct AcademyTicketExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static AcademyTicketExcelTable GetRootAsAcademyTicketExcelTable(ByteBuffer _bb) { return GetRootAsAcademyTicketExcelTable(_bb, new AcademyTicketExcelTable()); }
  public static AcademyTicketExcelTable GetRootAsAcademyTicketExcelTable(ByteBuffer _bb, AcademyTicketExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AcademyTicketExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatData.AcademyTicketExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (FlatData.AcademyTicketExcel?)(new FlatData.AcademyTicketExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatData.AcademyTicketExcelTable> CreateAcademyTicketExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    AcademyTicketExcelTable.AddDataList(builder, DataListOffset);
    return AcademyTicketExcelTable.EndAcademyTicketExcelTable(builder);
  }

  public static void StartAcademyTicketExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<FlatData.AcademyTicketExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<FlatData.AcademyTicketExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FlatData.AcademyTicketExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FlatData.AcademyTicketExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatData.AcademyTicketExcelTable> EndAcademyTicketExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.AcademyTicketExcelTable>(o);
  }
  public AcademyTicketExcelTableT UnPack() {
    var _o = new AcademyTicketExcelTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AcademyTicketExcelTableT _o) {
    _o.DataList = new List<FlatData.AcademyTicketExcelT>();
    for (var _j = 0; _j < this.DataListLength; ++_j) {_o.DataList.Add(this.DataList(_j).HasValue ? this.DataList(_j).Value.UnPack() : null);}
  }
  public static Offset<FlatData.AcademyTicketExcelTable> Pack(FlatBufferBuilder builder, AcademyTicketExcelTableT _o) {
    if (_o == null) return default(Offset<FlatData.AcademyTicketExcelTable>);
    var _DataList = default(VectorOffset);
    if (_o.DataList != null) {
      var __DataList = new Offset<FlatData.AcademyTicketExcel>[_o.DataList.Count];
      for (var _j = 0; _j < __DataList.Length; ++_j) { __DataList[_j] = FlatData.AcademyTicketExcel.Pack(builder, _o.DataList[_j]); }
      _DataList = CreateDataListVector(builder, __DataList);
    }
    return CreateAcademyTicketExcelTable(
      builder,
      _DataList);
  }
}

public class AcademyTicketExcelTableT
{
  [Newtonsoft.Json.JsonProperty("DataList")]
  public List<FlatData.AcademyTicketExcelT> DataList { get; set; }

  public AcademyTicketExcelTableT() {
    this.DataList = null;
  }
}


static public class AcademyTicketExcelTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, FlatData.AcademyTicketExcelVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
