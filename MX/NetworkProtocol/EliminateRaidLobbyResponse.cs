using FlatData;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EliminateRaidLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_Lobby; }
        }

        public RaidSeasonType SeasonType { get; set; }

        public RaidGiveUpDB RaidGiveUpDB { get; set; }

        public EliminateRaidLobbyInfoDB RaidLobbyInfoDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EliminateRaidLobbyResponse() { }
    }
}
