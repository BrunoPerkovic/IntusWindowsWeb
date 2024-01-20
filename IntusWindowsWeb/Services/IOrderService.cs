using IntusWindowsAPI.BL.Dto;
using IntusWindowsWeb.Models;

namespace IntusWindowsWeb.Services;

public interface IOrderService
{
    Task<OrderData> CreateOrderAsync(OrderDto orderDto);
    Task<OrderData> GetOrderAsync(int id);
    Task<List<OrderData>> GetOrdersAsync();
    Task<OrderData> UpdateOrderAsync(int id, UpdateOrderDto orderDto);
    Task<OrderData> AddProductToOrderAsync(int id, int productId);
    Task<OrderData> RemoveProductFromOrderAsync(int id, int productId);
    Task<OrderData> RemoveAllProductsFromOrderAsync(int id);
    Task DeleteOrderAsync(int id);
}