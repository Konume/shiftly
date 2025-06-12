// Services/Notifier.cs
using System.Threading.Tasks;

namespace Shiftly.API.Services
{
    public class Notifier : INotifier
    {
        public Task SendNotificationAsync(object notification)
        {
            // Placeholder logika
            return Task.CompletedTask;
        }
    }
}
