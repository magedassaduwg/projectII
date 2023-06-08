using MassTransit;
using TeaLeaves.Helper;
using TeaLeaves.Models;

namespace TeaLeaves.Consumers
{
    /// <summary>
    /// New message consumer class will receive messages
    /// </summary>
    public class MessageConsumer : IConsumer<IUserMessage>
    {
        /// <summary>
        /// This method will be called when an incoming messages is received
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Task Consume(ConsumeContext<IUserMessage> context)
        {
            Console.WriteLine(context.Message.Text);
            CurrentUserStore.NewMessageReceived(context.Message);

            return Task.CompletedTask;
        }
    }
}
