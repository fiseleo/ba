// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FixedEchelonSettingExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FixedEchelonSettingExcelTable GetRootAsFixedEchelonSettingExcelTable(ByteBuffer _bb) { return GetRootAsFixedEchelonSettingExcelTable(_bb, new FixedEchelonSettingExcelTable()); }
  public static FixedEchelonSettingExcelTable GetRootAsFixedEchelonSettingExcelTable(ByteBuffer _bb, FixedEchelonSettingExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FixedEchelonSettingExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatData.FixedEchelonSettingExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (FlatData.FixedEchelonSettingExcel?)(new FlatData.FixedEchelonSettingExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatData.FixedEchelonSettingExcelTable> CreateFixedEchelonSettingExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    FixedEchelonSettingExcelTable.AddDataList(builder, DataListOffset);
    return FixedEchelonSettingExcelTable.EndFixedEchelonSettingExcelTable(builder);
  }

  public static void StartFixedEchelonSettingExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<FlatData.FixedEchelonSettingExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<FlatData.FixedEchelonSettingExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FlatData.FixedEchelonSettingExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FlatData.FixedEchelonSettingExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatData.FixedEchelonSettingExcelTable> EndFixedEchelonSettingExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.FixedEchelonSettingExcelTable>(o);
  }
  public FixedEchelonSettingExcelTableT UnPack() {
    var _o = new FixedEchelonSettingExcelTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FixedEchelonSettingExcelTableT _o) {
    _o.DataList = new List<FlatData.FixedEchelonSettingExcelT>();
    for (var _j = 0; _j < this.DataListLength; ++_j) {_o.DataList.Add(this.DataList(_j).HasValue ? this.DataList(_j).Value.UnPack() : null);}
  }
  public static Offset<FlatData.FixedEchelonSettingExcelTable> Pack(FlatBufferBuilder builder, FixedEchelonSettingExcelTableT _o) {
    if (_o == null) return default(Offset<FlatData.FixedEchelonSettingExcelTable>);
    var _DataList = default(VectorOffset);
    if (_o.DataList != null) {
      var __DataList = new Offset<FlatData.FixedEchelonSettingExcel>[_o.DataList.Count];
      for (var _j = 0; _j < __DataList.Length; ++_j) { __DataList[_j] = FlatData.FixedEchelonSettingExcel.Pack(builder, _o.DataList[_j]); }
      _DataList = CreateDataListVector(builder, __DataList);
    }
    return CreateFixedEchelonSettingExcelTable(
      builder,
      _DataList);
  }
}

public class FixedEchelonSettingExcelTableT
{
  [Newtonsoft.Json.JsonProperty("DataList")]
  public List<FlatData.FixedEchelonSettingExcelT> DataList { get; set; }

  public FixedEchelonSettingExcelTableT() {
    this.DataList = null;
  }
}


static public class FixedEchelonSettingExcelTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, FlatData.FixedEchelonSettingExcelVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
