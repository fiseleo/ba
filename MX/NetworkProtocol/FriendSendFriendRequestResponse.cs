﻿using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class FriendSendFriendRequestResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Friend_SendFriendRequest; }
        }

        public FriendDB[] FriendDBs { get; set; }

        public FriendDB[] SentRequestFriendDBs { get; set; }

        public FriendDB[] ReceivedRequestFriendDBs { get; set; }

        public FriendDB[] BlockedUserDBs { get; set; }

        public FriendSendFriendRequestResponse() { }
    }
}
