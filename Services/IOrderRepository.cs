using MusicStore.Models;

namespace MusicStore.Services
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
