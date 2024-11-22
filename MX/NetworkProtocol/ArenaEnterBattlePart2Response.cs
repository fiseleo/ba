using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ArenaEnterBattlePart2Response : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_EnterBattlePart2; }
        }

        public ArenaBattleDB ArenaBattleDB { get; set; }

        public ArenaPlayerInfoDB ArenaPlayerInfoDB { get; set; }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public ParcelResultDB VictoryRewards { get; set; }

        public ParcelResultDB SeasonRewards { get; set; }

        public ParcelResultDB AllTimeRewards { get; set; }

        public ArenaEnterBattlePart2Response() { }
    }
}
