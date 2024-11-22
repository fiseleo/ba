// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct NormalSkillTemplateExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static NormalSkillTemplateExcel GetRootAsNormalSkillTemplateExcel(ByteBuffer _bb) { return GetRootAsNormalSkillTemplateExcel(_bb, new NormalSkillTemplateExcel()); }
  public static NormalSkillTemplateExcel GetRootAsNormalSkillTemplateExcel(ByteBuffer _bb, NormalSkillTemplateExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public NormalSkillTemplateExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Index { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float FirstCoolTime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CoolTime { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool MultiAni { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<FlatData.NormalSkillTemplateExcel> CreateNormalSkillTemplateExcel(FlatBufferBuilder builder,
      long Index = 0,
      float FirstCoolTime = 0.0f,
      float CoolTime = 0.0f,
      bool MultiAni = false) {
    builder.StartTable(4);
    NormalSkillTemplateExcel.AddIndex(builder, Index);
    NormalSkillTemplateExcel.AddCoolTime(builder, CoolTime);
    NormalSkillTemplateExcel.AddFirstCoolTime(builder, FirstCoolTime);
    NormalSkillTemplateExcel.AddMultiAni(builder, MultiAni);
    return NormalSkillTemplateExcel.EndNormalSkillTemplateExcel(builder);
  }

  public static void StartNormalSkillTemplateExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddIndex(FlatBufferBuilder builder, long index) { builder.AddLong(0, index, 0); }
  public static void AddFirstCoolTime(FlatBufferBuilder builder, float firstCoolTime) { builder.AddFloat(1, firstCoolTime, 0.0f); }
  public static void AddCoolTime(FlatBufferBuilder builder, float coolTime) { builder.AddFloat(2, coolTime, 0.0f); }
  public static void AddMultiAni(FlatBufferBuilder builder, bool multiAni) { builder.AddBool(3, multiAni, false); }
  public static Offset<FlatData.NormalSkillTemplateExcel> EndNormalSkillTemplateExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.NormalSkillTemplateExcel>(o);
  }
  public NormalSkillTemplateExcelT UnPack() {
    var _o = new NormalSkillTemplateExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(NormalSkillTemplateExcelT _o) {
    _o.Index = this.Index;
    _o.FirstCoolTime = this.FirstCoolTime;
    _o.CoolTime = this.CoolTime;
    _o.MultiAni = this.MultiAni;
  }
  public static Offset<FlatData.NormalSkillTemplateExcel> Pack(FlatBufferBuilder builder, NormalSkillTemplateExcelT _o) {
    if (_o == null) return default(Offset<FlatData.NormalSkillTemplateExcel>);
    return CreateNormalSkillTemplateExcel(
      builder,
      _o.Index,
      _o.FirstCoolTime,
      _o.CoolTime,
      _o.MultiAni);
  }
}

public class NormalSkillTemplateExcelT
{
  [Newtonsoft.Json.JsonProperty("Index")]
  public long Index { get; set; }
  [Newtonsoft.Json.JsonProperty("FirstCoolTime")]
  public float FirstCoolTime { get; set; }
  [Newtonsoft.Json.JsonProperty("CoolTime")]
  public float CoolTime { get; set; }
  [Newtonsoft.Json.JsonProperty("MultiAni")]
  public bool MultiAni { get; set; }

  public NormalSkillTemplateExcelT() {
    this.Index = 0;
    this.FirstCoolTime = 0.0f;
    this.CoolTime = 0.0f;
    this.MultiAni = false;
  }
}


static public class NormalSkillTemplateExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Index*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*FirstCoolTime*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*CoolTime*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*MultiAni*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
