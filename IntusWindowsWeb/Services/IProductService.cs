using IntusWindowsAPI.BL.Data;
using IntusWindowsAPI.BL.Dto;
using IntusWindowsWeb.Models;

namespace IntusWindowsWeb.Services;

public interface IProductService
{
    Task<ProductData> CreateProductAsync(ProductDto productDto);
    Task<ProductData> GetProductAsync(int id);
    Task<List<ProductData>> GetProductsAsync();
    Task<List<ProductData>> GetProductsByTypeAsync(ProductType type);
    Task<ProductData> UpdateProductAsync(int id, ProductDto productDto);
    Task DeleteProductAsync(int id);
} 