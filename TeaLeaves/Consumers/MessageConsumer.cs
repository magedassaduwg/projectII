using MassTransit;
using TeaLeaves.Controllers;
using TeaLeaves.Models;

namespace TeaLeaves.Consumers
{
    /// <summary>
    /// New message consumer class will receive messages
    /// </summary>
    public class MessageConsumer : IConsumer<IMessage>
    {
        /// <summary>
        /// This method will be called when an incoming messages is received
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Task Consume(ConsumeContext<IMessage> context)
        {
            Console.WriteLine(context.Message.Text);
            CurrentUser.NewMessageReceived(context.Message);

            return Task.CompletedTask;
        }
    }
}
