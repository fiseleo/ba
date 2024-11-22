using Microsoft.EntityFrameworkCore;

namespace MX.GameLogic.DBModel
{
    [PrimaryKey(nameof(AccountId), nameof(LocationId))]
    public class AcademyLocationDB
    {
        public long AccountId { get; set; }

        public long LocationId { get; set; }

        public long Rank { get; set; }

        public long Exp { get; set; }

        public AcademyLocationDB Clone()
        {
            return null;
        }

        public AcademyLocationDB() { }
    }
}
