// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct EquipmentExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EquipmentExcel GetRootAsEquipmentExcel(ByteBuffer _bb) { return GetRootAsEquipmentExcel(_bb, new EquipmentExcel()); }
  public static EquipmentExcel GetRootAsEquipmentExcel(ByteBuffer _bb, EquipmentExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EquipmentExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.EquipmentCategory EquipmentCategory { get { int o = __p.__offset(6); return o != 0 ? (FlatData.EquipmentCategory)__p.bb.GetInt(o + __p.bb_pos) : FlatData.EquipmentCategory.Unable; } }
  public FlatData.Rarity Rarity { get { int o = __p.__offset(8); return o != 0 ? (FlatData.Rarity)__p.bb.GetInt(o + __p.bb_pos) : FlatData.Rarity.N; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public bool Wear { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int MaxLevel { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RecipeId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long TierInit { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long NextTierEquipment { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int StackableMax { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Icon { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconBytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetIconBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetIconArray() { return __p.__vector_as_array<byte>(24); }
  public string ImageName { get { int o = __p.__offset(26); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetImageNameBytes() { return __p.__vector_as_span<byte>(26, 1); }
#else
  public ArraySegment<byte>? GetImageNameBytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public byte[] GetImageNameArray() { return __p.__vector_as_array<byte>(26); }
  public FlatData.Tag Tags(int j) { int o = __p.__offset(28); return o != 0 ? (FlatData.Tag)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatData.Tag)0; }
  public int TagsLength { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatData.Tag> GetTagsBytes() { return __p.__vector_as_span<FlatData.Tag>(28, 4); }
#else
  public ArraySegment<byte>? GetTagsBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public FlatData.Tag[] GetTagsArray() { int o = __p.__offset(28); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatData.Tag[] a = new FlatData.Tag[l]; for (int i = 0; i < l; i++) { a[i] = (FlatData.Tag)__p.bb.GetInt(p + i * 4); } return a; }
  public long CraftQualityTier0 { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CraftQualityTier1 { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CraftQualityTier2 { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ShiftingCraftQuality { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.ShopCategoryType ShopCategory(int j) { int o = __p.__offset(38); return o != 0 ? (FlatData.ShopCategoryType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (FlatData.ShopCategoryType)0; }
  public int ShopCategoryLength { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<FlatData.ShopCategoryType> GetShopCategoryBytes() { return __p.__vector_as_span<FlatData.ShopCategoryType>(38, 4); }
#else
  public ArraySegment<byte>? GetShopCategoryBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public FlatData.ShopCategoryType[] GetShopCategoryArray() { int o = __p.__offset(38); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); FlatData.ShopCategoryType[] a = new FlatData.ShopCategoryType[l]; for (int i = 0; i < l; i++) { a[i] = (FlatData.ShopCategoryType)__p.bb.GetInt(p + i * 4); } return a; }
  public long ShortcutTypeId { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatData.EquipmentExcel> CreateEquipmentExcel(FlatBufferBuilder builder,
      long Id = 0,
      FlatData.EquipmentCategory EquipmentCategory = FlatData.EquipmentCategory.Unable,
      FlatData.Rarity Rarity = FlatData.Rarity.N,
      uint LocalizeEtcId = 0,
      bool Wear = false,
      int MaxLevel = 0,
      int RecipeId = 0,
      long TierInit = 0,
      long NextTierEquipment = 0,
      int StackableMax = 0,
      StringOffset IconOffset = default(StringOffset),
      StringOffset ImageNameOffset = default(StringOffset),
      VectorOffset TagsOffset = default(VectorOffset),
      long CraftQualityTier0 = 0,
      long CraftQualityTier1 = 0,
      long CraftQualityTier2 = 0,
      long ShiftingCraftQuality = 0,
      VectorOffset ShopCategoryOffset = default(VectorOffset),
      long ShortcutTypeId = 0) {
    builder.StartTable(19);
    EquipmentExcel.AddShortcutTypeId(builder, ShortcutTypeId);
    EquipmentExcel.AddShiftingCraftQuality(builder, ShiftingCraftQuality);
    EquipmentExcel.AddCraftQualityTier2(builder, CraftQualityTier2);
    EquipmentExcel.AddCraftQualityTier1(builder, CraftQualityTier1);
    EquipmentExcel.AddCraftQualityTier0(builder, CraftQualityTier0);
    EquipmentExcel.AddNextTierEquipment(builder, NextTierEquipment);
    EquipmentExcel.AddTierInit(builder, TierInit);
    EquipmentExcel.AddId(builder, Id);
    EquipmentExcel.AddShopCategory(builder, ShopCategoryOffset);
    EquipmentExcel.AddTags(builder, TagsOffset);
    EquipmentExcel.AddImageName(builder, ImageNameOffset);
    EquipmentExcel.AddIcon(builder, IconOffset);
    EquipmentExcel.AddStackableMax(builder, StackableMax);
    EquipmentExcel.AddRecipeId(builder, RecipeId);
    EquipmentExcel.AddMaxLevel(builder, MaxLevel);
    EquipmentExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    EquipmentExcel.AddRarity(builder, Rarity);
    EquipmentExcel.AddEquipmentCategory(builder, EquipmentCategory);
    EquipmentExcel.AddWear(builder, Wear);
    return EquipmentExcel.EndEquipmentExcel(builder);
  }

  public static void StartEquipmentExcel(FlatBufferBuilder builder) { builder.StartTable(19); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddEquipmentCategory(FlatBufferBuilder builder, FlatData.EquipmentCategory equipmentCategory) { builder.AddInt(1, (int)equipmentCategory, 0); }
  public static void AddRarity(FlatBufferBuilder builder, FlatData.Rarity rarity) { builder.AddInt(2, (int)rarity, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(3, localizeEtcId, 0); }
  public static void AddWear(FlatBufferBuilder builder, bool wear) { builder.AddBool(4, wear, false); }
  public static void AddMaxLevel(FlatBufferBuilder builder, int maxLevel) { builder.AddInt(5, maxLevel, 0); }
  public static void AddRecipeId(FlatBufferBuilder builder, int recipeId) { builder.AddInt(6, recipeId, 0); }
  public static void AddTierInit(FlatBufferBuilder builder, long tierInit) { builder.AddLong(7, tierInit, 0); }
  public static void AddNextTierEquipment(FlatBufferBuilder builder, long nextTierEquipment) { builder.AddLong(8, nextTierEquipment, 0); }
  public static void AddStackableMax(FlatBufferBuilder builder, int stackableMax) { builder.AddInt(9, stackableMax, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset) { builder.AddOffset(10, iconOffset.Value, 0); }
  public static void AddImageName(FlatBufferBuilder builder, StringOffset imageNameOffset) { builder.AddOffset(11, imageNameOffset.Value, 0); }
  public static void AddTags(FlatBufferBuilder builder, VectorOffset tagsOffset) { builder.AddOffset(12, tagsOffset.Value, 0); }
  public static VectorOffset CreateTagsVector(FlatBufferBuilder builder, FlatData.Tag[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, FlatData.Tag[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatData.Tag> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateTagsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatData.Tag>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartTagsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCraftQualityTier0(FlatBufferBuilder builder, long craftQualityTier0) { builder.AddLong(13, craftQualityTier0, 0); }
  public static void AddCraftQualityTier1(FlatBufferBuilder builder, long craftQualityTier1) { builder.AddLong(14, craftQualityTier1, 0); }
  public static void AddCraftQualityTier2(FlatBufferBuilder builder, long craftQualityTier2) { builder.AddLong(15, craftQualityTier2, 0); }
  public static void AddShiftingCraftQuality(FlatBufferBuilder builder, long shiftingCraftQuality) { builder.AddLong(16, shiftingCraftQuality, 0); }
  public static void AddShopCategory(FlatBufferBuilder builder, VectorOffset shopCategoryOffset) { builder.AddOffset(17, shopCategoryOffset.Value, 0); }
  public static VectorOffset CreateShopCategoryVector(FlatBufferBuilder builder, FlatData.ShopCategoryType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateShopCategoryVectorBlock(FlatBufferBuilder builder, FlatData.ShopCategoryType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShopCategoryVectorBlock(FlatBufferBuilder builder, ArraySegment<FlatData.ShopCategoryType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShopCategoryVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<FlatData.ShopCategoryType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartShopCategoryVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShortcutTypeId(FlatBufferBuilder builder, long shortcutTypeId) { builder.AddLong(18, shortcutTypeId, 0); }
  public static Offset<FlatData.EquipmentExcel> EndEquipmentExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.EquipmentExcel>(o);
  }
  public EquipmentExcelT UnPack() {
    var _o = new EquipmentExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EquipmentExcelT _o) {
    _o.Id = this.Id;
    _o.EquipmentCategory = this.EquipmentCategory;
    _o.Rarity = this.Rarity;
    _o.LocalizeEtcId = this.LocalizeEtcId;
    _o.Wear = this.Wear;
    _o.MaxLevel = this.MaxLevel;
    _o.RecipeId = this.RecipeId;
    _o.TierInit = this.TierInit;
    _o.NextTierEquipment = this.NextTierEquipment;
    _o.StackableMax = this.StackableMax;
    _o.Icon = this.Icon;
    _o.ImageName = this.ImageName;
    _o.Tags = new List<FlatData.Tag>();
    for (var _j = 0; _j < this.TagsLength; ++_j) {_o.Tags.Add(this.Tags(_j));}
    _o.CraftQualityTier0 = this.CraftQualityTier0;
    _o.CraftQualityTier1 = this.CraftQualityTier1;
    _o.CraftQualityTier2 = this.CraftQualityTier2;
    _o.ShiftingCraftQuality = this.ShiftingCraftQuality;
    _o.ShopCategory = new List<FlatData.ShopCategoryType>();
    for (var _j = 0; _j < this.ShopCategoryLength; ++_j) {_o.ShopCategory.Add(this.ShopCategory(_j));}
    _o.ShortcutTypeId = this.ShortcutTypeId;
  }
  public static Offset<FlatData.EquipmentExcel> Pack(FlatBufferBuilder builder, EquipmentExcelT _o) {
    if (_o == null) return default(Offset<FlatData.EquipmentExcel>);
    var _Icon = _o.Icon == null ? default(StringOffset) : builder.CreateString(_o.Icon);
    var _ImageName = _o.ImageName == null ? default(StringOffset) : builder.CreateString(_o.ImageName);
    var _Tags = default(VectorOffset);
    if (_o.Tags != null) {
      var __Tags = _o.Tags.ToArray();
      _Tags = CreateTagsVector(builder, __Tags);
    }
    var _ShopCategory = default(VectorOffset);
    if (_o.ShopCategory != null) {
      var __ShopCategory = _o.ShopCategory.ToArray();
      _ShopCategory = CreateShopCategoryVector(builder, __ShopCategory);
    }
    return CreateEquipmentExcel(
      builder,
      _o.Id,
      _o.EquipmentCategory,
      _o.Rarity,
      _o.LocalizeEtcId,
      _o.Wear,
      _o.MaxLevel,
      _o.RecipeId,
      _o.TierInit,
      _o.NextTierEquipment,
      _o.StackableMax,
      _Icon,
      _ImageName,
      _Tags,
      _o.CraftQualityTier0,
      _o.CraftQualityTier1,
      _o.CraftQualityTier2,
      _o.ShiftingCraftQuality,
      _ShopCategory,
      _o.ShortcutTypeId);
  }
}

public class EquipmentExcelT
{
  [Newtonsoft.Json.JsonProperty("Id")]
  public long Id { get; set; }
  [Newtonsoft.Json.JsonProperty("EquipmentCategory")]
  public FlatData.EquipmentCategory EquipmentCategory { get; set; }
  [Newtonsoft.Json.JsonProperty("Rarity")]
  public FlatData.Rarity Rarity { get; set; }
  [Newtonsoft.Json.JsonProperty("LocalizeEtcId")]
  public uint LocalizeEtcId { get; set; }
  [Newtonsoft.Json.JsonProperty("Wear")]
  public bool Wear { get; set; }
  [Newtonsoft.Json.JsonProperty("MaxLevel")]
  public int MaxLevel { get; set; }
  [Newtonsoft.Json.JsonProperty("RecipeId")]
  public int RecipeId { get; set; }
  [Newtonsoft.Json.JsonProperty("TierInit")]
  public long TierInit { get; set; }
  [Newtonsoft.Json.JsonProperty("NextTierEquipment")]
  public long NextTierEquipment { get; set; }
  [Newtonsoft.Json.JsonProperty("StackableMax")]
  public int StackableMax { get; set; }
  [Newtonsoft.Json.JsonProperty("Icon")]
  public string Icon { get; set; }
  [Newtonsoft.Json.JsonProperty("ImageName")]
  public string ImageName { get; set; }
  [Newtonsoft.Json.JsonProperty("Tags")]
  public List<FlatData.Tag> Tags { get; set; }
  [Newtonsoft.Json.JsonProperty("CraftQualityTier0")]
  public long CraftQualityTier0 { get; set; }
  [Newtonsoft.Json.JsonProperty("CraftQualityTier1")]
  public long CraftQualityTier1 { get; set; }
  [Newtonsoft.Json.JsonProperty("CraftQualityTier2")]
  public long CraftQualityTier2 { get; set; }
  [Newtonsoft.Json.JsonProperty("ShiftingCraftQuality")]
  public long ShiftingCraftQuality { get; set; }
  [Newtonsoft.Json.JsonProperty("ShopCategory")]
  public List<FlatData.ShopCategoryType> ShopCategory { get; set; }
  [Newtonsoft.Json.JsonProperty("ShortcutTypeId")]
  public long ShortcutTypeId { get; set; }

  public EquipmentExcelT() {
    this.Id = 0;
    this.EquipmentCategory = FlatData.EquipmentCategory.Unable;
    this.Rarity = FlatData.Rarity.N;
    this.LocalizeEtcId = 0;
    this.Wear = false;
    this.MaxLevel = 0;
    this.RecipeId = 0;
    this.TierInit = 0;
    this.NextTierEquipment = 0;
    this.StackableMax = 0;
    this.Icon = null;
    this.ImageName = null;
    this.Tags = null;
    this.CraftQualityTier0 = 0;
    this.CraftQualityTier1 = 0;
    this.CraftQualityTier2 = 0;
    this.ShiftingCraftQuality = 0;
    this.ShopCategory = null;
    this.ShortcutTypeId = 0;
  }
}


static public class EquipmentExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EquipmentCategory*/, 4 /*FlatData.EquipmentCategory*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Rarity*/, 4 /*FlatData.Rarity*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*Wear*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 14 /*MaxLevel*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*RecipeId*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*TierInit*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*NextTierEquipment*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 22 /*StackableMax*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 24 /*Icon*/, false)
      && verifier.VerifyString(tablePos, 26 /*ImageName*/, false)
      && verifier.VerifyVectorOfData(tablePos, 28 /*Tags*/, 4 /*FlatData.Tag*/, false)
      && verifier.VerifyField(tablePos, 30 /*CraftQualityTier0*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 32 /*CraftQualityTier1*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 34 /*CraftQualityTier2*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 36 /*ShiftingCraftQuality*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 38 /*ShopCategory*/, 4 /*FlatData.ShopCategoryType*/, false)
      && verifier.VerifyField(tablePos, 40 /*ShortcutTypeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
