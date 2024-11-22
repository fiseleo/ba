namespace MX.NetworkProtocol
{
    public class TTSGetFileResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.TTS_GetFile; }
        }

        public bool IsFileReady { get; set; }

        public string TTSFileS3Uri { get; set; }

        public TTSGetFileResponse() { }
    }
}
