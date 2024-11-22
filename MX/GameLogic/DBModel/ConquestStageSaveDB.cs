using FlatData;

namespace MX.GameLogic.DBModel
{
    public class ConquestStageSaveDB : ContentSaveDB
    {
        public override ContentType ContentType
        {
            get { return ContentType.None; }
        }

        public long? ConquestEventObjectDBId { get; set; }

        public long EventContentId { get; set; }

        public StageDifficulty Difficulty { get; set; }

        public long TileUniqueId { get; set; }

        public long TilePresetId { get; set; }

        public ConquestTileType ConquestTileType { get; set; }

        public bool UseManageEchelon { get; set; }

        public AssistCharacterDB AssistCharacterDB { get; set; }

        public int EchelonSlotType { get; set; }

        public int EchelonSlotIndex { get; set; }

        public ConquestStageSaveDB() { }
    }
}
