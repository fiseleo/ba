using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ArenaEnterBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_EnterBattle; }
        }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public ArenaBattleDB ArenaBattleDB { get; set; }

        public ArenaPlayerInfoDB ArenaPlayerInfoDB { get; set; }

        public ParcelResultDB VictoryRewards { get; set; }

        public ParcelResultDB SeasonRewards { get; set; }

        public ParcelResultDB AllTimeRewards { get; set; }

        public ArenaEnterBattleResponse() { }
    }
}
