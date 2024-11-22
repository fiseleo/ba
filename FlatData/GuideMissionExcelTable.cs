// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct GuideMissionExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static GuideMissionExcelTable GetRootAsGuideMissionExcelTable(ByteBuffer _bb) { return GetRootAsGuideMissionExcelTable(_bb, new GuideMissionExcelTable()); }
  public static GuideMissionExcelTable GetRootAsGuideMissionExcelTable(ByteBuffer _bb, GuideMissionExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public GuideMissionExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatData.GuideMissionExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (FlatData.GuideMissionExcel?)(new FlatData.GuideMissionExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatData.GuideMissionExcelTable> CreateGuideMissionExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    GuideMissionExcelTable.AddDataList(builder, DataListOffset);
    return GuideMissionExcelTable.EndGuideMissionExcelTable(builder);
  }

  public static void StartGuideMissionExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<FlatData.GuideMissionExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<FlatData.GuideMissionExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FlatData.GuideMissionExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FlatData.GuideMissionExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatData.GuideMissionExcelTable> EndGuideMissionExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.GuideMissionExcelTable>(o);
  }
  public GuideMissionExcelTableT UnPack() {
    var _o = new GuideMissionExcelTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(GuideMissionExcelTableT _o) {
    _o.DataList = new List<FlatData.GuideMissionExcelT>();
    for (var _j = 0; _j < this.DataListLength; ++_j) {_o.DataList.Add(this.DataList(_j).HasValue ? this.DataList(_j).Value.UnPack() : null);}
  }
  public static Offset<FlatData.GuideMissionExcelTable> Pack(FlatBufferBuilder builder, GuideMissionExcelTableT _o) {
    if (_o == null) return default(Offset<FlatData.GuideMissionExcelTable>);
    var _DataList = default(VectorOffset);
    if (_o.DataList != null) {
      var __DataList = new Offset<FlatData.GuideMissionExcel>[_o.DataList.Count];
      for (var _j = 0; _j < __DataList.Length; ++_j) { __DataList[_j] = FlatData.GuideMissionExcel.Pack(builder, _o.DataList[_j]); }
      _DataList = CreateDataListVector(builder, __DataList);
    }
    return CreateGuideMissionExcelTable(
      builder,
      _DataList);
  }
}

public class GuideMissionExcelTableT
{
  [Newtonsoft.Json.JsonProperty("DataList")]
  public List<FlatData.GuideMissionExcelT> DataList { get; set; }

  public GuideMissionExcelTableT() {
    this.DataList = null;
  }
}


static public class GuideMissionExcelTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, FlatData.GuideMissionExcelVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
