using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ClanSetAssistResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_SetAssist; }
        }

        public ClanAssistSlotDB ClanAssistSlotDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public ClanAssistRewardInfo RewardInfo { get; set; }

        public ClanSetAssistResponse() { }
    }
}
