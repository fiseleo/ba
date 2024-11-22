// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EventContentSpineDialogOffsetExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentSpineDialogOffsetExcel GetRootAsEventContentSpineDialogOffsetExcel(ByteBuffer _bb) { return GetRootAsEventContentSpineDialogOffsetExcel(_bb, new EventContentSpineDialogOffsetExcel()); }
  public static EventContentSpineDialogOffsetExcel GetRootAsEventContentSpineDialogOffsetExcel(ByteBuffer _bb, EventContentSpineDialogOffsetExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentSpineDialogOffsetExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.EventContentType EventContentType { get { int o = __p.__offset(6); return o != 0 ? (FlatData.EventContentType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.EventContentType.Stage; } }
  public long CostumeUniqueId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float SpineOffsetX { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float SpineOffsetY { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float DialogOffsetX { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float DialogOffsetY { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<FlatData.EventContentSpineDialogOffsetExcel> CreateEventContentSpineDialogOffsetExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      FlatData.EventContentType EventContentType = FlatData.EventContentType.Stage,
      long CostumeUniqueId = 0,
      float SpineOffsetX = 0.0f,
      float SpineOffsetY = 0.0f,
      float DialogOffsetX = 0.0f,
      float DialogOffsetY = 0.0f) {
    builder.StartTable(7);
    EventContentSpineDialogOffsetExcel.AddCostumeUniqueId(builder, CostumeUniqueId);
    EventContentSpineDialogOffsetExcel.AddEventContentId(builder, EventContentId);
    EventContentSpineDialogOffsetExcel.AddDialogOffsetY(builder, DialogOffsetY);
    EventContentSpineDialogOffsetExcel.AddDialogOffsetX(builder, DialogOffsetX);
    EventContentSpineDialogOffsetExcel.AddSpineOffsetY(builder, SpineOffsetY);
    EventContentSpineDialogOffsetExcel.AddSpineOffsetX(builder, SpineOffsetX);
    EventContentSpineDialogOffsetExcel.AddEventContentType(builder, EventContentType);
    return EventContentSpineDialogOffsetExcel.EndEventContentSpineDialogOffsetExcel(builder);
  }

  public static void StartEventContentSpineDialogOffsetExcel(FlatBufferBuilder builder) { builder.StartTable(7); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddEventContentType(FlatBufferBuilder builder, FlatData.EventContentType eventContentType) { builder.AddInt(1, (int)eventContentType, 0); }
  public static void AddCostumeUniqueId(FlatBufferBuilder builder, long costumeUniqueId) { builder.AddLong(2, costumeUniqueId, 0); }
  public static void AddSpineOffsetX(FlatBufferBuilder builder, float spineOffsetX) { builder.AddFloat(3, spineOffsetX, 0.0f); }
  public static void AddSpineOffsetY(FlatBufferBuilder builder, float spineOffsetY) { builder.AddFloat(4, spineOffsetY, 0.0f); }
  public static void AddDialogOffsetX(FlatBufferBuilder builder, float dialogOffsetX) { builder.AddFloat(5, dialogOffsetX, 0.0f); }
  public static void AddDialogOffsetY(FlatBufferBuilder builder, float dialogOffsetY) { builder.AddFloat(6, dialogOffsetY, 0.0f); }
  public static Offset<FlatData.EventContentSpineDialogOffsetExcel> EndEventContentSpineDialogOffsetExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.EventContentSpineDialogOffsetExcel>(o);
  }
  public EventContentSpineDialogOffsetExcelT UnPack() {
    var _o = new EventContentSpineDialogOffsetExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentSpineDialogOffsetExcelT _o) {
    _o.EventContentId = this.EventContentId;
    _o.EventContentType = this.EventContentType;
    _o.CostumeUniqueId = this.CostumeUniqueId;
    _o.SpineOffsetX = this.SpineOffsetX;
    _o.SpineOffsetY = this.SpineOffsetY;
    _o.DialogOffsetX = this.DialogOffsetX;
    _o.DialogOffsetY = this.DialogOffsetY;
  }
  public static Offset<FlatData.EventContentSpineDialogOffsetExcel> Pack(FlatBufferBuilder builder, EventContentSpineDialogOffsetExcelT _o) {
    if (_o == null) return default(Offset<FlatData.EventContentSpineDialogOffsetExcel>);
    return CreateEventContentSpineDialogOffsetExcel(
      builder,
      _o.EventContentId,
      _o.EventContentType,
      _o.CostumeUniqueId,
      _o.SpineOffsetX,
      _o.SpineOffsetY,
      _o.DialogOffsetX,
      _o.DialogOffsetY);
  }
}

public class EventContentSpineDialogOffsetExcelT
{
  [Newtonsoft.Json.JsonProperty("EventContentId")]
  public long EventContentId { get; set; }
  [Newtonsoft.Json.JsonProperty("EventContentType")]
  public FlatData.EventContentType EventContentType { get; set; }
  [Newtonsoft.Json.JsonProperty("CostumeUniqueId")]
  public long CostumeUniqueId { get; set; }
  [Newtonsoft.Json.JsonProperty("SpineOffsetX")]
  public float SpineOffsetX { get; set; }
  [Newtonsoft.Json.JsonProperty("SpineOffsetY")]
  public float SpineOffsetY { get; set; }
  [Newtonsoft.Json.JsonProperty("DialogOffsetX")]
  public float DialogOffsetX { get; set; }
  [Newtonsoft.Json.JsonProperty("DialogOffsetY")]
  public float DialogOffsetY { get; set; }

  public EventContentSpineDialogOffsetExcelT() {
    this.EventContentId = 0;
    this.EventContentType = FlatData.EventContentType.Stage;
    this.CostumeUniqueId = 0;
    this.SpineOffsetX = 0.0f;
    this.SpineOffsetY = 0.0f;
    this.DialogOffsetX = 0.0f;
    this.DialogOffsetY = 0.0f;
  }
}


static public class EventContentSpineDialogOffsetExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EventContentType*/, 4 /*FlatData.EventContentType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*CostumeUniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*SpineOffsetX*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*SpineOffsetY*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*DialogOffsetX*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*DialogOffsetY*/, 4 /*float*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
