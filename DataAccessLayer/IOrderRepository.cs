using Resting.Models;

namespace Resting.DataAccessLayer
{
    public interface IOrderRepository
    {
        Task<IEnumerable<OrderModel>> GetAllAsync();
        Task<OrderModel> GetByIdAsync(int orderId);
        Task<OrderModel> AddAsync(OrderModel order);
        Task<OrderModel> UpdateAsync(OrderModel order);
        Task DeleteAsync(int orderId);
    }
}
