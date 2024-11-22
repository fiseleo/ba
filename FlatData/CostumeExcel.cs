// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CostumeExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CostumeExcel GetRootAsCostumeExcel(ByteBuffer _bb) { return GetRootAsCostumeExcel(_bb, new CostumeExcel()); }
  public static CostumeExcel GetRootAsCostumeExcel(ByteBuffer _bb, CostumeExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CostumeExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long CostumeGroupId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CostumeUniqueId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string DevName { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDevNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetDevNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetDevNameArray() { return __p.__vector_as_array<byte>(8); }
  public FlatData.ProductionStep ProductionStep { get { int o = __p.__offset(10); return o != 0 ? (FlatData.ProductionStep)__p.bb.GetInt(o + __p.bb_pos) : FlatData.ProductionStep.ToDo; } }
  public bool IsDefault { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool CollectionVisible { get { int o = __p.__offset(14); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string ReleaseDate { get { int o = __p.__offset(16); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetReleaseDateBytes() { return __p.__vector_as_span<byte>(16, 1); }
#else
  public ArraySegment<byte>? GetReleaseDateBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public byte[] GetReleaseDateArray() { return __p.__vector_as_array<byte>(16); }
  public string CollectionVisibleStartDate { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCollectionVisibleStartDateBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetCollectionVisibleStartDateBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetCollectionVisibleStartDateArray() { return __p.__vector_as_array<byte>(18); }
  public string CollectionVisibleEndDate { get { int o = __p.__offset(20); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCollectionVisibleEndDateBytes() { return __p.__vector_as_span<byte>(20, 1); }
#else
  public ArraySegment<byte>? GetCollectionVisibleEndDateBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public byte[] GetCollectionVisibleEndDateArray() { return __p.__vector_as_array<byte>(20); }
  public FlatData.Rarity Rarity { get { int o = __p.__offset(22); return o != 0 ? (FlatData.Rarity)__p.bb.GetInt(o + __p.bb_pos) : FlatData.Rarity.N; } }
  public long CharacterSkillListGroupId { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string SpineResourceName { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSpineResourceNameBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetSpineResourceNameBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetSpineResourceNameArray() { return __p.__vector_as_array<byte>(26); }
  public string SpineResourceNameDiorama { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSpineResourceNameDioramaBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetSpineResourceNameDioramaBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetSpineResourceNameDioramaArray() { return __p.__vector_as_array<byte>(28); }
  public string SpineResourceNameDioramaForFormConversion(int j) { int o = __p.__offset(30); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int SpineResourceNameDioramaForFormConversionLength { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
  public FlatData.EntityMaterialType EntityMaterialType { get { int o = __p.__offset(32); return o != 0 ? (FlatData.EntityMaterialType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.EntityMaterialType.Wood; } }
  public string ModelPrefabName { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetModelPrefabNameBytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetModelPrefabNameBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetModelPrefabNameArray() { return __p.__vector_as_array<byte>(34); }
  public string CafeModelPrefabName { get { int o = __p.__offset(36); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCafeModelPrefabNameBytes() { return __p.__vector_as_span<byte>(36, 1); }
#else
  public ArraySegment<byte>? GetCafeModelPrefabNameBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public byte[] GetCafeModelPrefabNameArray() { return __p.__vector_as_array<byte>(36); }
  public string EchelonModelPrefabName { get { int o = __p.__offset(38); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEchelonModelPrefabNameBytes() { return __p.__vector_as_span<byte>(38, 1); }
#else
  public ArraySegment<byte>? GetEchelonModelPrefabNameBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public byte[] GetEchelonModelPrefabNameArray() { return __p.__vector_as_array<byte>(38); }
  public string StrategyModelPrefabName { get { int o = __p.__offset(40); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetStrategyModelPrefabNameBytes() { return __p.__vector_as_span<byte>(40, 1); }
#else
  public ArraySegment<byte>? GetStrategyModelPrefabNameBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public byte[] GetStrategyModelPrefabNameArray() { return __p.__vector_as_array<byte>(40); }
  public string TextureDir { get { int o = __p.__offset(42); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTextureDirBytes() { return __p.__vector_as_span<byte>(42, 1); }
#else
  public ArraySegment<byte>? GetTextureDirBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public byte[] GetTextureDirArray() { return __p.__vector_as_array<byte>(42); }
  public string CollectionTexturePath { get { int o = __p.__offset(44); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCollectionTexturePathBytes() { return __p.__vector_as_span<byte>(44, 1); }
#else
  public ArraySegment<byte>? GetCollectionTexturePathBytes() { return __p.__vector_as_arraysegment(44); }
#endif
  public byte[] GetCollectionTexturePathArray() { return __p.__vector_as_array<byte>(44); }
  public string CollectionBGTexturePath { get { int o = __p.__offset(46); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCollectionBGTexturePathBytes() { return __p.__vector_as_span<byte>(46, 1); }
#else
  public ArraySegment<byte>? GetCollectionBGTexturePathBytes() { return __p.__vector_as_arraysegment(46); }
#endif
  public byte[] GetCollectionBGTexturePathArray() { return __p.__vector_as_array<byte>(46); }
  public bool UseObjectHPBAR { get { int o = __p.__offset(48); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string TextureBoss { get { int o = __p.__offset(50); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTextureBossBytes() { return __p.__vector_as_span<byte>(50, 1); }
#else
  public ArraySegment<byte>? GetTextureBossBytes() { return __p.__vector_as_arraysegment(50); }
#endif
  public byte[] GetTextureBossArray() { return __p.__vector_as_array<byte>(50); }
  public string TextureSkillCard(int j) { int o = __p.__offset(52); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int TextureSkillCardLength { get { int o = __p.__offset(52); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string InformationPacel { get { int o = __p.__offset(54); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetInformationPacelBytes() { return __p.__vector_as_span<byte>(54, 1); }
#else
  public ArraySegment<byte>? GetInformationPacelBytes() { return __p.__vector_as_arraysegment(54); }
#endif
  public byte[] GetInformationPacelArray() { return __p.__vector_as_array<byte>(54); }
  public string AnimationSSR { get { int o = __p.__offset(56); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAnimationSSRBytes() { return __p.__vector_as_span<byte>(56, 1); }
#else
  public ArraySegment<byte>? GetAnimationSSRBytes() { return __p.__vector_as_arraysegment(56); }
#endif
  public byte[] GetAnimationSSRArray() { return __p.__vector_as_array<byte>(56); }
  public string EnterStrategyAnimationName { get { int o = __p.__offset(58); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEnterStrategyAnimationNameBytes() { return __p.__vector_as_span<byte>(58, 1); }
#else
  public ArraySegment<byte>? GetEnterStrategyAnimationNameBytes() { return __p.__vector_as_arraysegment(58); }
#endif
  public byte[] GetEnterStrategyAnimationNameArray() { return __p.__vector_as_array<byte>(58); }
  public bool AnimationValidator { get { int o = __p.__offset(60); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long CharacterVoiceGroupId { get { int o = __p.__offset(62); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatData.CostumeExcel> CreateCostumeExcel(FlatBufferBuilder builder,
      long CostumeGroupId = 0,
      long CostumeUniqueId = 0,
      StringOffset DevNameOffset = default(StringOffset),
      FlatData.ProductionStep ProductionStep = FlatData.ProductionStep.ToDo,
      bool IsDefault = false,
      bool CollectionVisible = false,
      StringOffset ReleaseDateOffset = default(StringOffset),
      StringOffset CollectionVisibleStartDateOffset = default(StringOffset),
      StringOffset CollectionVisibleEndDateOffset = default(StringOffset),
      FlatData.Rarity Rarity = FlatData.Rarity.N,
      long CharacterSkillListGroupId = 0,
      StringOffset SpineResourceNameOffset = default(StringOffset),
      StringOffset SpineResourceNameDioramaOffset = default(StringOffset),
      VectorOffset SpineResourceNameDioramaForFormConversionOffset = default(VectorOffset),
      FlatData.EntityMaterialType EntityMaterialType = FlatData.EntityMaterialType.Wood,
      StringOffset ModelPrefabNameOffset = default(StringOffset),
      StringOffset CafeModelPrefabNameOffset = default(StringOffset),
      StringOffset EchelonModelPrefabNameOffset = default(StringOffset),
      StringOffset StrategyModelPrefabNameOffset = default(StringOffset),
      StringOffset TextureDirOffset = default(StringOffset),
      StringOffset CollectionTexturePathOffset = default(StringOffset),
      StringOffset CollectionBGTexturePathOffset = default(StringOffset),
      bool UseObjectHPBAR = false,
      StringOffset TextureBossOffset = default(StringOffset),
      VectorOffset TextureSkillCardOffset = default(VectorOffset),
      StringOffset InformationPacelOffset = default(StringOffset),
      StringOffset AnimationSSROffset = default(StringOffset),
      StringOffset EnterStrategyAnimationNameOffset = default(StringOffset),
      bool AnimationValidator = false,
      long CharacterVoiceGroupId = 0) {
    builder.StartTable(30);
    CostumeExcel.AddCharacterVoiceGroupId(builder, CharacterVoiceGroupId);
    CostumeExcel.AddCharacterSkillListGroupId(builder, CharacterSkillListGroupId);
    CostumeExcel.AddCostumeUniqueId(builder, CostumeUniqueId);
    CostumeExcel.AddCostumeGroupId(builder, CostumeGroupId);
    CostumeExcel.AddEnterStrategyAnimationName(builder, EnterStrategyAnimationNameOffset);
    CostumeExcel.AddAnimationSSR(builder, AnimationSSROffset);
    CostumeExcel.AddInformationPacel(builder, InformationPacelOffset);
    CostumeExcel.AddTextureSkillCard(builder, TextureSkillCardOffset);
    CostumeExcel.AddTextureBoss(builder, TextureBossOffset);
    CostumeExcel.AddCollectionBGTexturePath(builder, CollectionBGTexturePathOffset);
    CostumeExcel.AddCollectionTexturePath(builder, CollectionTexturePathOffset);
    CostumeExcel.AddTextureDir(builder, TextureDirOffset);
    CostumeExcel.AddStrategyModelPrefabName(builder, StrategyModelPrefabNameOffset);
    CostumeExcel.AddEchelonModelPrefabName(builder, EchelonModelPrefabNameOffset);
    CostumeExcel.AddCafeModelPrefabName(builder, CafeModelPrefabNameOffset);
    CostumeExcel.AddModelPrefabName(builder, ModelPrefabNameOffset);
    CostumeExcel.AddEntityMaterialType(builder, EntityMaterialType);
    CostumeExcel.AddSpineResourceNameDioramaForFormConversion(builder, SpineResourceNameDioramaForFormConversionOffset);
    CostumeExcel.AddSpineResourceNameDiorama(builder, SpineResourceNameDioramaOffset);
    CostumeExcel.AddSpineResourceName(builder, SpineResourceNameOffset);
    CostumeExcel.AddRarity(builder, Rarity);
    CostumeExcel.AddCollectionVisibleEndDate(builder, CollectionVisibleEndDateOffset);
    CostumeExcel.AddCollectionVisibleStartDate(builder, CollectionVisibleStartDateOffset);
    CostumeExcel.AddReleaseDate(builder, ReleaseDateOffset);
    CostumeExcel.AddProductionStep(builder, ProductionStep);
    CostumeExcel.AddDevName(builder, DevNameOffset);
    CostumeExcel.AddAnimationValidator(builder, AnimationValidator);
    CostumeExcel.AddUseObjectHPBAR(builder, UseObjectHPBAR);
    CostumeExcel.AddCollectionVisible(builder, CollectionVisible);
    CostumeExcel.AddIsDefault(builder, IsDefault);
    return CostumeExcel.EndCostumeExcel(builder);
  }

  public static void StartCostumeExcel(FlatBufferBuilder builder) { builder.StartTable(30); }
  public static void AddCostumeGroupId(FlatBufferBuilder builder, long costumeGroupId) { builder.AddLong(0, costumeGroupId, 0); }
  public static void AddCostumeUniqueId(FlatBufferBuilder builder, long costumeUniqueId) { builder.AddLong(1, costumeUniqueId, 0); }
  public static void AddDevName(FlatBufferBuilder builder, StringOffset devNameOffset) { builder.AddOffset(2, devNameOffset.Value, 0); }
  public static void AddProductionStep(FlatBufferBuilder builder, FlatData.ProductionStep productionStep) { builder.AddInt(3, (int)productionStep, 0); }
  public static void AddIsDefault(FlatBufferBuilder builder, bool isDefault) { builder.AddBool(4, isDefault, false); }
  public static void AddCollectionVisible(FlatBufferBuilder builder, bool collectionVisible) { builder.AddBool(5, collectionVisible, false); }
  public static void AddReleaseDate(FlatBufferBuilder builder, StringOffset releaseDateOffset) { builder.AddOffset(6, releaseDateOffset.Value, 0); }
  public static void AddCollectionVisibleStartDate(FlatBufferBuilder builder, StringOffset collectionVisibleStartDateOffset) { builder.AddOffset(7, collectionVisibleStartDateOffset.Value, 0); }
  public static void AddCollectionVisibleEndDate(FlatBufferBuilder builder, StringOffset collectionVisibleEndDateOffset) { builder.AddOffset(8, collectionVisibleEndDateOffset.Value, 0); }
  public static void AddRarity(FlatBufferBuilder builder, FlatData.Rarity rarity) { builder.AddInt(9, (int)rarity, 0); }
  public static void AddCharacterSkillListGroupId(FlatBufferBuilder builder, long characterSkillListGroupId) { builder.AddLong(10, characterSkillListGroupId, 0); }
  public static void AddSpineResourceName(FlatBufferBuilder builder, StringOffset spineResourceNameOffset) { builder.AddOffset(11, spineResourceNameOffset.Value, 0); }
  public static void AddSpineResourceNameDiorama(FlatBufferBuilder builder, StringOffset spineResourceNameDioramaOffset) { builder.AddOffset(12, spineResourceNameDioramaOffset.Value, 0); }
  public static void AddSpineResourceNameDioramaForFormConversion(FlatBufferBuilder builder, VectorOffset spineResourceNameDioramaForFormConversionOffset) { builder.AddOffset(13, spineResourceNameDioramaForFormConversionOffset.Value, 0); }
  public static VectorOffset CreateSpineResourceNameDioramaForFormConversionVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateSpineResourceNameDioramaForFormConversionVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSpineResourceNameDioramaForFormConversionVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSpineResourceNameDioramaForFormConversionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSpineResourceNameDioramaForFormConversionVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEntityMaterialType(FlatBufferBuilder builder, FlatData.EntityMaterialType entityMaterialType) { builder.AddInt(14, (int)entityMaterialType, 0); }
  public static void AddModelPrefabName(FlatBufferBuilder builder, StringOffset modelPrefabNameOffset) { builder.AddOffset(15, modelPrefabNameOffset.Value, 0); }
  public static void AddCafeModelPrefabName(FlatBufferBuilder builder, StringOffset cafeModelPrefabNameOffset) { builder.AddOffset(16, cafeModelPrefabNameOffset.Value, 0); }
  public static void AddEchelonModelPrefabName(FlatBufferBuilder builder, StringOffset echelonModelPrefabNameOffset) { builder.AddOffset(17, echelonModelPrefabNameOffset.Value, 0); }
  public static void AddStrategyModelPrefabName(FlatBufferBuilder builder, StringOffset strategyModelPrefabNameOffset) { builder.AddOffset(18, strategyModelPrefabNameOffset.Value, 0); }
  public static void AddTextureDir(FlatBufferBuilder builder, StringOffset textureDirOffset) { builder.AddOffset(19, textureDirOffset.Value, 0); }
  public static void AddCollectionTexturePath(FlatBufferBuilder builder, StringOffset collectionTexturePathOffset) { builder.AddOffset(20, collectionTexturePathOffset.Value, 0); }
  public static void AddCollectionBGTexturePath(FlatBufferBuilder builder, StringOffset collectionBGTexturePathOffset) { builder.AddOffset(21, collectionBGTexturePathOffset.Value, 0); }
  public static void AddUseObjectHPBAR(FlatBufferBuilder builder, bool useObjectHPBAR) { builder.AddBool(22, useObjectHPBAR, false); }
  public static void AddTextureBoss(FlatBufferBuilder builder, StringOffset textureBossOffset) { builder.AddOffset(23, textureBossOffset.Value, 0); }
  public static void AddTextureSkillCard(FlatBufferBuilder builder, VectorOffset textureSkillCardOffset) { builder.AddOffset(24, textureSkillCardOffset.Value, 0); }
  public static VectorOffset CreateTextureSkillCardVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateTextureSkillCardVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTextureSkillCardVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTextureSkillCardVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTextureSkillCardVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddInformationPacel(FlatBufferBuilder builder, StringOffset informationPacelOffset) { builder.AddOffset(25, informationPacelOffset.Value, 0); }
  public static void AddAnimationSSR(FlatBufferBuilder builder, StringOffset animationSSROffset) { builder.AddOffset(26, animationSSROffset.Value, 0); }
  public static void AddEnterStrategyAnimationName(FlatBufferBuilder builder, StringOffset enterStrategyAnimationNameOffset) { builder.AddOffset(27, enterStrategyAnimationNameOffset.Value, 0); }
  public static void AddAnimationValidator(FlatBufferBuilder builder, bool animationValidator) { builder.AddBool(28, animationValidator, false); }
  public static void AddCharacterVoiceGroupId(FlatBufferBuilder builder, long characterVoiceGroupId) { builder.AddLong(29, characterVoiceGroupId, 0); }
  public static Offset<FlatData.CostumeExcel> EndCostumeExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.CostumeExcel>(o);
  }
  public CostumeExcelT UnPack() {
    var _o = new CostumeExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CostumeExcelT _o) {
    _o.CostumeGroupId = this.CostumeGroupId;
    _o.CostumeUniqueId = this.CostumeUniqueId;
    _o.DevName = this.DevName;
    _o.ProductionStep = this.ProductionStep;
    _o.IsDefault = this.IsDefault;
    _o.CollectionVisible = this.CollectionVisible;
    _o.ReleaseDate = this.ReleaseDate;
    _o.CollectionVisibleStartDate = this.CollectionVisibleStartDate;
    _o.CollectionVisibleEndDate = this.CollectionVisibleEndDate;
    _o.Rarity = this.Rarity;
    _o.CharacterSkillListGroupId = this.CharacterSkillListGroupId;
    _o.SpineResourceName = this.SpineResourceName;
    _o.SpineResourceNameDiorama = this.SpineResourceNameDiorama;
    _o.SpineResourceNameDioramaForFormConversion = new List<string>();
    for (var _j = 0; _j < this.SpineResourceNameDioramaForFormConversionLength; ++_j) {_o.SpineResourceNameDioramaForFormConversion.Add(this.SpineResourceNameDioramaForFormConversion(_j));}
    _o.EntityMaterialType = this.EntityMaterialType;
    _o.ModelPrefabName = this.ModelPrefabName;
    _o.CafeModelPrefabName = this.CafeModelPrefabName;
    _o.EchelonModelPrefabName = this.EchelonModelPrefabName;
    _o.StrategyModelPrefabName = this.StrategyModelPrefabName;
    _o.TextureDir = this.TextureDir;
    _o.CollectionTexturePath = this.CollectionTexturePath;
    _o.CollectionBGTexturePath = this.CollectionBGTexturePath;
    _o.UseObjectHPBAR = this.UseObjectHPBAR;
    _o.TextureBoss = this.TextureBoss;
    _o.TextureSkillCard = new List<string>();
    for (var _j = 0; _j < this.TextureSkillCardLength; ++_j) {_o.TextureSkillCard.Add(this.TextureSkillCard(_j));}
    _o.InformationPacel = this.InformationPacel;
    _o.AnimationSSR = this.AnimationSSR;
    _o.EnterStrategyAnimationName = this.EnterStrategyAnimationName;
    _o.AnimationValidator = this.AnimationValidator;
    _o.CharacterVoiceGroupId = this.CharacterVoiceGroupId;
  }
  public static Offset<FlatData.CostumeExcel> Pack(FlatBufferBuilder builder, CostumeExcelT _o) {
    if (_o == null) return default(Offset<FlatData.CostumeExcel>);
    var _DevName = _o.DevName == null ? default(StringOffset) : builder.CreateString(_o.DevName);
    var _ReleaseDate = _o.ReleaseDate == null ? default(StringOffset) : builder.CreateString(_o.ReleaseDate);
    var _CollectionVisibleStartDate = _o.CollectionVisibleStartDate == null ? default(StringOffset) : builder.CreateString(_o.CollectionVisibleStartDate);
    var _CollectionVisibleEndDate = _o.CollectionVisibleEndDate == null ? default(StringOffset) : builder.CreateString(_o.CollectionVisibleEndDate);
    var _SpineResourceName = _o.SpineResourceName == null ? default(StringOffset) : builder.CreateString(_o.SpineResourceName);
    var _SpineResourceNameDiorama = _o.SpineResourceNameDiorama == null ? default(StringOffset) : builder.CreateString(_o.SpineResourceNameDiorama);
    var _SpineResourceNameDioramaForFormConversion = default(VectorOffset);
    if (_o.SpineResourceNameDioramaForFormConversion != null) {
      var __SpineResourceNameDioramaForFormConversion = new StringOffset[_o.SpineResourceNameDioramaForFormConversion.Count];
      for (var _j = 0; _j < __SpineResourceNameDioramaForFormConversion.Length; ++_j) { __SpineResourceNameDioramaForFormConversion[_j] = builder.CreateString(_o.SpineResourceNameDioramaForFormConversion[_j]); }
      _SpineResourceNameDioramaForFormConversion = CreateSpineResourceNameDioramaForFormConversionVector(builder, __SpineResourceNameDioramaForFormConversion);
    }
    var _ModelPrefabName = _o.ModelPrefabName == null ? default(StringOffset) : builder.CreateString(_o.ModelPrefabName);
    var _CafeModelPrefabName = _o.CafeModelPrefabName == null ? default(StringOffset) : builder.CreateString(_o.CafeModelPrefabName);
    var _EchelonModelPrefabName = _o.EchelonModelPrefabName == null ? default(StringOffset) : builder.CreateString(_o.EchelonModelPrefabName);
    var _StrategyModelPrefabName = _o.StrategyModelPrefabName == null ? default(StringOffset) : builder.CreateString(_o.StrategyModelPrefabName);
    var _TextureDir = _o.TextureDir == null ? default(StringOffset) : builder.CreateString(_o.TextureDir);
    var _CollectionTexturePath = _o.CollectionTexturePath == null ? default(StringOffset) : builder.CreateString(_o.CollectionTexturePath);
    var _CollectionBGTexturePath = _o.CollectionBGTexturePath == null ? default(StringOffset) : builder.CreateString(_o.CollectionBGTexturePath);
    var _TextureBoss = _o.TextureBoss == null ? default(StringOffset) : builder.CreateString(_o.TextureBoss);
    var _TextureSkillCard = default(VectorOffset);
    if (_o.TextureSkillCard != null) {
      var __TextureSkillCard = new StringOffset[_o.TextureSkillCard.Count];
      for (var _j = 0; _j < __TextureSkillCard.Length; ++_j) { __TextureSkillCard[_j] = builder.CreateString(_o.TextureSkillCard[_j]); }
      _TextureSkillCard = CreateTextureSkillCardVector(builder, __TextureSkillCard);
    }
    var _InformationPacel = _o.InformationPacel == null ? default(StringOffset) : builder.CreateString(_o.InformationPacel);
    var _AnimationSSR = _o.AnimationSSR == null ? default(StringOffset) : builder.CreateString(_o.AnimationSSR);
    var _EnterStrategyAnimationName = _o.EnterStrategyAnimationName == null ? default(StringOffset) : builder.CreateString(_o.EnterStrategyAnimationName);
    return CreateCostumeExcel(
      builder,
      _o.CostumeGroupId,
      _o.CostumeUniqueId,
      _DevName,
      _o.ProductionStep,
      _o.IsDefault,
      _o.CollectionVisible,
      _ReleaseDate,
      _CollectionVisibleStartDate,
      _CollectionVisibleEndDate,
      _o.Rarity,
      _o.CharacterSkillListGroupId,
      _SpineResourceName,
      _SpineResourceNameDiorama,
      _SpineResourceNameDioramaForFormConversion,
      _o.EntityMaterialType,
      _ModelPrefabName,
      _CafeModelPrefabName,
      _EchelonModelPrefabName,
      _StrategyModelPrefabName,
      _TextureDir,
      _CollectionTexturePath,
      _CollectionBGTexturePath,
      _o.UseObjectHPBAR,
      _TextureBoss,
      _TextureSkillCard,
      _InformationPacel,
      _AnimationSSR,
      _EnterStrategyAnimationName,
      _o.AnimationValidator,
      _o.CharacterVoiceGroupId);
  }
}

public class CostumeExcelT
{
  [Newtonsoft.Json.JsonProperty("CostumeGroupId")]
  public long CostumeGroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("CostumeUniqueId")]
  public long CostumeUniqueId { get; set; }
  [Newtonsoft.Json.JsonProperty("DevName")]
  public string DevName { get; set; }
  [Newtonsoft.Json.JsonProperty("ProductionStep")]
  public FlatData.ProductionStep ProductionStep { get; set; }
  [Newtonsoft.Json.JsonProperty("IsDefault")]
  public bool IsDefault { get; set; }
  [Newtonsoft.Json.JsonProperty("CollectionVisible")]
  public bool CollectionVisible { get; set; }
  [Newtonsoft.Json.JsonProperty("ReleaseDate")]
  public string ReleaseDate { get; set; }
  [Newtonsoft.Json.JsonProperty("CollectionVisibleStartDate")]
  public string CollectionVisibleStartDate { get; set; }
  [Newtonsoft.Json.JsonProperty("CollectionVisibleEndDate")]
  public string CollectionVisibleEndDate { get; set; }
  [Newtonsoft.Json.JsonProperty("Rarity")]
  public FlatData.Rarity Rarity { get; set; }
  [Newtonsoft.Json.JsonProperty("CharacterSkillListGroupId")]
  public long CharacterSkillListGroupId { get; set; }
  [Newtonsoft.Json.JsonProperty("SpineResourceName")]
  public string SpineResourceName { get; set; }
  [Newtonsoft.Json.JsonProperty("SpineResourceNameDiorama")]
  public string SpineResourceNameDiorama { get; set; }
  [Newtonsoft.Json.JsonProperty("SpineResourceNameDioramaForFormConversion")]
  public List<string> SpineResourceNameDioramaForFormConversion { get; set; }
  [Newtonsoft.Json.JsonProperty("EntityMaterialType")]
  public FlatData.EntityMaterialType EntityMaterialType { get; set; }
  [Newtonsoft.Json.JsonProperty("ModelPrefabName")]
  public string ModelPrefabName { get; set; }
  [Newtonsoft.Json.JsonProperty("CafeModelPrefabName")]
  public string CafeModelPrefabName { get; set; }
  [Newtonsoft.Json.JsonProperty("EchelonModelPrefabName")]
  public string EchelonModelPrefabName { get; set; }
  [Newtonsoft.Json.JsonProperty("StrategyModelPrefabName")]
  public string StrategyModelPrefabName { get; set; }
  [Newtonsoft.Json.JsonProperty("TextureDir")]
  public string TextureDir { get; set; }
  [Newtonsoft.Json.JsonProperty("CollectionTexturePath")]
  public string CollectionTexturePath { get; set; }
  [Newtonsoft.Json.JsonProperty("CollectionBGTexturePath")]
  public string CollectionBGTexturePath { get; set; }
  [Newtonsoft.Json.JsonProperty("UseObjectHPBAR")]
  public bool UseObjectHPBAR { get; set; }
  [Newtonsoft.Json.JsonProperty("TextureBoss")]
  public string TextureBoss { get; set; }
  [Newtonsoft.Json.JsonProperty("TextureSkillCard")]
  public List<string> TextureSkillCard { get; set; }
  [Newtonsoft.Json.JsonProperty("InformationPacel")]
  public string InformationPacel { get; set; }
  [Newtonsoft.Json.JsonProperty("AnimationSSR")]
  public string AnimationSSR { get; set; }
  [Newtonsoft.Json.JsonProperty("EnterStrategyAnimationName")]
  public string EnterStrategyAnimationName { get; set; }
  [Newtonsoft.Json.JsonProperty("AnimationValidator")]
  public bool AnimationValidator { get; set; }
  [Newtonsoft.Json.JsonProperty("CharacterVoiceGroupId")]
  public long CharacterVoiceGroupId { get; set; }

  public CostumeExcelT() {
    this.CostumeGroupId = 0;
    this.CostumeUniqueId = 0;
    this.DevName = null;
    this.ProductionStep = FlatData.ProductionStep.ToDo;
    this.IsDefault = false;
    this.CollectionVisible = false;
    this.ReleaseDate = null;
    this.CollectionVisibleStartDate = null;
    this.CollectionVisibleEndDate = null;
    this.Rarity = FlatData.Rarity.N;
    this.CharacterSkillListGroupId = 0;
    this.SpineResourceName = null;
    this.SpineResourceNameDiorama = null;
    this.SpineResourceNameDioramaForFormConversion = null;
    this.EntityMaterialType = FlatData.EntityMaterialType.Wood;
    this.ModelPrefabName = null;
    this.CafeModelPrefabName = null;
    this.EchelonModelPrefabName = null;
    this.StrategyModelPrefabName = null;
    this.TextureDir = null;
    this.CollectionTexturePath = null;
    this.CollectionBGTexturePath = null;
    this.UseObjectHPBAR = false;
    this.TextureBoss = null;
    this.TextureSkillCard = null;
    this.InformationPacel = null;
    this.AnimationSSR = null;
    this.EnterStrategyAnimationName = null;
    this.AnimationValidator = false;
    this.CharacterVoiceGroupId = 0;
  }
}


static public class CostumeExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*CostumeGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*CostumeUniqueId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 8 /*DevName*/, false)
      && verifier.VerifyField(tablePos, 10 /*ProductionStep*/, 4 /*FlatData.ProductionStep*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*IsDefault*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 14 /*CollectionVisible*/, 1 /*bool*/, 1, false)
      && verifier.VerifyString(tablePos, 16 /*ReleaseDate*/, false)
      && verifier.VerifyString(tablePos, 18 /*CollectionVisibleStartDate*/, false)
      && verifier.VerifyString(tablePos, 20 /*CollectionVisibleEndDate*/, false)
      && verifier.VerifyField(tablePos, 22 /*Rarity*/, 4 /*FlatData.Rarity*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*CharacterSkillListGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 26 /*SpineResourceName*/, false)
      && verifier.VerifyString(tablePos, 28 /*SpineResourceNameDiorama*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 30 /*SpineResourceNameDioramaForFormConversion*/, false)
      && verifier.VerifyField(tablePos, 32 /*EntityMaterialType*/, 4 /*FlatData.EntityMaterialType*/, 4, false)
      && verifier.VerifyString(tablePos, 34 /*ModelPrefabName*/, false)
      && verifier.VerifyString(tablePos, 36 /*CafeModelPrefabName*/, false)
      && verifier.VerifyString(tablePos, 38 /*EchelonModelPrefabName*/, false)
      && verifier.VerifyString(tablePos, 40 /*StrategyModelPrefabName*/, false)
      && verifier.VerifyString(tablePos, 42 /*TextureDir*/, false)
      && verifier.VerifyString(tablePos, 44 /*CollectionTexturePath*/, false)
      && verifier.VerifyString(tablePos, 46 /*CollectionBGTexturePath*/, false)
      && verifier.VerifyField(tablePos, 48 /*UseObjectHPBAR*/, 1 /*bool*/, 1, false)
      && verifier.VerifyString(tablePos, 50 /*TextureBoss*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 52 /*TextureSkillCard*/, false)
      && verifier.VerifyString(tablePos, 54 /*InformationPacel*/, false)
      && verifier.VerifyString(tablePos, 56 /*AnimationSSR*/, false)
      && verifier.VerifyString(tablePos, 58 /*EnterStrategyAnimationName*/, false)
      && verifier.VerifyField(tablePos, 60 /*AnimationValidator*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 62 /*CharacterVoiceGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}