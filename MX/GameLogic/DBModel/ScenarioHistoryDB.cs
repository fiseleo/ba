using Microsoft.EntityFrameworkCore;

namespace MX.GameLogic.DBModel
{
    [PrimaryKey(nameof(AccountServerId), nameof(ScenarioUniqueId))]
    public class ScenarioHistoryDB
    {
        public long AccountServerId { get; set; }

        public long ScenarioUniqueId { get; set; }

        public DateTime ClearDateTime { get; set; }

        public ScenarioHistoryDB() { }
    }
}
