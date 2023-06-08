using MassTransit;
using TeaLeaves.Consumers;
using TeaLeaves.Models;

namespace TeaLeaves.Controllers
{
    /// <summary>
    /// Creates Rabbitmq connection, adds listener and published to cloud instance
    /// </summary>
    public static class RabbitBusController
    {
        private static readonly string _host = "gull-01.rmq.cloudamqp.com";
        private static readonly string _username = "lclgtnip";
        private static readonly string _virtualHost = "lclgtnip";
        private static readonly string _password = "FQ8IxiPWyTJ_SPe3oLZ9AeeX_GcCLjnB";

        private static IBusControl _rabbitBus = null;

        /// <summary>
        /// Initializes the connection to the cloud rabbit instance
        /// </summary>
        public static async Task InitializeRabbitConnection()
        {
            try
            {
                _rabbitBus = RabbitMqBusFactory.Create(config =>
                {
                    config.Host(_host, _virtualHost, host =>
                    {
                        host.Username(_username);
                        host.Password(_password);
                    });
                });

                await _rabbitBus.StartAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Starts a consumer to list for message
        /// </summary>
        /// <param name="queueName"></param>
        public static async void AddConsumer(string queueName)
        {
            if (_rabbitBus == null)
            {
                await InitializeRabbitConnection();
            }

            _rabbitBus.ConnectReceiveEndpoint(queueName, config =>
            {
                config.UseMessageRetry(r => r.Interval(2, TimeSpan.FromMinutes(1)));
                config.UseConcurrencyLimit(1);
                config.Consumer<MessageConsumer>();
            });
        }

        /// <summary>
        /// Send a message to a queue
        /// </summary>
        /// <param name="queue"></param>
        /// <param name="message"></param>
        public static void SendMessage(string queue, IUserMessage message)
        {
            try
            {
                var endpoint = _rabbitBus.GetSendEndpoint(new Uri($"queue:{queue}")).Result;
                endpoint.Send<IUserMessage>(message).Wait();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void StopRabbitConnection()
        {
            try
            {
                _rabbitBus.StopAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
