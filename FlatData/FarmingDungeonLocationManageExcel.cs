// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct FarmingDungeonLocationManageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FarmingDungeonLocationManageExcel GetRootAsFarmingDungeonLocationManageExcel(ByteBuffer _bb) { return GetRootAsFarmingDungeonLocationManageExcel(_bb, new FarmingDungeonLocationManageExcel()); }
  public static FarmingDungeonLocationManageExcel GetRootAsFarmingDungeonLocationManageExcel(ByteBuffer _bb, FarmingDungeonLocationManageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FarmingDungeonLocationManageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long FarmingDungeonLocationId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.ContentType ContentType { get { int o = __p.__offset(6); return o != 0 ? (FlatData.ContentType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.ContentType.None; } }
  public FlatData.WeekDungeonType WeekDungeonType { get { int o = __p.__offset(8); return o != 0 ? (FlatData.WeekDungeonType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.WeekDungeonType.None; } }
  public FlatData.SchoolDungeonType SchoolDungeonType { get { int o = __p.__offset(10); return o != 0 ? (FlatData.SchoolDungeonType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.SchoolDungeonType.SchoolA; } }
  public long Order { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string OpenStartDateTime { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOpenStartDateTimeBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetOpenStartDateTimeBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetOpenStartDateTimeArray() { return __p.__vector_as_array<byte>(14); }
  public string OpenEndDateTime { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOpenEndDateTimeBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetOpenEndDateTimeBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetOpenEndDateTimeArray() { return __p.__vector_as_array<byte>(16); }
  public string LocationButtonImagePath { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLocationButtonImagePathBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetLocationButtonImagePathBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetLocationButtonImagePathArray() { return __p.__vector_as_array<byte>(18); }
  public uint LocalizeCodeTitle { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint LocalizeCodeInfo { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<FlatData.FarmingDungeonLocationManageExcel> CreateFarmingDungeonLocationManageExcel(FlatBufferBuilder builder,
      long FarmingDungeonLocationId = 0,
      FlatData.ContentType ContentType = FlatData.ContentType.None,
      FlatData.WeekDungeonType WeekDungeonType = FlatData.WeekDungeonType.None,
      FlatData.SchoolDungeonType SchoolDungeonType = FlatData.SchoolDungeonType.SchoolA,
      long Order = 0,
      StringOffset OpenStartDateTimeOffset = default(StringOffset),
      StringOffset OpenEndDateTimeOffset = default(StringOffset),
      StringOffset LocationButtonImagePathOffset = default(StringOffset),
      uint LocalizeCodeTitle = 0,
      uint LocalizeCodeInfo = 0) {
    builder.StartTable(10);
    FarmingDungeonLocationManageExcel.AddOrder(builder, Order);
    FarmingDungeonLocationManageExcel.AddFarmingDungeonLocationId(builder, FarmingDungeonLocationId);
    FarmingDungeonLocationManageExcel.AddLocalizeCodeInfo(builder, LocalizeCodeInfo);
    FarmingDungeonLocationManageExcel.AddLocalizeCodeTitle(builder, LocalizeCodeTitle);
    FarmingDungeonLocationManageExcel.AddLocationButtonImagePath(builder, LocationButtonImagePathOffset);
    FarmingDungeonLocationManageExcel.AddOpenEndDateTime(builder, OpenEndDateTimeOffset);
    FarmingDungeonLocationManageExcel.AddOpenStartDateTime(builder, OpenStartDateTimeOffset);
    FarmingDungeonLocationManageExcel.AddSchoolDungeonType(builder, SchoolDungeonType);
    FarmingDungeonLocationManageExcel.AddWeekDungeonType(builder, WeekDungeonType);
    FarmingDungeonLocationManageExcel.AddContentType(builder, ContentType);
    return FarmingDungeonLocationManageExcel.EndFarmingDungeonLocationManageExcel(builder);
  }

  public static void StartFarmingDungeonLocationManageExcel(FlatBufferBuilder builder) { builder.StartTable(10); }
  public static void AddFarmingDungeonLocationId(FlatBufferBuilder builder, long farmingDungeonLocationId) { builder.AddLong(0, farmingDungeonLocationId, 0); }
  public static void AddContentType(FlatBufferBuilder builder, FlatData.ContentType contentType) { builder.AddInt(1, (int)contentType, 0); }
  public static void AddWeekDungeonType(FlatBufferBuilder builder, FlatData.WeekDungeonType weekDungeonType) { builder.AddInt(2, (int)weekDungeonType, 0); }
  public static void AddSchoolDungeonType(FlatBufferBuilder builder, FlatData.SchoolDungeonType schoolDungeonType) { builder.AddInt(3, (int)schoolDungeonType, 0); }
  public static void AddOrder(FlatBufferBuilder builder, long order) { builder.AddLong(4, order, 0); }
  public static void AddOpenStartDateTime(FlatBufferBuilder builder, StringOffset openStartDateTimeOffset) { builder.AddOffset(5, openStartDateTimeOffset.Value, 0); }
  public static void AddOpenEndDateTime(FlatBufferBuilder builder, StringOffset openEndDateTimeOffset) { builder.AddOffset(6, openEndDateTimeOffset.Value, 0); }
  public static void AddLocationButtonImagePath(FlatBufferBuilder builder, StringOffset locationButtonImagePathOffset) { builder.AddOffset(7, locationButtonImagePathOffset.Value, 0); }
  public static void AddLocalizeCodeTitle(FlatBufferBuilder builder, uint localizeCodeTitle) { builder.AddUint(8, localizeCodeTitle, 0); }
  public static void AddLocalizeCodeInfo(FlatBufferBuilder builder, uint localizeCodeInfo) { builder.AddUint(9, localizeCodeInfo, 0); }
  public static Offset<FlatData.FarmingDungeonLocationManageExcel> EndFarmingDungeonLocationManageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.FarmingDungeonLocationManageExcel>(o);
  }
  public FarmingDungeonLocationManageExcelT UnPack() {
    var _o = new FarmingDungeonLocationManageExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FarmingDungeonLocationManageExcelT _o) {
    _o.FarmingDungeonLocationId = this.FarmingDungeonLocationId;
    _o.ContentType = this.ContentType;
    _o.WeekDungeonType = this.WeekDungeonType;
    _o.SchoolDungeonType = this.SchoolDungeonType;
    _o.Order = this.Order;
    _o.OpenStartDateTime = this.OpenStartDateTime;
    _o.OpenEndDateTime = this.OpenEndDateTime;
    _o.LocationButtonImagePath = this.LocationButtonImagePath;
    _o.LocalizeCodeTitle = this.LocalizeCodeTitle;
    _o.LocalizeCodeInfo = this.LocalizeCodeInfo;
  }
  public static Offset<FlatData.FarmingDungeonLocationManageExcel> Pack(FlatBufferBuilder builder, FarmingDungeonLocationManageExcelT _o) {
    if (_o == null) return default(Offset<FlatData.FarmingDungeonLocationManageExcel>);
    var _OpenStartDateTime = _o.OpenStartDateTime == null ? default(StringOffset) : builder.CreateString(_o.OpenStartDateTime);
    var _OpenEndDateTime = _o.OpenEndDateTime == null ? default(StringOffset) : builder.CreateString(_o.OpenEndDateTime);
    var _LocationButtonImagePath = _o.LocationButtonImagePath == null ? default(StringOffset) : builder.CreateString(_o.LocationButtonImagePath);
    return CreateFarmingDungeonLocationManageExcel(
      builder,
      _o.FarmingDungeonLocationId,
      _o.ContentType,
      _o.WeekDungeonType,
      _o.SchoolDungeonType,
      _o.Order,
      _OpenStartDateTime,
      _OpenEndDateTime,
      _LocationButtonImagePath,
      _o.LocalizeCodeTitle,
      _o.LocalizeCodeInfo);
  }
}

public class FarmingDungeonLocationManageExcelT
{
  [Newtonsoft.Json.JsonProperty("FarmingDungeonLocationId")]
  public long FarmingDungeonLocationId { get; set; }
  [Newtonsoft.Json.JsonProperty("ContentType")]
  public FlatData.ContentType ContentType { get; set; }
  [Newtonsoft.Json.JsonProperty("WeekDungeonType")]
  public FlatData.WeekDungeonType WeekDungeonType { get; set; }
  [Newtonsoft.Json.JsonProperty("SchoolDungeonType")]
  public FlatData.SchoolDungeonType SchoolDungeonType { get; set; }
  [Newtonsoft.Json.JsonProperty("Order")]
  public long Order { get; set; }
  [Newtonsoft.Json.JsonProperty("OpenStartDateTime")]
  public string OpenStartDateTime { get; set; }
  [Newtonsoft.Json.JsonProperty("OpenEndDateTime")]
  public string OpenEndDateTime { get; set; }
  [Newtonsoft.Json.JsonProperty("LocationButtonImagePath")]
  public string LocationButtonImagePath { get; set; }
  [Newtonsoft.Json.JsonProperty("LocalizeCodeTitle")]
  public uint LocalizeCodeTitle { get; set; }
  [Newtonsoft.Json.JsonProperty("LocalizeCodeInfo")]
  public uint LocalizeCodeInfo { get; set; }

  public FarmingDungeonLocationManageExcelT() {
    this.FarmingDungeonLocationId = 0;
    this.ContentType = FlatData.ContentType.None;
    this.WeekDungeonType = FlatData.WeekDungeonType.None;
    this.SchoolDungeonType = FlatData.SchoolDungeonType.SchoolA;
    this.Order = 0;
    this.OpenStartDateTime = null;
    this.OpenEndDateTime = null;
    this.LocationButtonImagePath = null;
    this.LocalizeCodeTitle = 0;
    this.LocalizeCodeInfo = 0;
  }
}


static public class FarmingDungeonLocationManageExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*FarmingDungeonLocationId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*ContentType*/, 4 /*FlatData.ContentType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*WeekDungeonType*/, 4 /*FlatData.WeekDungeonType*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*SchoolDungeonType*/, 4 /*FlatData.SchoolDungeonType*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*Order*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 14 /*OpenStartDateTime*/, false)
      && verifier.VerifyString(tablePos, 16 /*OpenEndDateTime*/, false)
      && verifier.VerifyString(tablePos, 18 /*LocationButtonImagePath*/, false)
      && verifier.VerifyField(tablePos, 20 /*LocalizeCodeTitle*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*LocalizeCodeInfo*/, 4 /*uint*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
