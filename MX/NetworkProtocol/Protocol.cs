﻿namespace MX.NetworkProtocol
{
    public enum Protocol
    {
        Common_Cheat = -0x270F,
        Error = -1,
        None,
        System_Version,

        [Obsolete]
        Session_Info,
        NetworkTime_Sync,

        [Obsolete]
        NetworkTime_SyncReply,
        Audit_GachaStatistics,
        Account_Create = 0x3E8,
        Account_Nickname,
        Account_Auth,
        Account_CurrencySync,
        Account_SetRepresentCharacterAndComment,
        Account_GetTutorial,
        Account_SetTutorial,
        Account_PassCheck,
        Account_VerifyForYostar,
        Account_CheckYostar,
        Account_CallName,
        Account_BirthDay,
        Account_Auth2,
        Account_LinkReward,
        Account_ReportXignCodeCheater,
        Account_DismissRepurchasablePopup,
        Account_InvalidateToken,
        Account_LoginSync,
        Account_Reset,
        Account_RequestBirthdayMail,
        Character_List = 0x7D0,
        Character_Transcendence,
        Character_ExpGrowth,
        Character_FavorGrowth,
        Character_UpdateSkillLevel,
        Character_UnlockWeapon,
        Character_WeaponExpGrowth,
        Character_WeaponTranscendence,
        Character_SetFavorites,
        Character_SetCostume,
        Character_BatchSkillLevelUpdate,
        Character_PotentialGrowth,
        Equipment_List = 0xBB8,
        Equipment_Sell,
        Equipment_Equip,
        Equipment_LevelUp,
        Equipment_TierUp,
        Equipment_Lock,
        Equipment_BatchGrowth,
        Item_List = 0xFA0,
        Item_Sell,
        Item_Consume,
        Item_Lock,
        Item_BulkConsume,
        Item_SelectTicket,
        Item_AutoSynth,
        Echelon_List = 0x1388,
        Echelon_Save,
        Echelon_PresetList,
        Echelon_PresetSave,
        Echelon_PresetGroupRename,
        Campaign_List = 0x1770,
        Campaign_EnterMainStage,
        Campaign_ConfirmMainStage,
        Campaign_DeployEchelon,
        Campaign_WithdrawEchelon,
        Campaign_MapMove,
        Campaign_EndTurn,
        Campaign_EnterTactic,
        Campaign_TacticResult,
        Campaign_Retreat,
        Campaign_ChapterClearReward,
        Campaign_Heal,
        Campaign_EnterSubStage,
        Campaign_SubStageResult,
        Campaign_Portal,
        Campaign_ConfirmTutorialStage,
        Campaign_PurchasePlayCountHardStage,
        Campaign_EnterTutorialStage,
        Campaign_TutorialStageResult,
        Campaign_RestartMainStage,
        Campaign_EnterMainStageStrategySkip,
        Campaign_MainStageStrategySkipResult,
        Mail_List = 0x1B58,
        Mail_Check,
        Mail_Receive,
        Mission_List = 0x1F40,
        Mission_Reward,
        Mission_MultipleReward,
        Mission_GuideReward,
        Mission_MultipleGuideReward,
        Mission_Sync,
        Mission_GuideMissionSeasonList,
        Attendance_List = 0x2328,
        Attendance_Check,
        Attendance_Reward,
        Shop_BuyMerchandise = 0x2710,
        Shop_BuyGacha,
        Shop_List,
        Shop_Refresh,
        Shop_BuyEligma,
        Shop_BuyGacha2,
        Shop_GachaRecruitList,
        Shop_BuyRefreshMerchandise,
        Shop_BuyGacha3,
        Shop_BuyAP,
        Shop_BeforehandGachaGet,
        Shop_BeforehandGachaRun,
        Shop_BeforehandGachaSave,
        Shop_BeforehandGachaPick,
        Recipe_Craft = 0x2AF8,
        MemoryLobby_List = 0x2EE0,
        MemoryLobby_SetMain,
        MemoryLobby_UpdateLobbyMode,
        MemoryLobby_Interact,

        [Obsolete]
        CumulativeTimeReward_List = 0x32C8,

        [Obsolete]
        CumulativeTimeReward_Reward,
        OpenCondition_List = 0x3A98,
        OpenCondition_Set,
        OpenCondition_EventList,
        Toast_List = 0x3E80,
        Raid_List = 0x4268,
        Raid_CompleteList,
        Raid_Detail,
        Raid_Search,
        Raid_CreateBattle,
        Raid_EnterBattle,
        Raid_BattleUpdate,
        Raid_EndBattle,
        Raid_Reward,
        Raid_RewardAll,
        Raid_Revive,
        Raid_Share,
        Raid_SeasonInfo,
        Raid_SeasonReward,
        Raid_Lobby,
        Raid_GiveUp,
        Raid_OpponentList,
        Raid_RankingReward,
        Raid_Login,
        Raid_Sweep,
        Raid_GetBestTeam,
        SkipHistory_List = 0x4650,
        SkipHistory_Save,
        Scenario_List = 0x4A38,
        Scenario_Clear,
        Scenario_GroupHistoryUpdate,
        Scenario_Skip,
        Scenario_Select,
        Scenario_AccountStudentChange,
        Scenario_LobbyStudentChange,
        Scenario_SpecialLobbyChange,
        Scenario_Enter,
        Scenario_EnterMainStage,
        Scenario_ConfirmMainStage,
        Scenario_DeployEchelon,
        Scenario_WithdrawEchelon,
        Scenario_MapMove,
        Scenario_EndTurn,
        Scenario_EnterTactic,
        Scenario_TacticResult,
        Scenario_Retreat,
        Scenario_Portal,
        Scenario_RestartMainStage,
        Scenario_SkipMainStage,
        Cafe_Get = 0x4E20,
        Cafe_Ack,
        Cafe_Deploy,
        Cafe_Relocate,
        Cafe_Remove,
        Cafe_RemoveAll,
        Cafe_Interact,
        Cafe_ListPreset,
        Cafe_RenamePreset,
        Cafe_ClearPreset,
        Cafe_UpdatePresetFurniture,
        Cafe_ApplyPreset,
        Cafe_RankUp,
        Cafe_ReceiveCurrency,
        Cafe_GiveGift,
        Cafe_SummonCharacter,
        Cafe_TrophyHistory,
        Cafe_ApplyTemplate,
        Cafe_Open,
        Craft_List = 0x5208,
        Craft_SelectNode,
        Craft_UpdateNodeLevel,
        Craft_BeginProcess,
        Craft_CompleteProcess,
        Craft_Reward,
        Craft_HistoryList,
        Craft_ShiftingBeginProcess,
        Craft_ShiftingCompleteProcess,
        Craft_ShiftingReward,
        Craft_AutoBeginProcess,
        Craft_CompleteProcessAll,
        Craft_RewardAll,
        Craft_ShiftingCompleteProcessAll,
        Craft_ShiftingRewardAll,
        Arena_EnterLobby = 0x55F0,
        Arena_Login,
        Arena_SettingChange,
        Arena_OpponentList,
        Arena_EnterBattle,
        Arena_EnterBattlePart1,
        Arena_EnterBattlePart2,
        Arena_BattleResult,
        Arena_CumulativeTimeReward,
        Arena_DailyReward,
        Arena_RankList,
        Arena_History,
        Arena_RecordSync,
        Arena_TicketPurchase,
        Arena_DamageReport,
        Arena_CheckSeasonCloseReward,
        Arena_SyncEchelonSettingTime,
        WeekDungeon_List = 0x59D8,
        WeekDungeon_EnterBattle,
        WeekDungeon_BattleResult,
        WeekDungeon_Retreat,
        Academy_GetInfo = 0x5DC0,
        Academy_AttendSchedule,
        Academy_AttendFavorSchedule,
        Event_GetList = 0x61A8,
        Event_GetImage,
        Event_UseCoupon,
        Event_RewardIncrease,
        ContentSave_Get = 0x6590,
        ContentSave_Discard,
        ContentSweep_Request = 0x6978,
        ContentSweep_MultiSweep,
        ContentSweep_MultiSweepPresetList,
        ContentSweep_SetMultiSweepPreset,
        Clan_Lobby = 0x6D60,
        Clan_Login,
        Clan_Search,
        Clan_Create,
        Clan_Member,
        Clan_Applicant,
        Clan_Join,
        Clan_Quit,
        Clan_Permit,
        Clan_Kick,
        Clan_Setting,
        Clan_Confer,
        Clan_Dismiss,
        Clan_AutoJoin,
        Clan_MemberList,
        Clan_CancelApply,
        Clan_MyAssistList,
        Clan_SetAssist,
        Clan_ChatLog,
        Clan_Check,
        Clan_AllAssistList,
        Billing_TransactionStartByYostar = 0x7148,
        Billing_TransactionEndByYostar,
        Billing_PurchaseListByYostar,
        EventContent_AdventureList = 0x7530,
        EventContent_EnterMainStage,
        EventContent_ConfirmMainStage,
        EventContent_EnterTactic,
        EventContent_TacticResult,
        EventContent_EnterSubStage,
        EventContent_SubStageResult,
        EventContent_DeployEchelon,
        EventContent_WithdrawEchelon,
        EventContent_MapMove,
        EventContent_EndTurn,
        EventContent_Retreat,
        EventContent_Portal,
        EventContent_PurchasePlayCountHardStage,
        EventContent_ShopList,
        EventContent_ShopRefresh,
        EventContent_ReceiveStageTotalReward,
        EventContent_EnterMainGroundStage,
        EventContent_MainGroundStageResult,
        EventContent_ShopBuyMerchandise,
        EventContent_ShopBuyRefreshMerchandise,
        EventContent_SelectBuff,
        EventContent_BoxGachaShopList,
        EventContent_BoxGachaShopPurchase,
        EventContent_BoxGachaShopRefresh,
        EventContent_CollectionList,
        EventContent_CollectionForMission,
        EventContent_ScenarioGroupHistoryUpdate,
        EventContent_CardShopList,
        EventContent_CardShopShuffle,
        EventContent_CardShopPurchase,
        EventContent_RestartMainStage,
        EventContent_LocationGetInfo,
        EventContent_LocationAttendSchedule,
        EventContent_FortuneGachaPurchase,
        EventContent_SubEventLobby,
        EventContent_EnterStoryStage,
        EventContent_StoryStageResult,
        EventContent_DiceRaceLobby,
        EventContent_DiceRaceRoll,
        EventContent_DiceRaceLapReward,
        EventContent_PermanentList,
        EventContent_DiceRaceUseItem,
        EventContent_CardShopPurchaseAll,
        EventContent_TreasureLobby,
        EventContent_TreasureFlip,
        EventContent_TreasureNextRound,
        TTS_GetFile = 0x7918,
        ContentLog_UIOpenStatistics = 0x7D00,
        MomoTalk_OutLine = 0x80E8,
        MomoTalk_MessageList,
        MomoTalk_Read,
        MomoTalk_Reply,
        MomoTalk_FavorSchedule,
        ClearDeck_List = 0x84D0,
        MiniGame_StageList = 0x88B8,
        MiniGame_EnterStage,
        MiniGame_Result,
        MiniGame_MissionList,
        MiniGame_MissionReward,
        MiniGame_MissionMultipleReward,
        MiniGame_ShootingLobby,
        MiniGame_ShootingBattleEnter,
        MiniGame_ShootingBattleResult,
        MiniGame_ShootingSweep,
        MiniGame_TableBoardSync,
        MiniGame_TableBoardMove,
        MiniGame_TableBoardEncounterInput,
        MiniGame_TableBoardBattleEncounter,
        MiniGame_TableBoardBattleRunAway,
        MiniGame_TableBoardClearThema,
        MiniGame_TableBoardUseItem,
        MiniGame_TableBoardResurrect,
        MiniGame_TableBoardSweep,
        MiniGame_TableBoardMoveThema,
        MiniGame_DreamMakerGetInfo,
        MiniGame_DreamMakerNewGame,
        MiniGame_DreamMakerRestart,
        MiniGame_DreamMakerAttendSchedule,
        MiniGame_DreamMakerDailyClosing,
        MiniGame_DreamMakerEnding,
        Notification_LobbyCheck = 0x8CA0,
        Notification_EventContentReddotCheck,
        ProofToken_RequestQuestion = 0x9088,
        ProofToken_Submit,
        SchoolDungeon_List = 0x9470,
        SchoolDungeon_EnterBattle,
        SchoolDungeon_BattleResult,
        SchoolDungeon_Retreat,
        TimeAttackDungeon_Lobby = 0x9858,
        TimeAttackDungeon_CreateBattle,
        TimeAttackDungeon_EnterBattle,
        TimeAttackDungeon_EndBattle,
        TimeAttackDungeon_Sweep,
        TimeAttackDungeon_GiveUp,
        TimeAttackDungeon_Login,
        WorldRaid_Lobby = 0x9C40,
        WorldRaid_BossList,
        WorldRaid_EnterBattle,
        WorldRaid_BattleResult,
        WorldRaid_ReceiveReward,
        ResetableContent_Get = 0xA028,
        Conquest_GetInfo = 0xA410,
        Conquest_Conquer,
        Conquest_ConquerWithBattleStart,
        Conquest_ConquerWithBattleResult,
        Conquest_DeployEchelon,
        Conquest_ManageBase,
        Conquest_UpgradeBase,
        Conquest_TakeEventObject,
        Conquest_EventObjectBattleStart,
        Conquest_EventObjectBattleResult,
        Conquest_ReceiveCalculateRewards,
        Conquest_NormalizeEchelon,
        Conquest_Check,
        Conquest_ErosionBattleStart,
        Conquest_ErosionBattleResult,
        Conquest_MainStoryGetInfo,
        Conquest_MainStoryConquer,
        Conquest_MainStoryConquerWithBattleStart,
        Conquest_MainStoryConquerWithBattleResult,
        Conquest_MainStoryCheck,
        Friend_List = 0xA7F8,
        Friend_Remove,
        Friend_GetFriendDetailedInfo,
        Friend_GetIdCard,
        Friend_SetIdCard,
        Friend_Search,
        Friend_SendFriendRequest,
        Friend_AcceptFriendRequest,
        Friend_DeclineFriendRequest,
        Friend_CancelFriendRequest,
        Friend_Check,
        Friend_ListByIds,
        Friend_Block,
        Friend_Unblock,
        CharacterGear_List = 0xABE0,
        CharacterGear_Unlock,
        CharacterGear_TierUp,
        EliminateRaid_Login = 0xAFC8,
        EliminateRaid_Lobby,
        EliminateRaid_OpponentList,
        EliminateRaid_GetBestTeam,
        EliminateRaid_CreateBattle,
        EliminateRaid_EnterBattle,
        EliminateRaid_EndBattle,
        EliminateRaid_GiveUp,
        EliminateRaid_Sweep,
        EliminateRaid_SeasonReward,
        EliminateRaid_RankingReward,
        EliminateRaid_LimitedReward,
        Attachment_Get = 0xB3B0,
        Attachment_EmblemList,
        Attachment_EmblemAcquire,
        Attachment_EmblemAttach,
        Sticker_Login = 0xB798,
        Sticker_Lobby,
        Sticker_UseSticker,
        Field_Sync = 0xBB80,
        Field_Interaction,
        Field_QuestClear,
        Field_SceneChanged,
        Field_EndDate,
        Field_EnterStage,
        Field_StageResult,
        MultiFloorRaid_Sync = 0xBF68,
        MultiFloorRaid_EnterBattle,
        MultiFloorRaid_EndBattle,
        MultiFloorRaid_ReceiveReward,
        Queuing_GetTicket = 0xC350
    }
}
