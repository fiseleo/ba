using FlatData;

namespace MX.GameLogic.DBModel
{
    public class ClanAssistSlotDB
    {
        public EchelonType EchelonType { get; set; }

        public long SlotNumber { get; set; }

        public long CharacterDBId { get; set; }

        public DateTime DeployDate { get; set; }

        public long TotalRentCount { get; set; }

        public int CombatStyleIndex { get; set; }

        public ClanAssistSlotDB() { }
    }
}
