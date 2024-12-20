// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentDebuffRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentDebuffRewardExcel GetRootAsEventContentDebuffRewardExcel(ByteBuffer _bb) { return GetRootAsEventContentDebuffRewardExcel(_bb, new EventContentDebuffRewardExcel()); }
  public static EventContentDebuffRewardExcel GetRootAsEventContentDebuffRewardExcel(ByteBuffer _bb, EventContentDebuffRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentDebuffRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventStageId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.EventContentItemType EventContentItemType { get { int o = __p.__offset(8); return o != 0 ? (FlatData.EventContentItemType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.EventContentItemType.EventPoint; } }
  public long RewardPercentage { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatData.EventContentDebuffRewardExcel> CreateEventContentDebuffRewardExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      long EventStageId = 0,
      FlatData.EventContentItemType EventContentItemType = FlatData.EventContentItemType.EventPoint,
      long RewardPercentage = 0) {
    builder.StartTable(4);
    EventContentDebuffRewardExcel.AddRewardPercentage(builder, RewardPercentage);
    EventContentDebuffRewardExcel.AddEventStageId(builder, EventStageId);
    EventContentDebuffRewardExcel.AddEventContentId(builder, EventContentId);
    EventContentDebuffRewardExcel.AddEventContentItemType(builder, EventContentItemType);
    return EventContentDebuffRewardExcel.EndEventContentDebuffRewardExcel(builder);
  }

  public static void StartEventContentDebuffRewardExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddEventStageId(FlatBufferBuilder builder, long eventStageId) { builder.AddLong(1, eventStageId, 0); }
  public static void AddEventContentItemType(FlatBufferBuilder builder, FlatData.EventContentItemType eventContentItemType) { builder.AddInt(2, (int)eventContentItemType, 0); }
  public static void AddRewardPercentage(FlatBufferBuilder builder, long rewardPercentage) { builder.AddLong(3, rewardPercentage, 0); }
  public static Offset<FlatData.EventContentDebuffRewardExcel> EndEventContentDebuffRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.EventContentDebuffRewardExcel>(o);
  }
  public EventContentDebuffRewardExcelT UnPack() {
    var _o = new EventContentDebuffRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentDebuffRewardExcelT _o) {
    _o.EventContentId = this.EventContentId;
    _o.EventStageId = this.EventStageId;
    _o.EventContentItemType = this.EventContentItemType;
    _o.RewardPercentage = this.RewardPercentage;
  }
  public static Offset<FlatData.EventContentDebuffRewardExcel> Pack(FlatBufferBuilder builder, EventContentDebuffRewardExcelT _o) {
    if (_o == null) return default(Offset<FlatData.EventContentDebuffRewardExcel>);
    return CreateEventContentDebuffRewardExcel(
      builder,
      _o.EventContentId,
      _o.EventStageId,
      _o.EventContentItemType,
      _o.RewardPercentage);
  }
}

public class EventContentDebuffRewardExcelT
{
  [Newtonsoft.Json.JsonProperty("EventContentId")]
  public long EventContentId { get; set; }
  [Newtonsoft.Json.JsonProperty("EventStageId")]
  public long EventStageId { get; set; }
  [Newtonsoft.Json.JsonProperty("EventContentItemType")]
  public FlatData.EventContentItemType EventContentItemType { get; set; }
  [Newtonsoft.Json.JsonProperty("RewardPercentage")]
  public long RewardPercentage { get; set; }

  public EventContentDebuffRewardExcelT() {
    this.EventContentId = 0;
    this.EventStageId = 0;
    this.EventContentItemType = FlatData.EventContentItemType.EventPoint;
    this.RewardPercentage = 0;
  }
}


static public class EventContentDebuffRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EventStageId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*EventContentItemType*/, 4 /*FlatData.EventContentItemType*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*RewardPercentage*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
