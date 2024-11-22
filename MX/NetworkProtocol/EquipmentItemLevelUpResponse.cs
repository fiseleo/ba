using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EquipmentItemLevelUpResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Equipment_LevelUp; }
        }

        public EquipmentDB EquipmentDB { get; set; }

        public AccountCurrencyDB AccountCurrencyDB { get; set; }

        public ConsumeResultDB ConsumeResultDB { get; set; }

        public EquipmentItemLevelUpResponse() { }
    }
}
