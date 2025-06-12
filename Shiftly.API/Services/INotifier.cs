// Services/INotifier.cs
using System.Threading.Tasks;

namespace Shiftly.API.Services
{
    public interface INotifier
    {
        Task SendNotificationAsync(object notification);
    }
}
