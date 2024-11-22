using Microsoft.EntityFrameworkCore;

namespace MX.GameLogic.DBModel
{
    [PrimaryKey(nameof(AccountServerId), nameof(ScenarioGroupUqniueId), nameof(ScenarioType))]
    public class ScenarioGroupHistoryDB
    {
        public long AccountServerId { get; set; }

        public long ScenarioGroupUqniueId { get; set; }

        public long ScenarioType { get; set; }

        public long? EventContentId { get; set; }

        public DateTime ClearDateTime { get; set; }

        public bool IsReturn { get; set; }

        public bool IsPermanent { get; set; }

        public ScenarioGroupHistoryDB() { }
    }
}
