// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentBoxGachaElementExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentBoxGachaElementExcelTable GetRootAsEventContentBoxGachaElementExcelTable(ByteBuffer _bb) { return GetRootAsEventContentBoxGachaElementExcelTable(_bb, new EventContentBoxGachaElementExcelTable()); }
  public static EventContentBoxGachaElementExcelTable GetRootAsEventContentBoxGachaElementExcelTable(ByteBuffer _bb, EventContentBoxGachaElementExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentBoxGachaElementExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public FlatData.EventContentBoxGachaElementExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (FlatData.EventContentBoxGachaElementExcel?)(new FlatData.EventContentBoxGachaElementExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<FlatData.EventContentBoxGachaElementExcelTable> CreateEventContentBoxGachaElementExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    EventContentBoxGachaElementExcelTable.AddDataList(builder, DataListOffset);
    return EventContentBoxGachaElementExcelTable.EndEventContentBoxGachaElementExcelTable(builder);
  }

  public static void StartEventContentBoxGachaElementExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<FlatData.EventContentBoxGachaElementExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<FlatData.EventContentBoxGachaElementExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<FlatData.EventContentBoxGachaElementExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<FlatData.EventContentBoxGachaElementExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FlatData.EventContentBoxGachaElementExcelTable> EndEventContentBoxGachaElementExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.EventContentBoxGachaElementExcelTable>(o);
  }
  public EventContentBoxGachaElementExcelTableT UnPack() {
    var _o = new EventContentBoxGachaElementExcelTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentBoxGachaElementExcelTableT _o) {
    _o.DataList = new List<FlatData.EventContentBoxGachaElementExcelT>();
    for (var _j = 0; _j < this.DataListLength; ++_j) {_o.DataList.Add(this.DataList(_j).HasValue ? this.DataList(_j).Value.UnPack() : null);}
  }
  public static Offset<FlatData.EventContentBoxGachaElementExcelTable> Pack(FlatBufferBuilder builder, EventContentBoxGachaElementExcelTableT _o) {
    if (_o == null) return default(Offset<FlatData.EventContentBoxGachaElementExcelTable>);
    var _DataList = default(VectorOffset);
    if (_o.DataList != null) {
      var __DataList = new Offset<FlatData.EventContentBoxGachaElementExcel>[_o.DataList.Count];
      for (var _j = 0; _j < __DataList.Length; ++_j) { __DataList[_j] = FlatData.EventContentBoxGachaElementExcel.Pack(builder, _o.DataList[_j]); }
      _DataList = CreateDataListVector(builder, __DataList);
    }
    return CreateEventContentBoxGachaElementExcelTable(
      builder,
      _DataList);
  }
}

public class EventContentBoxGachaElementExcelTableT
{
  [Newtonsoft.Json.JsonProperty("DataList")]
  public List<FlatData.EventContentBoxGachaElementExcelT> DataList { get; set; }

  public EventContentBoxGachaElementExcelTableT() {
    this.DataList = null;
  }
}


static public class EventContentBoxGachaElementExcelTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, FlatData.EventContentBoxGachaElementExcelVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
