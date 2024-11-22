using System.Collections.Generic;
using FlatData;
using MX.GameLogic.Parcel;

namespace MX.GameLogic.DBModel
{
    public class MailDB
    {
        public long ServerId { get; set; }

        public long AccountServerId { get; set; }

        public MailType Type { get; set; }

        public long UniqueId { get; set; }

        public string Sender { get; set; } = string.Empty;

        public string Comment { get; set; } = string.Empty;

        public DateTime SendDate { get; set; }

        public DateTime? ReceiptDate { get; set; }

        public DateTime? ExpireDate { get; set; }

        public List<ParcelInfo> ParcelInfos { get; set; } = [];

        public List<ParcelInfo> RemainParcelInfos { get; set; } = [];

        public bool ShouldSerializeParcelInfos()
        {
            return ParcelInfos.Count > 0;
        }

        public MailDB() { }
    }
}
