﻿using MassTransit;
using TeaLeaves.Consumers;
using TeaLeaves.Models;

namespace TeaLeaves.Controllers
{
    /// <summary>
    /// Creates Rabbitmq connection, adds listener and published to cloud instance
    /// </summary>
    public static class RabbitBus
    {
        private static readonly string _host = "gull-01.rmq.cloudamqp.com";
        private static readonly string _username = "lclgtnip";
        private static readonly string _virtualHost = "lclgtnip";
        private static readonly string _password = "FQ8IxiPWyTJ_SPe3oLZ9AeeX_GcCLjnB";

        private static IBusControl _rabbitBus = null;

        /// <summary>
        /// Initializes the connection to the cloud rabbit instance
        /// </summary>
        public static void InitializeRabbitConnection()
        {
            _rabbitBus = RabbitMqBusFactory.Create(config =>
            {
                config.Host(_host, _virtualHost, host =>
                {
                    host.Username(_username);
                    host.Password(_password);
                });
            });
        }

        /// <summary>
        /// Starts a consumer to list for message
        /// </summary>
        /// <param name="queueName"></param>
        public static void AddConsumer(string queueName)
        {
            _rabbitBus.ConnectReceiveEndpoint(queueName, config =>
            {
                config.UseMessageRetry(r => r.Interval(2, TimeSpan.FromMinutes(1)));
                config.UseConcurrencyLimit(1);
                config.Consumer<MessageConsumer>();
            });

            _rabbitBus.StartAsync();
        }

        /// <summary>
        /// Send a message to a queue
        /// </summary>
        /// <param name="queue"></param>
        /// <param name="message"></param>
        public static void SendMessage(string queue, IMessage message)
        {
            try
            {
                var endpoint = _rabbitBus.GetSendEndpoint(new Uri($"queue:{queue}")).Result;
                endpoint.Send<IMessage>(message).Wait();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
