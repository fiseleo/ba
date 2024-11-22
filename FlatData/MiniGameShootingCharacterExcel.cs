// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct MiniGameShootingCharacterExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MiniGameShootingCharacterExcel GetRootAsMiniGameShootingCharacterExcel(ByteBuffer _bb) { return GetRootAsMiniGameShootingCharacterExcel(_bb, new MiniGameShootingCharacterExcel()); }
  public static MiniGameShootingCharacterExcel GetRootAsMiniGameShootingCharacterExcel(ByteBuffer _bb, MiniGameShootingCharacterExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MiniGameShootingCharacterExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long UniqueId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string SpineResourceName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSpineResourceNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetSpineResourceNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetSpineResourceNameArray() { return __p.__vector_as_array<byte>(6); }
  public float BodyRadius { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public string ModelPrefabName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetModelPrefabNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetModelPrefabNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetModelPrefabNameArray() { return __p.__vector_as_array<byte>(10); }
  public string NormalAttackSkillData { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNormalAttackSkillDataBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetNormalAttackSkillDataBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetNormalAttackSkillDataArray() { return __p.__vector_as_array<byte>(12); }
  public string PublicSkillData(int j) { int o = __p.__offset(14); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int PublicSkillDataLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string DeathSkillData { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDeathSkillDataBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetDeathSkillDataBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetDeathSkillDataArray() { return __p.__vector_as_array<byte>(16); }
  public long MaxHP { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AttackPower { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DefensePower { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CriticalRate { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CriticalDamageRate { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long AttackRange { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long MoveSpeed { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ShotTime { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsBoss { get { int o = __p.__offset(34); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public float Scale { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public bool IgnoreObstacleCheck { get { int o = __p.__offset(38); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long CharacterVoiceGroupId { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatData.MiniGameShootingCharacterExcel> CreateMiniGameShootingCharacterExcel(FlatBufferBuilder builder,
      long UniqueId = 0,
      StringOffset SpineResourceNameOffset = default(StringOffset),
      float BodyRadius = 0.0f,
      StringOffset ModelPrefabNameOffset = default(StringOffset),
      StringOffset NormalAttackSkillDataOffset = default(StringOffset),
      VectorOffset PublicSkillDataOffset = default(VectorOffset),
      StringOffset DeathSkillDataOffset = default(StringOffset),
      long MaxHP = 0,
      long AttackPower = 0,
      long DefensePower = 0,
      long CriticalRate = 0,
      long CriticalDamageRate = 0,
      long AttackRange = 0,
      long MoveSpeed = 0,
      long ShotTime = 0,
      bool IsBoss = false,
      float Scale = 0.0f,
      bool IgnoreObstacleCheck = false,
      long CharacterVoiceGroupId = 0) {
    builder.StartTable(19);
    MiniGameShootingCharacterExcel.AddCharacterVoiceGroupId(builder, CharacterVoiceGroupId);
    MiniGameShootingCharacterExcel.AddShotTime(builder, ShotTime);
    MiniGameShootingCharacterExcel.AddMoveSpeed(builder, MoveSpeed);
    MiniGameShootingCharacterExcel.AddAttackRange(builder, AttackRange);
    MiniGameShootingCharacterExcel.AddCriticalDamageRate(builder, CriticalDamageRate);
    MiniGameShootingCharacterExcel.AddCriticalRate(builder, CriticalRate);
    MiniGameShootingCharacterExcel.AddDefensePower(builder, DefensePower);
    MiniGameShootingCharacterExcel.AddAttackPower(builder, AttackPower);
    MiniGameShootingCharacterExcel.AddMaxHP(builder, MaxHP);
    MiniGameShootingCharacterExcel.AddUniqueId(builder, UniqueId);
    MiniGameShootingCharacterExcel.AddScale(builder, Scale);
    MiniGameShootingCharacterExcel.AddDeathSkillData(builder, DeathSkillDataOffset);
    MiniGameShootingCharacterExcel.AddPublicSkillData(builder, PublicSkillDataOffset);
    MiniGameShootingCharacterExcel.AddNormalAttackSkillData(builder, NormalAttackSkillDataOffset);
    MiniGameShootingCharacterExcel.AddModelPrefabName(builder, ModelPrefabNameOffset);
    MiniGameShootingCharacterExcel.AddBodyRadius(builder, BodyRadius);
    MiniGameShootingCharacterExcel.AddSpineResourceName(builder, SpineResourceNameOffset);
    MiniGameShootingCharacterExcel.AddIgnoreObstacleCheck(builder, IgnoreObstacleCheck);
    MiniGameShootingCharacterExcel.AddIsBoss(builder, IsBoss);
    return MiniGameShootingCharacterExcel.EndMiniGameShootingCharacterExcel(builder);
  }

  public static void StartMiniGameShootingCharacterExcel(FlatBufferBuilder builder) { builder.StartTable(19); }
  public static void AddUniqueId(FlatBufferBuilder builder, long uniqueId) { builder.AddLong(0, uniqueId, 0); }
  public static void AddSpineResourceName(FlatBufferBuilder builder, StringOffset spineResourceNameOffset) { builder.AddOffset(1, spineResourceNameOffset.Value, 0); }
  public static void AddBodyRadius(FlatBufferBuilder builder, float bodyRadius) { builder.AddFloat(2, bodyRadius, 0.0f); }
  public static void AddModelPrefabName(FlatBufferBuilder builder, StringOffset modelPrefabNameOffset) { builder.AddOffset(3, modelPrefabNameOffset.Value, 0); }
  public static void AddNormalAttackSkillData(FlatBufferBuilder builder, StringOffset normalAttackSkillDataOffset) { builder.AddOffset(4, normalAttackSkillDataOffset.Value, 0); }
  public static void AddPublicSkillData(FlatBufferBuilder builder, VectorOffset publicSkillDataOffset) { builder.AddOffset(5, publicSkillDataOffset.Value, 0); }
  public static VectorOffset CreatePublicSkillDataVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreatePublicSkillDataVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePublicSkillDataVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePublicSkillDataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPublicSkillDataVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDeathSkillData(FlatBufferBuilder builder, StringOffset deathSkillDataOffset) { builder.AddOffset(6, deathSkillDataOffset.Value, 0); }
  public static void AddMaxHP(FlatBufferBuilder builder, long maxHP) { builder.AddLong(7, maxHP, 0); }
  public static void AddAttackPower(FlatBufferBuilder builder, long attackPower) { builder.AddLong(8, attackPower, 0); }
  public static void AddDefensePower(FlatBufferBuilder builder, long defensePower) { builder.AddLong(9, defensePower, 0); }
  public static void AddCriticalRate(FlatBufferBuilder builder, long criticalRate) { builder.AddLong(10, criticalRate, 0); }
  public static void AddCriticalDamageRate(FlatBufferBuilder builder, long criticalDamageRate) { builder.AddLong(11, criticalDamageRate, 0); }
  public static void AddAttackRange(FlatBufferBuilder builder, long attackRange) { builder.AddLong(12, attackRange, 0); }
  public static void AddMoveSpeed(FlatBufferBuilder builder, long moveSpeed) { builder.AddLong(13, moveSpeed, 0); }
  public static void AddShotTime(FlatBufferBuilder builder, long shotTime) { builder.AddLong(14, shotTime, 0); }
  public static void AddIsBoss(FlatBufferBuilder builder, bool isBoss) { builder.AddBool(15, isBoss, false); }
  public static void AddScale(FlatBufferBuilder builder, float scale) { builder.AddFloat(16, scale, 0.0f); }
  public static void AddIgnoreObstacleCheck(FlatBufferBuilder builder, bool ignoreObstacleCheck) { builder.AddBool(17, ignoreObstacleCheck, false); }
  public static void AddCharacterVoiceGroupId(FlatBufferBuilder builder, long characterVoiceGroupId) { builder.AddLong(18, characterVoiceGroupId, 0); }
  public static Offset<FlatData.MiniGameShootingCharacterExcel> EndMiniGameShootingCharacterExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.MiniGameShootingCharacterExcel>(o);
  }
  public MiniGameShootingCharacterExcelT UnPack() {
    var _o = new MiniGameShootingCharacterExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MiniGameShootingCharacterExcelT _o) {
    _o.UniqueId = this.UniqueId;
    _o.SpineResourceName = this.SpineResourceName;
    _o.BodyRadius = this.BodyRadius;
    _o.ModelPrefabName = this.ModelPrefabName;
    _o.NormalAttackSkillData = this.NormalAttackSkillData;
    _o.PublicSkillData = new List<string>();
    for (var _j = 0; _j < this.PublicSkillDataLength; ++_j) {_o.PublicSkillData.Add(this.PublicSkillData(_j));}
    _o.DeathSkillData = this.DeathSkillData;
    _o.MaxHP = this.MaxHP;
    _o.AttackPower = this.AttackPower;
    _o.DefensePower = this.DefensePower;
    _o.CriticalRate = this.CriticalRate;
    _o.CriticalDamageRate = this.CriticalDamageRate;
    _o.AttackRange = this.AttackRange;
    _o.MoveSpeed = this.MoveSpeed;
    _o.ShotTime = this.ShotTime;
    _o.IsBoss = this.IsBoss;
    _o.Scale = this.Scale;
    _o.IgnoreObstacleCheck = this.IgnoreObstacleCheck;
    _o.CharacterVoiceGroupId = this.CharacterVoiceGroupId;
  }
  public static Offset<FlatData.MiniGameShootingCharacterExcel> Pack(FlatBufferBuilder builder, MiniGameShootingCharacterExcelT _o) {
    if (_o == null) return default(Offset<FlatData.MiniGameShootingCharacterExcel>);
    var _SpineResourceName = _o.SpineResourceName == null ? default(StringOffset) : builder.CreateString(_o.SpineResourceName);
    var _ModelPrefabName = _o.ModelPrefabName == null ? default(StringOffset) : builder.CreateString(_o.ModelPrefabName);
    var _NormalAttackSkillData = _o.NormalAttackSkillData == null ? default(StringOffset) : builder.CreateString(_o.NormalAttackSkillData);
    var _PublicSkillData = default(VectorOffset);
    if (_o.PublicSkillData != null) {
      var __PublicSkillData = new StringOffset[_o.PublicSkillData.Count];
      for (var _j = 0; _j < __PublicSkillData.Length; ++_j) { __PublicSkillData[_j] = builder.CreateString(_o.PublicSkillData[_j]); }
      _PublicSkillData = CreatePublicSkillDataVector(builder, __PublicSkillData);
    }
    var _DeathSkillData = _o.DeathSkillData == null ? default(StringOffset) : builder.CreateString(_o.DeathSkillData);
    return CreateMiniGameShootingCharacterExcel(
      builder,
      _o.UniqueId,
      _SpineResourceName,
      _o.BodyRadius,
      _ModelPrefabName,
      _NormalAttackSkillData,
      _PublicSkillData,
      _DeathSkillData,
      _o.MaxHP,
      _o.AttackPower,
      _o.DefensePower,
      _o.CriticalRate,
      _o.CriticalDamageRate,
      _o.AttackRange,
      _o.MoveSpeed,
      _o.ShotTime,
      _o.IsBoss,
      _o.Scale,
      _o.IgnoreObstacleCheck,
      _o.CharacterVoiceGroupId);
  }
}

public class MiniGameShootingCharacterExcelT
{
  [Newtonsoft.Json.JsonProperty("UniqueId")]
  public long UniqueId { get; set; }
  [Newtonsoft.Json.JsonProperty("SpineResourceName")]
  public string SpineResourceName { get; set; }
  [Newtonsoft.Json.JsonProperty("BodyRadius")]
  public float BodyRadius { get; set; }
  [Newtonsoft.Json.JsonProperty("ModelPrefabName")]
  public string ModelPrefabName { get; set; }
  [Newtonsoft.Json.JsonProperty("NormalAttackSkillData")]
  public string NormalAttackSkillData { get; set; }
  [Newtonsoft.Json.JsonProperty("PublicSkillData")]
  public List<string> PublicSkillData { get; set; }
  [Newtonsoft.Json.JsonProperty("DeathSkillData")]
  public string DeathSkillData { get; set; }
  [Newtonsoft.Json.JsonProperty("MaxHP")]
  public long MaxHP { get; set; }
  [Newtonsoft.Json.JsonProperty("AttackPower")]
  public long AttackPower { get; set; }
  [Newtonsoft.Json.JsonProperty("DefensePower")]
  public long DefensePower { get; set; }
  [Newtonsoft.Json.JsonProperty("CriticalRate")]
  public long CriticalRate { get; set; }
  [Newtonsoft.Json.JsonProperty("CriticalDamageRate")]
  public long CriticalDamageRate { get; set; }
  [Newtonsoft.Json.JsonProperty("AttackRange")]
  public long AttackRange { get; set; }
  [Newtonsoft.Json.JsonProperty("MoveSpeed")]
  public long MoveSpeed { get; set; }
  [Newtonsoft.Json.JsonProperty("ShotTime")]
  public long ShotTime { get; set; }
  [Newtonsoft.Json.JsonProperty("IsBoss")]
  public bool IsBoss { get; set; }
  [Newtonsoft.Json.JsonProperty("Scale")]
  public float Scale { get; set; }
  [Newtonsoft.Json.JsonProperty("IgnoreObstacleCheck")]
  public bool IgnoreObstacleCheck { get; set; }
  [Newtonsoft.Json.JsonProperty("CharacterVoiceGroupId")]
  public long CharacterVoiceGroupId { get; set; }

  public MiniGameShootingCharacterExcelT() {
    this.UniqueId = 0;
    this.SpineResourceName = null;
    this.BodyRadius = 0.0f;
    this.ModelPrefabName = null;
    this.NormalAttackSkillData = null;
    this.PublicSkillData = null;
    this.DeathSkillData = null;
    this.MaxHP = 0;
    this.AttackPower = 0;
    this.DefensePower = 0;
    this.CriticalRate = 0;
    this.CriticalDamageRate = 0;
    this.AttackRange = 0;
    this.MoveSpeed = 0;
    this.ShotTime = 0;
    this.IsBoss = false;
    this.Scale = 0.0f;
    this.IgnoreObstacleCheck = false;
    this.CharacterVoiceGroupId = 0;
  }
}


static public class MiniGameShootingCharacterExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*UniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 6 /*SpineResourceName*/, false)
      && verifier.VerifyField(tablePos, 8 /*BodyRadius*/, 4 /*float*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*ModelPrefabName*/, false)
      && verifier.VerifyString(tablePos, 12 /*NormalAttackSkillData*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 14 /*PublicSkillData*/, false)
      && verifier.VerifyString(tablePos, 16 /*DeathSkillData*/, false)
      && verifier.VerifyField(tablePos, 18 /*MaxHP*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*AttackPower*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 22 /*DefensePower*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 24 /*CriticalRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 26 /*CriticalDamageRate*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 28 /*AttackRange*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 30 /*MoveSpeed*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 32 /*ShotTime*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 34 /*IsBoss*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 36 /*Scale*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 38 /*IgnoreObstacleCheck*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 40 /*CharacterVoiceGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
