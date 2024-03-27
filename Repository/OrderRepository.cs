using Microsoft.EntityFrameworkCore;
using Resting.Data;
using Resting.DataAccessLayer;
using Resting.Models;

public class OrderRepository : IOrderRepository
{
    private readonly DatabaseContext _context;

    public OrderRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<OrderModel>> GetAllAsync()
    {
        return await _context.Orders.ToListAsync();
    }

    public async Task<OrderModel> GetByIdAsync(int orderId)
    {
        return await _context.Orders.FindAsync(orderId);
    }

    public async Task<OrderModel> AddAsync(OrderModel order)
    {
        _context.Orders.Add(order);
        await _context.SaveChangesAsync();
        return order;
    }

    public async Task<OrderModel> UpdateAsync(OrderModel order)
    {
        _context.Entry(order).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return order;
    }

    public async Task DeleteAsync(int orderId)
    {
        var order = await _context.Orders.FindAsync(orderId);
        if (order != null)
        {
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
        }
    }
}
