namespace MX.NetworkProtocol
{
    public class ShopGachaRecruitListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Shop_GachaRecruitList; }
        }

        public ShopGachaRecruitListRequest() { }
    }
}
