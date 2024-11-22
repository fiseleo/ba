using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ToastListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Toast_List; }
        }

        public List<ToastDB> ToastDBs { get; set; }

        public ToastListResponse() { }
    }
}
