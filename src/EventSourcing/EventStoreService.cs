using EventStore.ClientAPI;
using Microsoft.Extensions.Configuration;
using System;

namespace EventSourcing
{
    public class EventStoreService : IEventStoreService
    {
        private readonly IEventStoreConnection _connection;

        public EventStoreService(IConfiguration _configuration)
        {
            _connection = EventStoreConnection.Create(new Uri(_configuration.GetConnectionString("EventStoreConnection")));
            _connection.ConnectAsync();
        }

        public IEventStoreConnection GetConnection() => _connection;
    }
}
