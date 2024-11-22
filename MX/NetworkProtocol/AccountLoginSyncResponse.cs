namespace MX.NetworkProtocol
{
    public class AccountLoginSyncResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Account_LoginSync; }
        }

        public ResponsePacket Responses { get; set; }

        public CafeGetInfoResponse CafeGetInfoResponse { get; set; }

        public AccountCurrencySyncResponse AccountCurrencySyncResponse { get; set; }

        public CharacterListResponse CharacterListResponse { get; set; }

        public EquipmentItemListResponse EquipmentItemListResponse { get; set; }

        public CharacterGearListResponse CharacterGearListResponse { get; set; }

        public ItemListResponse ItemListResponse { get; set; }

        public EchelonListResponse EchelonListResponse { get; set; }

        public MemoryLobbyListResponse MemoryLobbyListResponse { get; set; }

        public CampaignListResponse CampaignListResponse { get; set; }

        public ArenaLoginResponse ArenaLoginResponse { get; set; }

        public RaidLoginResponse RaidLoginResponse { get; set; }

        public EliminateRaidLoginResponse EliminateRaidLoginResponse { get; set; }

        public CraftInfoListResponse CraftInfoListResponse { get; set; }

        public ClanLoginResponse ClanLoginResponse { get; set; }

        public MomoTalkOutLineResponse MomotalkOutlineResponse { get; set; }

        public ScenarioListResponse ScenarioListResponse { get; set; }

        public ShopGachaRecruitListResponse ShopGachaRecruitListResponse { get; set; }

        public TimeAttackDungeonLoginResponse TimeAttackDungeonLoginResponse { get; set; }

        public BillingPurchaseListByYostarResponse BillingPurchaseListByYostarResponse { get; set; }

        public EventContentPermanentListResponse EventContentPermanentListResponse { get; set; }

        public AttachmentGetResponse AttachmentGetResponse { get; set; }

        public AttachmentEmblemListResponse AttachmentEmblemListResponse { get; set; }

        public ContentSweepMultiSweepPresetListResponse ContentSweepMultiSweepPresetListResponse { get; set; }

        public StickerLoginResponse StickerListResponse { get; set; }

        public MultiFloorRaidSyncResponse MultiFloorRaidSyncResponse { get; set; }

        public long FriendCount { get; set; }

        public string FriendCode { get; set; }

        public AccountLoginSyncResponse() { }
    }
}
