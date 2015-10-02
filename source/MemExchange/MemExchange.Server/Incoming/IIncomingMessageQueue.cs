﻿using MemExchange.Core.SharedDto.ClientToServer;

namespace MemExchange.Server.Incoming
{
    public interface IIncomingMessageQueue
    {
        void Start();
        void Stop();
        void Enqueue(ClientToServerMessage clientToServerMessage);
    }
}
