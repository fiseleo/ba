// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct RaidStageRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static RaidStageRewardExcel GetRootAsRaidStageRewardExcel(ByteBuffer _bb) { return GetRootAsRaidStageRewardExcel(_bb, new RaidStageRewardExcel()); }
  public static RaidStageRewardExcel GetRootAsRaidStageRewardExcel(ByteBuffer _bb, RaidStageRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public RaidStageRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long GroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsClearStageRewardHideInfo { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long ClearStageRewardProb { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.ParcelType ClearStageRewardParcelType { get { int o = __p.__offset(10); return o != 0 ? (FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.ParcelType.None; } }
  public long ClearStageRewardParcelUniqueID { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string ClearStageRewardParcelUniqueName { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetClearStageRewardParcelUniqueNameBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetClearStageRewardParcelUniqueNameBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetClearStageRewardParcelUniqueNameArray() { return __p.__vector_as_array<byte>(14); }
  public long ClearStageRewardAmount { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatData.RaidStageRewardExcel> CreateRaidStageRewardExcel(FlatBufferBuilder builder,
      long GroupId = 0,
      bool IsClearStageRewardHideInfo = false,
      long ClearStageRewardProb = 0,
      FlatData.ParcelType ClearStageRewardParcelType = FlatData.ParcelType.None,
      long ClearStageRewardParcelUniqueID = 0,
      StringOffset ClearStageRewardParcelUniqueNameOffset = default(StringOffset),
      long ClearStageRewardAmount = 0) {
    builder.StartTable(7);
    RaidStageRewardExcel.AddClearStageRewardAmount(builder, ClearStageRewardAmount);
    RaidStageRewardExcel.AddClearStageRewardParcelUniqueID(builder, ClearStageRewardParcelUniqueID);
    RaidStageRewardExcel.AddClearStageRewardProb(builder, ClearStageRewardProb);
    RaidStageRewardExcel.AddGroupId(builder, GroupId);
    RaidStageRewardExcel.AddClearStageRewardParcelUniqueName(builder, ClearStageRewardParcelUniqueNameOffset);
    RaidStageRewardExcel.AddClearStageRewardParcelType(builder, ClearStageRewardParcelType);
    RaidStageRewardExcel.AddIsClearStageRewardHideInfo(builder, IsClearStageRewardHideInfo);
    return RaidStageRewardExcel.EndRaidStageRewardExcel(builder);
  }

  public static void StartRaidStageRewardExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddGroupId(FlatBufferBuilder builder, long groupId) { builder.AddLong(0, groupId, 0); }
  public static void AddIsClearStageRewardHideInfo(FlatBufferBuilder builder, bool isClearStageRewardHideInfo) { builder.AddBool(1, isClearStageRewardHideInfo, false); }
  public static void AddClearStageRewardProb(FlatBufferBuilder builder, long clearStageRewardProb) { builder.AddLong(2, clearStageRewardProb, 0); }
  public static void AddClearStageRewardParcelType(FlatBufferBuilder builder, FlatData.ParcelType clearStageRewardParcelType) { builder.AddInt(3, (int)clearStageRewardParcelType, 0); }
  public static void AddClearStageRewardParcelUniqueID(FlatBufferBuilder builder, long clearStageRewardParcelUniqueID) { builder.AddLong(4, clearStageRewardParcelUniqueID, 0); }
  public static void AddClearStageRewardParcelUniqueName(FlatBufferBuilder builder, StringOffset clearStageRewardParcelUniqueNameOffset) { builder.AddOffset(5, clearStageRewardParcelUniqueNameOffset.Value, 0); }
  public static void AddClearStageRewardAmount(FlatBufferBuilder builder, long clearStageRewardAmount) { builder.AddLong(6, clearStageRewardAmount, 0); }
  public static Offset<FlatData.RaidStageRewardExcel> EndRaidStageRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.RaidStageRewardExcel>(o);
  }
  public RaidStageRewardExcelT UnPack() {
    var _o = new RaidStageRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(RaidStageRewardExcelT _o) {
    _o.GroupId = this.GroupId;
    _o.IsClearStageRewardHideInfo = this.IsClearStageRewardHideInfo;
    _o.ClearStageRewardProb = this.ClearStageRewardProb;
    _o.ClearStageRewardParcelType = this.ClearStageRewardParcelType;
    _o.ClearStageRewardParcelUniqueID = this.ClearStageRewardParcelUniqueID;
    _o.ClearStageRewardParcelUniqueName = this.ClearStageRewardParcelUniqueName;
    _o.ClearStageRewardAmount = this.ClearStageRewardAmount;
  }
  public static Offset<FlatData.RaidStageRewardExcel> Pack(FlatBufferBuilder builder, RaidStageRewardExcelT _o) {
    if (_o == null) return default(Offset<FlatData.RaidStageRewardExcel>);
    var _ClearStageRewardParcelUniqueName = _o.ClearStageRewardParcelUniqueName == null ? default(StringOffset) : builder.CreateString(_o.ClearStageRewardParcelUniqueName);
    return CreateRaidStageRewardExcel(
      builder,
      _o.GroupId,
      _o.IsClearStageRewardHideInfo,
      _o.ClearStageRewardProb,
      _o.ClearStageRewardParcelType,
      _o.ClearStageRewardParcelUniqueID,
      _ClearStageRewardParcelUniqueName,
      _o.ClearStageRewardAmount);
  }
}

public class RaidStageRewardExcelT
{
  [Newtonsoft.Json.JsonProperty("GroupId")]
  public long GroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("IsClearStageRewardHideInfo")]
  public bool IsClearStageRewardHideInfo { get; set; }
  [Newtonsoft.Json.JsonProperty("ClearStageRewardProb")]
  public long ClearStageRewardProb { get; set; }
  [Newtonsoft.Json.JsonProperty("ClearStageRewardParcelType")]
  public FlatData.ParcelType ClearStageRewardParcelType { get; set; }
  [Newtonsoft.Json.JsonProperty("ClearStageRewardParcelUniqueID")]
  public long ClearStageRewardParcelUniqueID { get; set; }
  [Newtonsoft.Json.JsonProperty("ClearStageRewardParcelUniqueName")]
  public string ClearStageRewardParcelUniqueName { get; set; }
  [Newtonsoft.Json.JsonProperty("ClearStageRewardAmount")]
  public long ClearStageRewardAmount { get; set; }

  public RaidStageRewardExcelT() {
    this.GroupId = 0;
    this.IsClearStageRewardHideInfo = false;
    this.ClearStageRewardProb = 0;
    this.ClearStageRewardParcelType = FlatData.ParcelType.None;
    this.ClearStageRewardParcelUniqueID = 0;
    this.ClearStageRewardParcelUniqueName = null;
    this.ClearStageRewardAmount = 0;
  }
}


static public class RaidStageRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*GroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*IsClearStageRewardHideInfo*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 8 /*ClearStageRewardProb*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*ClearStageRewardParcelType*/, 4 /*FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*ClearStageRewardParcelUniqueID*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 14 /*ClearStageRewardParcelUniqueName*/, false)
      && verifier.VerifyField(tablePos, 16 /*ClearStageRewardAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
