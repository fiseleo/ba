using System.ComponentModel.DataAnnotations;
using MX.GameLogic.Parcel;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public abstract class ConsumableItemBaseDB : ParcelBase
    {
        [JsonIgnore]
        public ParcelKeyPair Key
        {
            get { return default(ParcelKeyPair); }
        }

        [Key]
        public long ServerId { get; set; }

        public long UniqueId { get; set; }

        public long StackCount { get; set; }

        [JsonIgnore]
        public abstract bool CanConsume { get; }

        public IConsumableItemBaseExcel GetParcelItemExcel()
        {
            return null;
        }

        protected ConsumableItemBaseDB() { }
    }
}
