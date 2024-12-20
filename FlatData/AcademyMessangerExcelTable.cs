// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct AcademyMessangerExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static AcademyMessangerExcelTable GetRootAsAcademyMessangerExcelTable(ByteBuffer _bb) { return GetRootAsAcademyMessangerExcelTable(_bb, new AcademyMessangerExcelTable()); }
  public static AcademyMessangerExcelTable GetRootAsAcademyMessangerExcelTable(ByteBuffer _bb, AcademyMessangerExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AcademyMessangerExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatData.AcademyMessangerExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (FlatData.AcademyMessangerExcel?)(new FlatData.AcademyMessangerExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatData.AcademyMessangerExcelTable> CreateAcademyMessangerExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    AcademyMessangerExcelTable.AddDataList(builder, DataListOffset);
    return AcademyMessangerExcelTable.EndAcademyMessangerExcelTable(builder);
  }

  public static void StartAcademyMessangerExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<FlatData.AcademyMessangerExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<FlatData.AcademyMessangerExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FlatData.AcademyMessangerExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FlatData.AcademyMessangerExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatData.AcademyMessangerExcelTable> EndAcademyMessangerExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.AcademyMessangerExcelTable>(o);
  }
  public AcademyMessangerExcelTableT UnPack() {
    var _o = new AcademyMessangerExcelTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AcademyMessangerExcelTableT _o) {
    _o.DataList = new List<FlatData.AcademyMessangerExcelT>();
    for (var _j = 0; _j < this.DataListLength; ++_j) {_o.DataList.Add(this.DataList(_j).HasValue ? this.DataList(_j).Value.UnPack() : null);}
  }
  public static Offset<FlatData.AcademyMessangerExcelTable> Pack(FlatBufferBuilder builder, AcademyMessangerExcelTableT _o) {
    if (_o == null) return default(Offset<FlatData.AcademyMessangerExcelTable>);
    var _DataList = default(VectorOffset);
    if (_o.DataList != null) {
      var __DataList = new Offset<FlatData.AcademyMessangerExcel>[_o.DataList.Count];
      for (var _j = 0; _j < __DataList.Length; ++_j) { __DataList[_j] = FlatData.AcademyMessangerExcel.Pack(builder, _o.DataList[_j]); }
      _DataList = CreateDataListVector(builder, __DataList);
    }
    return CreateAcademyMessangerExcelTable(
      builder,
      _DataList);
  }
}

public class AcademyMessangerExcelTableT
{
  [Newtonsoft.Json.JsonProperty("DataList")]
  public List<FlatData.AcademyMessangerExcelT> DataList { get; set; }

  public AcademyMessangerExcelTableT() {
    this.DataList = null;
  }
}


static public class AcademyMessangerExcelTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, FlatData.AcademyMessangerExcelVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
