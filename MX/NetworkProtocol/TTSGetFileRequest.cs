namespace MX.NetworkProtocol
{
    public class TTSGetFileRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.TTS_GetFile; }
        }

        public TTSGetFileRequest() { }
    }
}
