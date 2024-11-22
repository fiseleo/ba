using System.Collections.Generic;
using FlatData;
using Microsoft.EntityFrameworkCore;
using MX.GameLogic.Parcel;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    [PrimaryKey(nameof(AccountServerId), nameof(MemoryLobbyUniqueId))]
    public class MemoryLobbyDB : ParcelBase
    {
        public override ParcelType Type
        {
            get { return ParcelType.MemoryLobby; }
        }

        [JsonIgnore]
        public override IEnumerable<ParcelInfo> ParcelInfos
        {
            get { return null; }
        }

        public long AccountServerId { get; set; }

        public long MemoryLobbyUniqueId { get; set; }

        public override string ToString()
        {
            return null;
        }

        public MemoryLobbyDB() { }
    }
}
