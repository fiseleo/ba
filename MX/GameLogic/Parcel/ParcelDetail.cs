using System.Collections.Generic;

namespace MX.GameLogic.Parcel
{
    public class ParcelDetail
    {
        public ParcelInfo OriginParcel { get; set; }

        public ParcelInfo MailSendParcel { get; set; }

        public List<ParcelInfo> ConvertedParcelInfos { get; set; }

        public ParcelChangeType ParcelChangeType { get; set; }

        public ParcelDetail(
            ParcelInfo info,
            IEnumerable<ParcelInfo> convertedParcelInfos,
            long sendMailAmount = 0L
        ) { }

        public ParcelDetail(ParcelInfo info) { }

        public ParcelDetail() { }
    }
}
