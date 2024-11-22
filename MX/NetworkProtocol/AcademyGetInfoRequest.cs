namespace MX.NetworkProtocol
{
    public class AcademyGetInfoRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Academy_GetInfo; }
        }

        public AcademyGetInfoRequest() { }
    }
}
