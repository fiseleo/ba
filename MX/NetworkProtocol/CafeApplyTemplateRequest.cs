namespace MX.NetworkProtocol
{
    public class CafeApplyTemplateRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_ApplyTemplate; }
        }

        public long TemplateId { get; set; }

        public long CafeDBId { get; set; }

        public bool UseOtherCafeFurniture { get; set; }

        public CafeApplyTemplateRequest() { }
    }
}
