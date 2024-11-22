using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EquipmentBatchGrowthRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Equipment_BatchGrowth; }
        }

        public List<EquipmentBatchGrowthRequestDB> EquipmentBatchGrowthRequestDBs { get; set; }

        public GearTierUpRequestDB GearTierUpRequestDB { get; set; }

        public EquipmentBatchGrowthRequest() { }
    }
}
