using FlatData;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class RaidLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_Lobby; }
        }

        public RaidSeasonType SeasonType { get; set; }

        public RaidGiveUpDB RaidGiveUpDB { get; set; }

        public SingleRaidLobbyInfoDB RaidLobbyInfoDB { get; set; }

        [Obsolete]
        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public RaidLobbyResponse() { }
    }
}
