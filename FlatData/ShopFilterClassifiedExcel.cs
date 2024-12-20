// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct ShopFilterClassifiedExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ShopFilterClassifiedExcel GetRootAsShopFilterClassifiedExcel(ByteBuffer _bb) { return GetRootAsShopFilterClassifiedExcel(_bb, new ShopFilterClassifiedExcel()); }
  public static ShopFilterClassifiedExcel GetRootAsShopFilterClassifiedExcel(ByteBuffer _bb, ShopFilterClassifiedExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ShopFilterClassifiedExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.ShopCategoryType CategoryType { get { int o = __p.__offset(6); return o != 0 ? (FlatData.ShopCategoryType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.ShopCategoryType.General; } }
  public FlatData.ParcelType ConsumeParcelType { get { int o = __p.__offset(8); return o != 0 ? (FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.ParcelType.None; } }
  public long ConsumeParcelId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public FlatData.ShopFilterType ShopFilterType { get { int o = __p.__offset(12); return o != 0 ? (FlatData.ShopFilterType)__p.bb.GetInt(o + __p.bb_pos) : FlatData.ShopFilterType.GachaTicket; } }
  public long GoodsId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<FlatData.ShopFilterClassifiedExcel> CreateShopFilterClassifiedExcel(FlatBufferBuilder builder,
      long Id = 0,
      FlatData.ShopCategoryType CategoryType = FlatData.ShopCategoryType.General,
      FlatData.ParcelType ConsumeParcelType = FlatData.ParcelType.None,
      long ConsumeParcelId = 0,
      FlatData.ShopFilterType ShopFilterType = FlatData.ShopFilterType.GachaTicket,
      long GoodsId = 0) {
    builder.StartTable(6);
    ShopFilterClassifiedExcel.AddGoodsId(builder, GoodsId);
    ShopFilterClassifiedExcel.AddConsumeParcelId(builder, ConsumeParcelId);
    ShopFilterClassifiedExcel.AddId(builder, Id);
    ShopFilterClassifiedExcel.AddShopFilterType(builder, ShopFilterType);
    ShopFilterClassifiedExcel.AddConsumeParcelType(builder, ConsumeParcelType);
    ShopFilterClassifiedExcel.AddCategoryType(builder, CategoryType);
    return ShopFilterClassifiedExcel.EndShopFilterClassifiedExcel(builder);
  }

  public static void StartShopFilterClassifiedExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddCategoryType(FlatBufferBuilder builder, FlatData.ShopCategoryType categoryType) { builder.AddInt(1, (int)categoryType, 0); }
  public static void AddConsumeParcelType(FlatBufferBuilder builder, FlatData.ParcelType consumeParcelType) { builder.AddInt(2, (int)consumeParcelType, 0); }
  public static void AddConsumeParcelId(FlatBufferBuilder builder, long consumeParcelId) { builder.AddLong(3, consumeParcelId, 0); }
  public static void AddShopFilterType(FlatBufferBuilder builder, FlatData.ShopFilterType shopFilterType) { builder.AddInt(4, (int)shopFilterType, 0); }
  public static void AddGoodsId(FlatBufferBuilder builder, long goodsId) { builder.AddLong(5, goodsId, 0); }
  public static Offset<FlatData.ShopFilterClassifiedExcel> EndShopFilterClassifiedExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatData.ShopFilterClassifiedExcel>(o);
  }
  public ShopFilterClassifiedExcelT UnPack() {
    var _o = new ShopFilterClassifiedExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ShopFilterClassifiedExcelT _o) {
    _o.Id = this.Id;
    _o.CategoryType = this.CategoryType;
    _o.ConsumeParcelType = this.ConsumeParcelType;
    _o.ConsumeParcelId = this.ConsumeParcelId;
    _o.ShopFilterType = this.ShopFilterType;
    _o.GoodsId = this.GoodsId;
  }
  public static Offset<FlatData.ShopFilterClassifiedExcel> Pack(FlatBufferBuilder builder, ShopFilterClassifiedExcelT _o) {
    if (_o == null) return default(Offset<FlatData.ShopFilterClassifiedExcel>);
    return CreateShopFilterClassifiedExcel(
      builder,
      _o.Id,
      _o.CategoryType,
      _o.ConsumeParcelType,
      _o.ConsumeParcelId,
      _o.ShopFilterType,
      _o.GoodsId);
  }
}

public class ShopFilterClassifiedExcelT
{
  [Newtonsoft.Json.JsonProperty("Id")]
  public long Id { get; set; }
  [Newtonsoft.Json.JsonProperty("CategoryType")]
  public FlatData.ShopCategoryType CategoryType { get; set; }
  [Newtonsoft.Json.JsonProperty("ConsumeParcelType")]
  public FlatData.ParcelType ConsumeParcelType { get; set; }
  [Newtonsoft.Json.JsonProperty("ConsumeParcelId")]
  public long ConsumeParcelId { get; set; }
  [Newtonsoft.Json.JsonProperty("ShopFilterType")]
  public FlatData.ShopFilterType ShopFilterType { get; set; }
  [Newtonsoft.Json.JsonProperty("GoodsId")]
  public long GoodsId { get; set; }

  public ShopFilterClassifiedExcelT() {
    this.Id = 0;
    this.CategoryType = FlatData.ShopCategoryType.General;
    this.ConsumeParcelType = FlatData.ParcelType.None;
    this.ConsumeParcelId = 0;
    this.ShopFilterType = FlatData.ShopFilterType.GachaTicket;
    this.GoodsId = 0;
  }
}


static public class ShopFilterClassifiedExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*CategoryType*/, 4 /*FlatData.ShopCategoryType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*ConsumeParcelType*/, 4 /*FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*ConsumeParcelId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*ShopFilterType*/, 4 /*FlatData.ShopFilterType*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*GoodsId*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
