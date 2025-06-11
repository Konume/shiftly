using Azure.Messaging.ServiceBus;
using System.Text.Json;
using System.Threading.Tasks;

namespace Shiftly.API.Services
{
    public class ServiceBusNotificationService
    {
        private readonly ServiceBusSender _sender;

        public ServiceBusNotificationService(ServiceBusClient client, string queueName)
        {
            _sender = client.CreateSender(queueName);
        }

        public async Task SendNotificationAsync(object notification)
        {
            var message = new ServiceBusMessage(JsonSerializer.Serialize(notification));
            await _sender.SendMessageAsync(message);
        }
    }
}